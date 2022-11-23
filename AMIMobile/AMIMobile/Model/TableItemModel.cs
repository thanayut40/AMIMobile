
namespace AMIMobile
{
    public class TableItemModel
    {
        public string Label { get; set; }
        public string Text { get; set; }

        public TableItemModel(string label, string text)
        {
            Label = label;
            Text = text;
        }
    }
}
