using System;
using System.Collections.Generic;
using System.Net;
using Xamarin.Forms;
using AMIMobile.Model;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace AMIMobile
{
    public partial class TestPage : ContentPage
    {
        public ObservableCollection<DashboardItemsModel> DashData { get; set; } = new ObservableCollection<DashboardItemsModel>();
        public TestPage()
        {
            InitializeComponent();
        }
        void Button_Clicked3(object sender, EventArgs e)
        {
            GetData();

        }

        private async void GetData()
        {

            DashboardItemsModel dashdata = new DashboardItemsModel()
            {

                customerAccount = "020016624836",
                meterNo = "6540000112",
                report = "",
                duration = "",
                date = "",
                showLpfExport = "",
                language = "th",

            };
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            Uri RequestUri = new Uri("https://43.249.113.168/cep.api/Customer/Dashboard");
            var json = JsonConvert.SerializeObject(dashdata);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient(handler);
            var response = await client.PostAsync(RequestUri, contentJson);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                //Console.WriteLine("Checkkkkkk");
                //Console.WriteLine(response.StatusCode);
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<DashboardItemsModel>>(content);

                Console.WriteLine(content);
                //await Navigation.PushAsync(new TabPage());
                //Listlogin.ItemsSource = result;

            }
            else
            {
                await DisplayAlert("แจ้งเตือน", "ลงชื่อเข้าใช้ผิดพลาด", "ปิด");
            }

        }
    }
}

