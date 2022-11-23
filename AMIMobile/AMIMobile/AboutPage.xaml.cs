using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AMIMobile
{
    public partial class AboutPage : ContentPage
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
        public AboutPage()
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

        }
    }
}

