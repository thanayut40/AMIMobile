using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace AMIMobile.Model
{

    public class InitialItemsModel
    {

        //[JsonProperty("th")]
        //public string th { get; set; }


        [JsonProperty("customers")]
        public List<Customer> customers { get; set; }

        [JsonProperty("ddlMeter")]
        public List<DdlMeter> DdlMeter { get; set; }

        [JsonProperty("ddlReport")]
        public List<DdlReport> DdlReport { get; set; }

        [JsonProperty("ddlDuration")]
        public List<DdlDuration> DdlDuration { get; set; }

        [JsonProperty("announces")]
        public List<Announce> Announces { get; set; }




        //[JsonProperty("ddlMeter")]
        //public string DdlMeter { get; set; }

        //[JsonProperty("ddlReport")]
        //public string DdlReport { get; set; }

        //[JsonProperty("ddlDuration")]
        //public string ddlDuration { get; set; }

        //[JsonProperty("announces")]
        //public string Announces { get; set; }


        //public string th { get; internal set; }


        //[JsonProperty("ddlMeter")]
        //public List<DdlMeter> DdlMeter { get; set; }

        //[JsonProperty("ddlReport")]
        //public List<DdlReport> DdlReport { get; set; }

        //[JsonProperty("ddlDuration")]
        //public List<DdlDuration> ddlDuration { get; set; }

        //[JsonProperty("announces")]
        //public List<Announce> Announces { get; set; }

    }
    public partial class Announce
    {
        [JsonProperty("id")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }
    }

    public partial class Customer
    {
        [JsonProperty("customerAccount")]
        public string CustomerAccount { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("meterNo")]
        public string MeterNo { get; set; }

        [JsonProperty("tariff")]
        public string Tariff { get; set; }

        [JsonProperty("peaSite")]
        public string PeaSite { get; set; }


        [JsonProperty("ct")]
        public string Ct { get; set; }

        [JsonProperty("vt")]
        public string Vt { get; set; }

        [JsonProperty("showLpfExport ")]
        public int ShowLpfExport { get; set; }
    }
    public partial class DdlDuration
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string Value { get; set; }

    }
    public partial class DdlReport
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string Value { get; set; }

    }

    public partial class DdlMeter
    {
        [JsonProperty("customerAccount")]
        public string CustomerAccount { get; set; }

        [JsonProperty("meters")]
        public List<string> Meters { get; set; }
    }

}


