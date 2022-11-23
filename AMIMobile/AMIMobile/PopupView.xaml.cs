using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace AMIMobile
{
    public partial class PopupView : PopupPage
    {
        ObservableCollection<DetailADS> Banner;
        public class DetailADS
        {
            public int ID { get; set; }
            public string Img { get; set; }


        }
        public PopupView()
        {
            InitializeComponent();
            Banner = new ObservableCollection<DetailADS>
            {
                new DetailADS{ID=1,Img="img_loadprofile.png"},
                 new DetailADS{ID=2,Img="img_loadprofile.png"},
                  new DetailADS{ID=3,Img="img_loadprofile.png"},

            };

            Collection_ADS.ItemsSource = Banner;

        }
        void Btn_Close(object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }


    }
}


