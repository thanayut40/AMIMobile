/****************************
 * Created by : Jutarat.D
 * Created Date : 7/10/2022
 ****************************/

using System.Collections.Generic;
using System.Runtime.Serialization;


namespace AMIMobile
{
    public class LoadProfileMonthItemsModel
    {
        public string Header1 { get; set; }
        public string Header2 { get; set; }
        public string Remark { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string AxisY { get; set; }
        public string AxisX { get; set; }
        public int Precision { get; set; }
        public List<string> CustomerLabel { get; set; }
        public List<string> ChartColor { get; set; }
        public List<ChartLabel> ChartLable { get; set; }
        public List<Chart3ItemModel> ChartLine { get; set; }
        public List<Chart3ItemModel> ChartColumn { get; set; }
        public List<TableItemModel> Table { get; set; }
    }

    public class ChartLabel
    {
        public string Field { get; set; }
        public string Label { get; set; }

        public ChartLabel(string field, string label)
        {
            Field = field;
            Label = label;
        }
    }

    [DataContract]
    public class Chart3ItemModel
    {
        [DataMember]
        public string Label { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public decimal ValueA { get; set; } //=null
        [DataMember(EmitDefaultValue = false)]
        public decimal ValueB { get; set; } //=null
        [DataMember(EmitDefaultValue = false)]
        public decimal ValueC { get; set; } //=null
    }
}
