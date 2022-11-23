using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using static AMIMobile.SettingSecurityPage;

namespace AMIMobile
{
    public partial class SettingAccessPage : ContentPage
    {


        //public class Data
        //{
        //    public string logDate { get; set; }
        //    public string deviceName { get; set; }
        //    public string platform { get; set; }
        //    public string status { get; set; }

        //}
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

        public SettingAccessPage()
        {

            InitializeComponent();

            //GetAccess();

            //dataAccess = new ObservableCollection<Data>
            //{
            //    new Data{ logDate = "01/10/2022 10.00", deviceName = "HP Probook", platform = "Chome", status = "Pass"},
            //    new Data{ logDate = "30/9/2022 23.00", deviceName = "Admin0001", platform = "Firefox", status = "Fail" },
            //    new Data{logDate = "30/09/2022 22.48", deviceName = "Admin0001", platform = "Firefox", status = "Fail" },
            //    new Data{ logDate = "30/09/2022 22.32", deviceName = "Admin0002", platform = "Android", status = "Fail" },

            //};
            //List_Data.ItemsSource = dataAccess;

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
                    BackgroundImageSource = ImageSource.FromFile("b_Small/b_Main_Small.png");
                }
                else if (DeviceDisplay.MainDisplayInfo.Height <= MediumHeightResolution && DeviceDisplay.MainDisplayInfo.Width <= MediumWightResolution)
                {
                    BackgroundImageSource = ImageSource.FromFile("b_Medium/b_Main_Medium.png");
                }
                else if (DeviceDisplay.MainDisplayInfo.Height <= LargeHeightResolution && DeviceDisplay.MainDisplayInfo.Width <= LargeWightResolution)
                {
                    BackgroundImageSource = ImageSource.FromFile("b_Large/b_Main_Large.png");
                }
                else
                {
                    BackgroundImageSource = ImageSource.FromFile("b_Extra/b_Main_Extralarge.png");

                }


            }


        }
        //async void GetAccess()
        //{

        //    HttpClient httpClient = new HttpClient();

        //    var response = await httpClient.GetAsync("https://catfact.ninja/fact");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var content = await response.Content.ReadAsStringAsync();
        //        var AccessTabel = JsonConvert.DeserializeObject<List<LogData>>(content);
        //        List_Data.ItemsSource = new ObservableCollection<LogData>(AccessTabel);
        //    }
        //    else
        //    {
        //        Debug.WriteLine("Error");
        //    }
        //    //using (var client = new HttpClient())
        //    //{
        //    //    var uri = "https://43.249.113.168/cep.api/api/Customer/Log?language=th";
        //    //    var result = await client.GetStringAsync(uri);
        //    //    var logitemlist = JsonConvert.DeserializeObject<List<LogItemModel>>(result);
        //    //    LogItems = new ObservableCollection<LogItemModel>(logitemlist);

        //    //}





        //}
        //ObservableCollection<LogItemModel> _logitem;
        //public ObservableCollection<LogItemModel> LogItems
        //{
        //    get
        //    {
        //        return _logitem;
        //    }
        //    set
        //    {
        //        _logitem = value;
        //        OnPropertyChanged();
        //    }

        //}
        //protected event PropertyChangingEventHandler PropertyChanged;
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        //}
    }



}







