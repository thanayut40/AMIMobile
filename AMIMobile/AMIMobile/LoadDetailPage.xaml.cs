using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AMIMobile.Model;
using Xamarin.Forms;

namespace AMIMobile
{
    public partial class LoadDetailPage : ContentPage
    {
        //ObservableCollection<DetailLoadProfile> LoadProfile;
        ////ObservableCollection<Datatabel> datatabel;
        //public class DetailLoadProfile
        //{
        //    public int ID { get; set; }
        //    //public string Img { get; set; }


        //}
        public LoadDetailPage()
        {
            InitializeComponent();
            //LoadProfile = new ObservableCollection<DetailLoadProfile>
            //{
            //    new DetailLoadProfile{ID=1 },
            //     new DetailLoadProfile{ID=2},
            //      new DetailLoadProfile{ID=3},

            //};

            //Collection_LoadProfile.ItemsSource = LoadProfile;
            List<Datatabel> datatabel = new List<Datatabel>()
            {
                new Datatabel{ Date = "01/10/2022 10.00", MaxdateA = "01/10/2022 10.00", MaxvalueA = "28.000",MaxdateB = "01/10/2022 10.00", MaxvalueB = "28.000",MaxdateC = "01/10/2022 10.00", MaxvalueC = "28.000",Maxpower1="01/10/2022 10.00",Maxpower2="28.000"},
                new Datatabel{ Date = "30/9/2022 23.00", MaxdateA = "30/9/2022 23.00", MaxvalueA = "24.800",MaxdateB = "01/10/2022 10.00", MaxvalueB = "28.000",MaxdateC = "01/10/2022 10.00", MaxvalueC = "28.000",Maxpower1="01/10/2022 10.00",Maxpower2="28.000" },
                new Datatabel{Date = "30/09/2022 22.48", MaxdateA = "30/09/2022 22.48", MaxvalueA = "63.680", MaxdateB = "01/10/2022 10.00", MaxvalueB = "28.000",MaxdateC = "01/10/2022 10.00", MaxvalueC = "28.000",Maxpower1="01/10/2022 10.00",Maxpower2="28.000"},
                new Datatabel{ Date = "30/09/2022 22.32", MaxdateA = "30/09/2022 22.32", MaxvalueA = "82.880",MaxdateB = "01/10/2022 10.00", MaxvalueB = "28.000",MaxdateC = "01/10/2022 10.00", MaxvalueC = "28.000",Maxpower1="01/10/2022 10.00",Maxpower2="28.000"},

            };
            Collection_LoadProfile.ItemsSource = datatabel;

        }


    }
}

