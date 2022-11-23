using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AMIMobile
{
    public class BillingItemsModel
    {
        [JsonProperty("customerAccount")]
        public string customerAccount { get; set; }
        [JsonProperty("meterNo")]
        public string meterNo { get; set; }
        [JsonProperty("report")]
        public string report { get; set; }
        [JsonProperty("duration")]
        public string duration { get; set; }
        [JsonProperty("date")]
        public string date { get; set; }
        [JsonProperty("showLpfExport")]
        public string showLpfExport { get; set; }
        [JsonProperty("language")]
        public string language { get; set; }
        [JsonProperty("title1")]
        public string title1 { get; set; }
        [JsonProperty("title2")]
        public string title2 { get; set; }
        [JsonProperty("titleCustomer")]
        public string titleCustomer { get; set; }
        [JsonProperty("titleTblImp")]
        public string titleTblImp { get; set; }
        [JsonProperty("titleTblExp")]
        public string titleTblExp { get; set; }
        [JsonProperty("customerLabel")]
        public List<string> customerLabel { get; set; }
        [JsonProperty("TblHeader")]
        public TblHeader TblHeader { get; set; }
        [JsonProperty("Page")]
        public Page Page { get; set; }
    }


    public class Page
    {
        [JsonProperty("titlePage")]
        public string titlePage { get; set; }
        [JsonProperty("titlePagePDF")]
        public string titlePagePDF { get; set; }
        [JsonProperty("TblImp")]
        public List<TblImp> TblImp { get; set; }
        [JsonProperty("TblExp")]
        public List<TblExp> TblExp { get; set; }
    }
    public class TblHeader
    {
        [JsonProperty("code")]
        public string code { get; set; }
        [JsonProperty("descript")]
        public string descript { get; set; }
        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class TblExp
    {
        [JsonProperty("code")]
        public string code { get; set; }
        [JsonProperty("descript")]
        public string descript { get; set; }
        [JsonProperty("value")]
        public string value { get; set; }
    }
    public class TblImp
    {
        [JsonProperty("code")]
        public string code { get; set; }
        [JsonProperty("descript")]
        public string descript { get; set; }
        [JsonProperty("value")]
        public string value { get; set; }
    }
}
