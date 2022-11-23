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
using Rg.Plugins.Popup.Services;


namespace AMIMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardPage : ContentPage

    {
        //private double width;
        //private double height;
        //public ObservableCollection<DashboardItemsModel> DashData { get; set; } = new ObservableCollection<DashboardItemsModel>();
        public DashBoardPage()
        {
            InitializeComponent();
            GetAdvertise();
            //PostData();
            BindingContext = this;
            BindingContext = new DashboardItemsModel();
            GetData();
            //Tabel();
            //List<LpfBillBoard> billingboard = new List<LpfBillBoard>()
            //{
            //    new LpfBillBoard(){lpfDate="วันที่ 21/07/2565 00.15 - 15/08/2565 16.00",KwhName="ค่ากิโลวัตต์ชั่วโมง",Kwh="8,644.93",KvarhName = "ค่ากิโลวาร์ชั่วโมง",Kvarh = "4,723.72",KwName = "ค่ากิโลวัตต์สูงสุด Rate A", Kw = "77.681",KwDate="27/07/2565 14.45", KvarName="ค่ากิโลวาร์สูงสุด", Kvar="60.000", KvarDate="01/08/2565 11.00" },
            //    new LpfBillBoard(){lpfDate="วันที่ 21/07/2565 00.15 - 15/08/2565 16.00",KwhName="ค่ากิโลวัตต์ชั่วโมง",Kwh="8,644.93",KvarhName = "ค่ากิโลวาร์ชั่วโมง",Kvarh = "4,723.72",KwName = "ค่ากิโลวัตต์สูงสุด Rate A", Kw = "77.681",KwDate="27/07/2565 14.45", KvarName="ค่ากิโลวาร์สูงสุด", Kvar="60.000", KvarDate="01/08/2565 11.00" },
            //    new LpfBillBoard(){lpfDate="วันที่ 21/07/2565 00.15 - 15/08/2565 16.00",KwhName="ค่ากิโลวัตต์ชั่วโมง",Kwh="8,644.93",KvarhName = "ค่ากิโลวาร์ชั่วโมง",Kvarh = "4,723.72",KwName = "ค่ากิโลวัตต์สูงสุด Rate A", Kw = "77.681",KwDate="27/07/2565 14.45", KvarName="ค่ากิโลวาร์สูงสุด", Kvar="60.000", KvarDate="01/08/2565 11.00" },

            //};

            //Collection_BillingMonth.ItemsSource = billingboard;
        }
        //void Button_Clicked222(object sender, EventArgs e)
        //{
        //    GetData();

        //}

        private async void GetData()
        {

            DashboardItemsModel dashdata = new DashboardItemsModel()
            {

                customerAccount = "020016624836",
                meterNo = "6540000112",
                report = "",
                duration = "",
                date = "",
                showLpfExport = "",
                language = "th",

            };
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            Uri RequestUri = new Uri("https://43.249.113.168/cep.api/Customer/Dashboard");
            var json = JsonConvert.SerializeObject(dashdata);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient(handler);
            var response = await client.PostAsync(RequestUri, contentJson);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                //Console.WriteLine("Checkkkkkk");
                //Console.WriteLine(response.StatusCode);
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<DashboardItemsModel>>(content);

                Console.WriteLine("ข้อมูลล" + result.GetType());
                //var result = JsonConvert.DeserializeObject<List<DashboardItemsModel>>(content);


                //await Navigation.PushAsync(new TabPage());
                //Listlogin.ItemsSource = result;
                Collection_BillingMonth.ItemsSource = (IEnumerable)result;

            }
            else
            {
                await DisplayAlert("แจ้งเตือน", "ลงชื่อเข้าใช้ผิดพลาด", "ปิด");
            }

        }





        //protected override void OnSizeAllocated(double width, double height)
        //{
        //    base.OnSizeAllocated(width, height);
        //    if (width != this.width || height != this.height)
        //    {
        //        this.width = width;
        //        this.height = height;
        //        if (width > height)
        //        {
        //            control.Orientation = StackOrientation.Horizontal;
        //        }
        //        else
        //        {
        //            control.Orientation = StackOrientation.Vertical;
        //        }
        //    }
        //}
        //protected override void OnSizeAllocated(double width, double height)
        //{
        //    base.OnSizeAllocated(width, height);
        //    if (width != this.width || height != this.height)
        //    {
        //        this.width = width;
        //        this.height = height;
        //        if (width > height)
        //        {
        //            innerGrid.RowDefinitions.Clear();
        //            innerGrid.ColumnDefinitions.Clear();
        //            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        //            innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //            innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //            innerGrid.Children.Remove(controlsGrid);
        //            innerGrid.Children.Add(controlsGrid, 1, 0);
        //        }
        //        else
        //        {
        //            innerGrid.RowDefinitions.Clear();
        //            innerGrid.ColumnDefinitions.Clear();
        //            innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
        //            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        //            innerGrid.Children.Remove(controlsGrid);
        //            innerGrid.Children.Add(controlsGrid, 0, 1);
        //        }
        //    }
        //}
        //async void RefreshView_Refreshing(System.Object sender, System.EventArgs e)
        //{
        //    await Task.Delay(2000);
        //    myRefreshView.IsRefreshing = false;
        //}
        //async void Tabel()
        //{
        //    var browser = new Xamarin.Forms.WebView();
        //    var htmlSource = new HtmlWebViewSource();
        //    StringBuilder htmlStr = new StringBuilder("");
        //    htmlStr.Append("<style>\n#chartdiv {\n  width: 100%;\n  height: 500px;\n}\n</style>\n\n<!-- Resources -->\n<script src=\"https://cdn.amcharts.com/lib/5/index.js\"></script>\n<script src=\"https://cdn.amcharts.com/lib/5/xy.js\"></script>\n<script src=\"https://cdn.amcharts.com/lib/5/themes/Animated.js\"></script>\n\n<!-- Chart code -->\n<script>\nam5.ready(function() {\n\n// Create root element\n// https://www.amcharts.com/docs/v5/getting-started/#Root_element\nvar root = am5.Root.new(\"chartdiv\");\n\n// Set themes\n// https://www.amcharts.com/docs/v5/concepts/themes/\nroot.setThemes([\n  am5themes_Animated.new(root)\n]);\n\n// Create chart\n// https://www.amcharts.com/docs/v5/charts/xy-chart/\nvar chart = root.container.children.push(am5xy.XYChart.new(root, {\n  panX: true,\n  panY: true,\n  wheelX: \"panX\",\n  wheelY: \"zoomX\",\n  pinchZoomX:true\n}));\n\n// Create axes\n// https://www.amcharts.com/docs/v5/charts/xy-chart/axes/\nvar xRenderer = am5xy.AxisRendererX.new(root, {});\nxRenderer.grid.template.set(\"forceHidden\", true);\nxRenderer.labels.template.setAll({multiLocation: 0, location:0});\n\nvar xAxis = chart.xAxes.push(am5xy.DateAxis.new(root, {\n  baseInterval: { timeUnit: \"minute\", count: 30 },\n  renderer: xRenderer,\n  tooltip: am5.Tooltip.new(root, {}),\n  extraMin: 0.01,\n  extraMax: 0.01,\n  tooltipLocation: 0\n}));\n\nvar yRenderer = am5xy.AxisRendererY.new(root, {});\nyRenderer.grid.template.set(\"forceHidden\", true);\n\nvar yAxis = chart.yAxes.push(am5xy.ValueAxis.new(root, {\n  renderer: yRenderer\n}));\n\n// Add cursor\n// https://www.amcharts.com/docs/v5/charts/xy-chart/cursor/\nvar cursor = chart.set(\"cursor\", am5xy.XYCursor.new(root, {\n  behavior: \"none\",\n  xAxis: xAxis\n}));\ncursor.lineY.set(\"visible\", false);\n\n// Add series\n// https://www.amcharts.com/docs/v5/charts/xy-chart/series/\nvar series = chart.series.push(am5xy.LineSeries.new(root, {\n  name: \"Series\",\n  xAxis: xAxis,\n  yAxis: yAxis,\n  valueYField: \"value\",\n  valueXField: \"timestamp\",\n  locationX: 0,\n  seriesTooltipTarget: \"bullet\",\n  tooltip: am5.Tooltip.new(root, {\n    labelText: \"{valueY}\"\n  })\n}));\n\nseries.bullets.push(function() {\n  var circleTemplate = am5.Template.new({\n    radius: 6,\n    templateField: \"bulletSettings\",\n    fill: series.get(\"fill\"),\n    strokeWidth: 2,\n    stroke: root.interfaceColors.get(\"background\")\n  })\n\n  var circle = am5.Circle.new(root, {}, circleTemplate);\n\n  return am5.Bullet.new(root, {\n    sprite: circle,\n    locationX: 0\n  });\n});\n\nfunction createGuide(value, text, dashArray) {\n  var guideDataItem = yAxis.makeDataItem({ value: value });\n  yAxis.createAxisRange(guideDataItem);\n  guideDataItem.get(\"grid\").setAll({\n    forceHidden: false,\n    strokeOpacity: 0.2,\n    strokeDasharray: dashArray\n  });\n\n  var label = guideDataItem.get(\"label\");\n  label.setAll({\n    text: text,\n    isMeasured: false,\n    centerY: am5.p100\n  });\n\n  label.adapters.add(\"x\", function(x) {\n    return chart.plotContainer.width();\n  })\n  \n  chart.events.on(\"boundschanged\", function(){\n    label.set(\"x\", label.get(\"x\"))\n  })  \n}\n\n\ncreateGuide(98.8, \"LCL\", [2, 2]);\ncreateGuide(100.1, \"CL\");\ncreateGuide(101.2, \"UCL\", [2, 2]);\n\n\nvar data = [{\n  \"timestamp\": new Date(2020, 0, 1, 22, 30).getTime(),\n  \"value\": 99.71\n}, {\n  \"timestamp\": new Date(2020, 0, 1, 23, 0).getTime(),\n  \"value\": 99.13\n}, {\n  \"timestamp\": new Date(2020, 0, 1, 23, 30).getTime(),\n  \"value\": 98.5\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 0, 0).getTime(),\n  \"value\": 101\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 0, 30).getTime(),\n  \"value\": 99.45\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 1, 0).getTime(),\n  \"value\": 100.9\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 1, 30).getTime(),\n  \"value\": 100.39\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 2, 0).getTime(),\n  \"value\": 101.1\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 2, 30).getTime(),\n  \"value\": 101.45\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 3, 0).getTime(),\n  \"value\": 101.15\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 3, 30).getTime(),\n  \"value\": 100.5\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 4, 0).getTime(),\n  \"value\": 101.55,\n  \"bulletSettings\": { fill: am5.color(\"#f0c803\") }\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 4, 30).getTime(),\n  \"value\": 101.7,\n  \"bulletSettings\": { fill: am5.color(\"#970505\") }\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 5, 0).getTime(),\n  \"value\": 100.5,\n  \"bulletSettings\": { fill: am5.color(\"#f0c803\") }\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 5, 30).getTime(),\n  \"value\": 100.92,\n  \"bulletSettings\": { fill: am5.color(\"#f0c803\") }\n}, {\n  \"timestamp\": new Date(2020, 0, 2, 6, 0).getTime(),\n  \"value\": 102.2,\n  \"bulletSettings\": { fill: am5.color(\"#970505\") }\n}];\n\nseries.data.setAll(data);\n\n// Make stuff animate on load\n// https://www.amcharts.com/docs/v5/concepts/animations/\nseries.appear(1000);\nchart.appear(1000, 100);\n\n}); // end am5.ready()\n</script>\n\n<!-- HTML -->\n<div id=\"chartdiv\"></div>\n");

        //    htmlSource.Html = htmlStr.ToString();
        //    browser.Source = htmlSource;
        //    Content = browser;
        //}
        //protected override void OnSizeAllocated(double width, double height)
        //{
        //    base.OnSizeAllocated(width, height);
        //    if (width != this.width || height != this.height)
        //    {
        //        this.width = width;
        //        this.height = height;
        //        if (width > height)
        //        {
        //            outerStack.Orientation = StackOrientation.Horizontal;
        //        }
        //        else
        //        {
        //            outerStack.Orientation = StackOrientation.Vertical;
        //        }
        //    }
        //}
        private async void Btn_Refresh(object sender, EventArgs e)
        {
            var content = (ImageButton)sender;
            //  await content.RotateTo(360, 1000);
            var boolen = true;
            while (boolen)
            {
                for (int i = 1; i < 5; i++)
                {
                    //if (content.Rotation > 360f) content.Rotation = 0;
                    //double rotation = i * (360 / 9);
                    await content.RotateTo(i * (180 / 2), 1000);
                    //await content.RotateTo(360, 1000, Easing.Linear);

                    boolen = false;

                    //await content.RotateTo(360, 1000);
                }
            }
            return;
        }

        async void GetAdvertise()
        {

            await PopupNavigation.Instance.PushAsync(new PopupView());
            //Navigation.ShowPopup(new MyPopupPage());

        }


    }
}

