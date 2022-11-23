using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using Plugin.Multilingual;
using System.Linq;
using System.Globalization;
using System.Threading;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace AMIMobile
{
    public partial class LoginPage : ContentPage
    {
        
        public bool HidePassword { get; private set; }
        public ImageSource ShowIcon { get; private set; }
        public ImageSource HideIcon { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
            
            string language = Thread.CurrentThread.CurrentUICulture.Name;
            
        }
        bool showPassword = true;
        private void PasswordIcon_Clicked(object sender, EventArgs e)
        {
            if (showPassword)
            {
                Ic_Password.Source = "ic_eye_hide.png";
                inputPassword.IsPassword = false;
                showPassword = false;
            }
            else
            {
                Ic_Password.Source = "ic_eye_show.png";
                inputPassword.IsPassword = true;
                showPassword = true;
            }
        }
        async void Btn_Clicked_Login(object sender, EventArgs e)
        {
            PostDataAsync();

        }

        private async void PostDataAsync()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            HttpClient client = new HttpClient(handler);
            LoginItemsModel login = new LoginItemsModel()
            {
                Username = inputUsername.Text,
                Password = inputPassword.Text

            };
            Uri RequestUri = new Uri("https://43.249.113.168/ami.api/Authentication/login");
            var json = JsonConvert.SerializeObject(login);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(RequestUri, contentJson);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<LoginItemsModel>>(content);

                Console.WriteLine(content);
                if (inputUsername.Text == null && inputPassword.Text == null)
                {
                    await DisplayAlert("เข้าใช้งานไม่สำเร็จ", "กรุณากรอกข้อมูลให้ถูกต้อง", "ตกลง", "ยกเลิก");
                }

                else
                {
                    await Navigation.PushAsync(new TabPage());
                }

            }
            else
            {
                await DisplayAlert("แจ้งเตือน", "ลงชื่อเข้าใช้ผิดพลาด", "ปิด");
            }


        }
        private async void ForgotPass_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassPage());
        }
        protected void Btn_Cilck_Eng(object sender, EventArgs args)
        {

            Btn_Thai.BackgroundColor = Color.FromHex("#FFF");
            Btn_Thai.TextColor = Color.FromHex("#74065F");
            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromHex("#74065F");
            btn.TextColor = Color.FromHex("#FFF");


        }
        protected void Btn_Cilck_Thai(object sender, EventArgs args)
        {
            Btn_Eng.BackgroundColor = Color.FromHex("#FFF");
            Btn_Eng.TextColor = Color.FromHex("#74065F");

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromHex("#74065F");
            btn.TextColor = Color.FromHex("#FFF");
        }
    }
}

