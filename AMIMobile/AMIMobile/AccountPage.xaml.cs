using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Xamarin.Forms;
using AMIMobile.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using System.Collections;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using AMIMobile.Model;
using System.Linq;

namespace AMIMobile
{
    public partial class AccountPage : ContentPage
    {
        //private ObservableCollection<InfoMeter> meter;
        //public ObservableCollection<InfoMeter> Meter
        //{
        //    get => meter;
        //    set
        //    {
        //        if (value == meter) return;
        //        meter = value;
        //        OnPropertyChanged();
        //    }
        //}
        //public class InfoMeter
        //{
        //    public int ID { get; set; }
        //    public string Meter_No { get; set; }
        //    public string Traiff { get; set; }
        //    public string CT_Ratio { get; set; }
        //    public string VT_Ratio { get; set; }
        //}
        public AccountPage()
        {
            InitializeComponent();
            GetData();
            var context = this.BindingContext;
            //Meter = new ObservableCollection<InfoMeter>
            //    {
            //        new InfoMeter{ID=1, Meter_No="27687195",Traiff="TOU",CT_Ratio ="250:5 A",VT_Ratio="1:1 V.",},
            //        new InfoMeter{ID=2,Meter_No="24346574",Traiff="TOU",CT_Ratio="250:5 A",VT_Ratio="1:1 V."},
            //        new InfoMeter{ID=3,Meter_No="14235674",Traiff="TOU",CT_Ratio="250:5 A",VT_Ratio="1:1 V."},
            //        new InfoMeter{ID=4,Meter_No="32164344",Traiff="TOU",CT_Ratio="250:5 A",VT_Ratio="1:1 V."},
            //        new InfoMeter{ ID=5,Meter_No="27687195",Traiff="TOU",CT_Ratio ="250:5 A",VT_Ratio="1:1 V."},
            //        new InfoMeter{ID=6,Meter_No="24346574",Traiff="TOU",CT_Ratio="250:5 A",VT_Ratio="1:1 V."},


            //    };
            //List_Meter.ItemsSource = Meter;
        }



        //async private void Collection_Meter_Selection(object sender, SelectionChangedEventArgs e)
        //{

        //    var selecteditem = e.CurrentSelection[0] as InfoMeter;
        //    //if (selecteditem.ID == 1)
        //    //{
        //    //    BackgroundColor = Color.FromHex("#74045F");
        //    //}
        //    switch (selecteditem.ID)
        //    {
        //        case 1:
        //            await Navigation.PushAsync(new DashBoardPage());
        //            //BackgroundColor = Color.FromHex("#74045F");

        //            break;
        //        case 2:
        //            await Navigation.PushAsync(new DashBoardPage());
        //            break;
        //        case 3:
        //            await Navigation.PushAsync(new DashBoardPage());
        //            break;
        //        case 4:
        //            await Navigation.PushAsync(new DashBoardPage());
        //            break;
        //        case 5:
        //            await Navigation.PushAsync(new DashBoardPage());
        //            break;
        //        case 6:
        //            await Navigation.PushAsync(new DashBoardPage());
        //            break;

        //    }

        //}
        private async void GetData()
        {

            //InitialItemsModel initial = new InitialItemsModel()
            //{

            //    th = "th"

            //};
            string send = "th";
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            Uri RequestUri = new Uri("https://43.249.113.168/cep.api/Customer/Initial");
            var json = JsonConvert.SerializeObject(send);

            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient(handler);
            var response = await client.PostAsync(RequestUri, contentJson);


            //byte[] responded;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<InitialItemsModel>(content);

                Console.WriteLine("ข้อมูลล" + result);
                //List_Meter.ItemsSource = (IEnumerable)result;
                int i = 0;
                while (result.customers.Count() > i)
                {
                    result.customers[i].CustomerAccount.ToString();
                    result.customers[i].CustomerName.ToString();
                    result.customers[i].MeterNo.ToString();
                    result.customers[i].Tariff.ToString();
                    result.customers[i].PeaSite.ToString();
                    result.customers[i].Ct.ToString();
                    result.customers[i].Vt.ToString();
                    result.customers[i].ShowLpfExport.ToString();

                    Console.WriteLine(result.customers[i].CustomerAccount.ToString());
                    Console.WriteLine(result.customers[i].CustomerName.ToString());
                    Console.WriteLine(result.customers[i].MeterNo.ToString());
                    Console.WriteLine(result.customers[i].Tariff.ToString());
                    Console.WriteLine(result.customers[i].PeaSite.ToString());
                    Console.WriteLine(result.customers[i].Ct.ToString());
                    Console.WriteLine(result.customers[i].Vt.ToString());
                    Console.WriteLine(result.customers[i].ShowLpfExport.ToString());
                    i++;
                    CollectionMeter.ItemsSource = result.customers;
                }

                //string gg = "gg";
                //Console.WriteLine("ข้อมูลล" + gg.GetType());

                //string jsondata = content.ToString();
                //var jsonObject = JObject.Parse(jsondata);
                //var billMonth = jsonObject["billMonth"];
                //var lpfDate = jsonObject["lpfDate"];
                //var lpfBillBoard = jsonObject["lpfBillBoard"];
                //var chartName = jsonObject["chartName"];
                //var chart = jsonObject["chart"];
                //Console.WriteLine(billMonth);


                //string jsonstring = content.ToString();



                //var result = JsonConvert.DeserializeObject<List<DashboardItemsModel>>(content);
                //Console.WriteLine("เทสสส" + result.billMonth);
                //Console.WriteLine("เทสสส" + result.lpfDate);

                //foreach (var detail in result)
                //{
                //    Console.WriteLine(detail.LpfBillBoard.ToString());
                //}
                //var result = JsonConvert.DeserializeObject<List<DashboardItemsModel>>(content);

                //Console.WriteLine(content);

                //response.Content.ReadAsByteArrayAsync().Wait();
                //responded = response.Content.ReadAsByteArrayAsync().Result;
                //var responseString = Encoding.UTF8.GetString(responded, 0, responded.Length);

                //Console.WriteLine("\n " + responseString);
                //Console.WriteLine("\n " + content);
                //Console.WriteLine("เช็คคคค" + result);
                //CollectionMeter.ItemsSource = result;
                //Collection_BillingMonth.ItemsSource = (IEnumerable)result;

                //foreach (var dash in content)
                //{

                //    //DashData.Add(dash);
                //    Console.WriteLine("เช็คคคคคคคค" + content.); ;
                //}


                //var result = JsonConvert.DeserializeObject<List<DashboardItemsModel>>(content);

                //Console.WriteLine(content);
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

