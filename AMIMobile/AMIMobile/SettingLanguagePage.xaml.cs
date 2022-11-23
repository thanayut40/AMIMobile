using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using static AMIMobile.BillingPage;

namespace AMIMobile
{
    public partial class SettingLanguagePage : ContentPage
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

        ObservableCollection<Select_Language> Language;



        public class Select_Language
        {
            public int ID { get; set; }
            public string Language { get; set; }
            public Boolean IsSeparatorVisible { get; set; }


        }
        public SettingLanguagePage()
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
            Language = new ObservableCollection<Select_Language>
            {
                new Select_Language{ID=1,Language="ภาษาไทย"},
                 new Select_Language{ID=2,Language="English"},


            };

            SelectLanguage.ItemsSource = Language;
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

        }




        //bool IsSeparatorVisible = true;
        //void SelectLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var itemSelected = e.CurrentSelection[0] as Select_Language;
        //    if (itemSelected.ID != 1)
        //    {
        //        IsSeparatorVisible = false;

        //    }
        //    else
        //    {
        //        IsSeparatorVisible = true;
        //    }


        //}


        void Btn_Select(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}

