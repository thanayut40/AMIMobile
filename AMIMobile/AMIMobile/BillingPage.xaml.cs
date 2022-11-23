using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace AMIMobile
{
    public partial class BillingPage : ContentPage
    {
        ObservableCollection<DetailBilling> Billing;
        public class DetailBilling
        {
            public int ID { get; set; }
            public string Img { get; set; }


        }
        public BillingPage()
        {
            InitializeComponent();
            //PostData();
            Billing = new ObservableCollection<DetailBilling>
            {
                new DetailBilling{ID=1,Img="img_loadprofile.png"},
                 new DetailBilling{ID=2,Img="img_loadprofile.png"},
                  new DetailBilling{ID=3,Img="img_loadprofile.png"},

            };

            Collection_Billing.ItemsSource = Billing;
        }
        private async void PostData()
        {
            BillingItemsModel billing = new BillingItemsModel()
            {

                customerAccount = "020017788520",
                meterNo = "6540000115",
                report = "",
                duration = "",
                date = "",
                showLpfExport = "1",
                language = "th",

            };
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            Uri RequestUri = new Uri("https://43.249.113.168/cep.api/Customer/Billing");
            var client = new HttpClient(handler);
            var json = JsonConvert.SerializeObject(billing);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(RequestUri, contentJson);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                //await Navigation.PushAsync(new MyPage());
                var content = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<List<BillingItemsModel>>(content);
                //Response responseData = JsonConvert.DeserializeObject<Response>(content);
                Console.WriteLine(content);
                //Collection_BillingMonth. = result;


            }
            else
            {
                await DisplayAlert("แจ้งเตือน", "ไม่สำเร็จ", "ปิด");
            }
        }

        //    void Picker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        //    {
        //    }
    }
}

