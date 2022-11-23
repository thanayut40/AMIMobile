using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AMIMobile.Model;
using System.Text;
using System.Net;

namespace AMIMobile.Services
{

    public class AmiServices : IAmiServices
    {
        //public async Task<bool> GetDataDashboard()
        //{

        //    DashboardItemsModel dashdata = new DashboardItemsModel()
        //    {

        //        customerAccount = "020016624836",
        //        meterNo = "6540000112",
        //        report = "",
        //        duration = "",
        //        date = "",
        //        showLpfExport = "",
        //        language = "th",

        //    };
        //    HttpClientHandler handler = new HttpClientHandler();
        //    handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
        //    Uri RequestUri = new Uri("https://43.249.113.168/cep.api/Customer/Dashboard");
        //    var json = JsonConvert.SerializeObject(dashdata);
        //    var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
        //    var client = new HttpClient(handler);
        //    var response = await client.PostAsync(RequestUri, contentJson);
        //    if (response.StatusCode == HttpStatusCode.OK)
        //    {
        //        //Console.WriteLine("Checkkkkkk");
        //        //Console.WriteLine(response.StatusCode);
        //        var content = await response.Content.ReadAsStringAsync();
        //        var result = JsonConvert.DeserializeObject<List<DashboardItemsModel>>(content);

        //        Console.WriteLine("ข้อมูลล" + result.GetType());
        //        //var result = JsonConvert.DeserializeObject<List<DashboardItemsModel>>(content);


        //        //await Navigation.PushAsync(new TabPage());
        //        //Listlogin.ItemsSource = result;
        //        Collection_BillingMonth.ItemsSource = (IEnumerable)result;

        //    }
        //    else
        //    {
        //        await DisplayAlert("แจ้งเตือน", "ลงชื่อเข้าใช้ผิดพลาด", "ปิด");
        //    }

        //}

        //Task<ObservableCollection<DashboardItemsModel>> IAmiServices.GetDataDashboard()
        //{
        //    throw new NotImplementedException();
        //}
        //string Base_url = "https://43.249.113.168/ami.api/";

        //public async Task<ObservableCollection<LoginModel>> getLogin()

        //{
        //    string url = Base_url;
        //    HttpClient client = new HttpClient();
        //    HttpResponseMessage responseMessage = await client.GetAsync(url);
        //    if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        var result = await responseMessage.Content.ReadAsStringAsync();
        //        var json = JsonConvert.DeserializeObject<ObservableCollection<LoginModel>>(result);
        //    }
        //    //string Base_url = "https://43.249.113.168/cep.api/api/";
        //    //string url = Base_url;
        //    //HttpClient client = new HttpClient();
        //    //HttpResponseMessage responseMessage = await client.GetAsync(url);
        //    //if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
        //    //{
        //    //    var result = await responseMessage.Content.ReadAsStringAsync();
        //    //    var json = JsonConvert.DeserializeObject<ObservableCollection<LoginModel>>(result);
        //    //    //return json;
        //    //}

        //    //return null;

        //    //var logitem = new ObservableCollection<LogItemModel>();
        //    //HttpClient client = new HttpClient();
        //    //string url = "https://43.249.113.168/cep.api/api/Customer/Log?language=th";
        //    //client.BaseAddress = new Uri(url);
        //    //HttpResponseMessage response = await client.GetAsync("");
        //    //if (response.IsSuccessStatusCode)
        //    //{
        //    //    string content = response.Content.ReadAsStringAsync().Result;
        //    //    logitem = JsonConvert.DeserializeObject<ObservableCollection<LogItemModel>>(content);
        //    //}
        //    //return await Task.FromResult(logitem);






    }



}


