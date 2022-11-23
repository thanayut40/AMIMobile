using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using Xamarin.Essentials;
using Xamarin.Forms;
using static AMIMobile.AccountPage;

namespace AMIMobile
{
    public partial class SettingSecurityPage : ContentPage
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
        //ObservableCollection<TitlePass> change_pass;
        public class TitlePass
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string Icon { get; set; }
        }
        ObservableCollection<TitleScan> Scan;
        public class TitleScan
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string Icon { get; set; }

        }

        public SettingSecurityPage()
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

            Scan = new ObservableCollection<TitleScan>
            {
                new TitleScan{ID=1,Icon="ic_fingerprint.png", Title="การสแกนรอยนิ้วมือ"},
                 new TitleScan{ID=2,Icon="ic_faceid.png", Title="การสแกนใบหน้า"},
            };
            List_Settings_Scan.ItemsSource = Scan;
        }
        //change_pass = new ObservableCollection<TitlePass>
        //{
        //    new TitlePass{ID=1,Icon="icons/ic_lock.png", Title="เปลี่ยนรหัสผ่าน"},

        //};
        //List_Settings_Pass.ItemsSource = change_pass;

        //async private void SetPass_ItemTapped(object sender, SelectionChangedEventArgs e)
        //{
        //    var selecteditem = e.CurrentSelection[0] as TitlePass;
        //    switch (selecteditem.ID)
        //    {
        //        case 1:
        //            await Navigation.PushAsync(new CheckPassPage());
        //            break;
        //    }

        //}

        private async void Click_ChangePass(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckPassPage());
        }


    }

}


