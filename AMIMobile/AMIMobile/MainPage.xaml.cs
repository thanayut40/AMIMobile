using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AMIMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //BackGround();
            Splash();

        }
        private async void Scan()
        {
            //var availability = await CrossFingerprint.Current.IsAvailableAsync();
            //if (!availability)
            //{
            //    await DisplayAlert("Authentication", "สแกนไม่สำเร็จ, ลองอีกครั้ง", "ปิด");
                //return;
            //}
            
            AuthenticationRequestConfiguration configuration = new AuthenticationRequestConfiguration("Authentication", "กรุณาสแกนเพื่อเข้าใช้งาน");

            var result = await CrossFingerprint.Current.AuthenticateAsync(configuration);
            Console.WriteLine(result);

            if (result.Authenticated.Equals(false))
            {

                Console.WriteLine(result.Authenticated.GetTypeCode());
                Console.WriteLine(result.Authenticated.Equals(""));
                Console.WriteLine(result.Authenticated.Equals(false));
                Console.WriteLine(result.Authenticated.GetHashCode());
                await Navigation.PushAsync(new LoginPage());

            }
            else
            {
               
                // Something went wrong!!
                // await DisplayAlert("แจ้งเตือน", "สแกนไม่สำเร็จ","ลองอีกครั้ง", "ปิด");
                //await Navigation.PushAsync(new LoginPage());

                Console.WriteLine(result.Authenticated.GetTypeCode());
                await Navigation.PushAsync(new TabPage());
            }
        }
        public async Task Splash()

        {
            await SplashLogo.FadeTo(1, 3000);
            Scan();
            //var next = Application.Current.MainPage;


            //Application.Current.MainPage = new NavigationPage(new LoginPage());

        }

    }
}

