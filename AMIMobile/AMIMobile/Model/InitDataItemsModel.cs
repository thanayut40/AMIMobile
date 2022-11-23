
using System;
using System.Collections.Generic;
namespace AMIMobile
{
    public class InitDataItemsModel
    {
        public List<CustomerItemModel> Customers { get; set; }
        public List<DdlMeterItemModel> DdlMeter { get; set; }
        public List<DdlItemModel> DdlReport { get; set; }
        public List<DdlItemModel> DdlDuration { get; set; }
        public List<AnnounceItemModel> Announces { get; set; }
    }

    public class CustomerItemModel
    {

        public string CustomerAccount { get; set; }

        public string CustomerName { get; set; }

        public string MeterNo { get; set; }

        public string PeaSite { get; set; }

        public string Tariff { get; set; }

        public string Ct { get; set; }

        public string Vt { get; set; }

        public decimal ShowLpfExport { get; set; }
    }

    public class DdlMeterItemModel
    {
        public string CustomerAccount { get; set; }
        public List<string> Meters { get; set; }
    }

    public class DdlItemModel
    {
        public string TEXT { get; set; }
        public string VALUE { get; set; }
    }

    public class AnnounceItemModel
    {
        public string ID { get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public string URL { get; set; }
        public string STARTDATE { get; set; }
        public string ENDDATE { get; set; }
    }
}
