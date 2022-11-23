

using System.Collections.Generic;
using System;

namespace AMIMobile
{
    public class LoadProfileDayItemsModel
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
        public List<Chart15ItemModel> Chart { get; set; }
        public List<TableItemModel> Table { get; set; }
    }

    public class Chart15ItemModel
    {
        public string Label { get; set; }
        public decimal Value { get; set; }
        public ColorItemModel Color { get; set; }
    }

    public class ColorItemModel
    {
        public string stroke { get; set; }
        public string fill { get; set; }
        public ColorItemModel(string colorStroke, string colorFill)
        {
            stroke = colorStroke;
            fill = colorFill;
        }
    }
}
