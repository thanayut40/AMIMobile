using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Xamarin.Forms;

namespace AMIMobile.Model
{
    public class DashboardItemsModel
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
        [JsonProperty("billMonth")]
        public string billMonth { get; set; }
        [JsonProperty("lpfDate")]
        public string lpfDate { get; set; }
        [JsonProperty("lpfBillBoard")]
        public LpfBillBoard LpfBillBoard { get; set; }
        [JsonProperty("chartName")]
        public string ChartName { get; set; }
        [JsonProperty("chart")]
        public Chart Chart { get; set; }
    }

    public class LpfBillBoard
    {
        [JsonProperty("kwhName")]
        public string KwhName { get; set; }

        [JsonProperty("kwh")]
        public string Kwh { get; set; }

        [JsonProperty("kvarhName")]
        public string KvarhName { get; set; }

        [JsonProperty("kvarh")]
        public string Kvarh { get; set; }

        [JsonProperty("kwName")]
        public string KwName { get; set; }

        [JsonProperty("kw")]
        public string Kw { get; set; }

        [JsonProperty("kwDate")]
        public string KwDate { get; set; }

        [JsonProperty("kvarName")]
        public string KvarName { get; set; }

        [JsonProperty("kvar")]
        public string Kvar { get; set; }

        [JsonProperty("kvarDate")]
        public string KvarDate { get; set; }


    }

    public class Chart
    {

        //public string title1 { get; set; }
        //public string title2 { get; set; }
        //public string axisY { get; set; }
        //public string axisX { get; set; }
        //public string color { get; set; }
        //public List<Datum> data { get; set; }
        [JsonProperty("chartName")]
        public string ChartName { get; set; }
        [JsonProperty("title1")]
        public string Title1 { get; set; }

        [JsonProperty("title2")]
        public string Title2 { get; set; }

        [JsonProperty("axisY")]
        public string AxisY { get; set; }

        [JsonProperty("axisX")]
        public string AxisX { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("data")]
        public Datum[] Data { get; set; }
    }
    public class Datum
    {
        //public string lable { get; set; }
        //public int value { get; set; }
        [JsonProperty("lable")]
        public string Lable { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }


}



