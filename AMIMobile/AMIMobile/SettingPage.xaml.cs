using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AMIMobile
{
    public partial class SettingPage : ContentPage
    {
        const int SmallWightResolution = 720;
        const int SmallHeightResolution = 1280;
        //Medium
        const int MediumWightResolution = 828;
        const int MediumHeightResolution = 1729;
        //Large
        const int LargeWightResolution = 1284;
        const int LargeHeightResolution = 2778;
        //ExtraLarge
        const int ExtraLargeWightResolution = 1440;
        const int ExtraLargeHeightResolution = 3200;
        //ObservableCollection<ListSettings> Settings;
        //public class ListSettings

        //{
        //    public int Id { get; set; }
        //    public string Setting_Title { get; set; }
        //    public string Image { get; set; }


        //}
        public SettingPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
            {

                if (DeviceDisplay.MainDisplayInfo.Height <= SmallHeightResolution && DeviceDisplay.MainDisplayInfo.Width <= SmallWightResolution)
                {
                    BackgroundImageSource = ImageSource.FromFile("drawable/b_Small/b_Main_Small.png");


                }
                else if (DeviceDisplay.MainDisplayInfo.Height <= MediumHeightResolution && DeviceDisplay.MainDisplayInfo.Width <= MediumWightResolution)
                {
                    BackgroundImageSource = ImageSource.FromFile("drawable/b_Medium/b_Main_Medium.png");



                }
                else if (DeviceDisplay.MainDisplayInfo.Height <= LargeHeightResolution && DeviceDisplay.MainDisplayInfo.Width <= LargeWightResolution)
                {

                    BackgroundImageSource = ImageSource.FromFile("drawable/b_Large/b_Main_Large.png");

                }
                else
                {
                    BackgroundImageSource = ImageSource.FromFile("drawable/b_Extra/b_Main_Extralarge.png");

                }
            }
            else
            {
                if (DeviceDisplay.MainDisplayInfo.Height <= SmallHeightResolution && DeviceDisplay.MainDisplayInfo.Width <= SmallWightResolution)
                {
                    //BackgroundImageSource = ImageSource.FromFile("b_Small/b_Splash_Small.png");
                    BackgroundImageSource = ImageSource.FromFile("b_Small/b_Main_Small.png");

                }
                else if (DeviceDisplay.MainDisplayInfo.Height <= MediumHeightResolution && DeviceDisplay.MainDisplayInfo.Width <= MediumWightResolution)
                {
                    //BackgroundImageSource = ImageSource.FromFile("b_Medium/b_Splash_Medium.png");
                    BackgroundImageSource = ImageSource.FromFile("b_Medium/b_Main_Medium.png");

                }
                else if (DeviceDisplay.MainDisplayInfo.Height <= LargeHeightResolution && DeviceDisplay.MainDisplayInfo.Width <= LargeWightResolution)
                {

                    //BackgroundImageSource = ImageSource.FromFile("b_Large/b_Splash_Large.png");
                    BackgroundImageSource = ImageSource.FromFile("b_Large/b_Main_Large.png");
                }
                else
                {
                    //BackgroundImageSource = ImageSource.FromFile("b_Extra/b_Splash_Extralarge.png");
                    BackgroundImageSource = ImageSource.FromFile("b_Extra/b_Main_Extralarge.png");

                }
            }
            //Settings = new ObservableCollection<ListSettings>
            //    {
            //        new ListSettings{ Id=1,Setting_Title="ผู้ใช้งาน" ,Image="icons/ic_user_3.png"},
            //        new ListSettings{ Id=2,Setting_Title="ตั้งค่าภาษา" ,Image="icons/ic_translate.png"},
            //         new ListSettings{ Id=3,Setting_Title="การจัดการความปลอดภัย",Image="icons/ic_fingerprint.png" },
            //          new ListSettings{ Id=4,Setting_Title="บันทึกการเข้าใช้งาน",Image="icons/ic_sync.png" },
            //          new ListSettings{ Id=5,Setting_Title="เกี่ยวกับ" ,Image="icons/ic_warning.png"},

            //    };
            //List_Settings.ItemsSource = Settings;
        }
        //async private void Setting_ItemTapped(object sender, SelectionChangedEventArgs e)
        //{
        //    var selecteditem = e.CurrentSelection[0] as ListSettings;
        //    switch (selecteditem.Id)
        //    {
        //        case 1:
        //            await Navigation.PushAsync(new SettingUserPage());
        //            break;
        //        case 2:
        //            await Navigation.PushAsync(new SettingLanguagePage());
        //            break;
        //        case 3:
        //            await Navigation.PushAsync(new SettingSecurityPage());
        //            break;
        //        case 4:
        //            await Navigation.PushAsync(new SettingAccessPage());
        //            break;
        //        case 5:
        //            await Navigation.PushAsync(new AboutPage());
        //            break;

        //    }
        //    //((ListView)sender).SelectedItem = null;

        //}
        private async void Click_SettingUser(object sender, EventArgs e)
        {
            //SetStyle(1);
            await Navigation.PushAsync(new SettingUserPage());
        }
        private async void Click_Language(object sender, EventArgs e)
        {
            //SetStyle(2);
            await Navigation.PushAsync(new SettingLanguagePage());
        }
        private async void Click_Security(object sender, EventArgs e)
        {
            //SetStyle(3);
            await Navigation.PushAsync(new SettingSecurityPage());
        }
        private async void Click_Access(object sender, EventArgs e)
        {
            //SetStyle(4);
            await Navigation.PushAsync(new SettingAccessPage());
        }
        private async void Click_About(object sender, EventArgs e)
        {
            //SetStyle(5);
            await Navigation.PushAsync(new AboutPage());
        }
        private async void Btn_Logout(object sender, EventArgs e)
        {
            //SetStyle(5);
            await Navigation.PushAsync(new LoginPage());
        }
    }

}