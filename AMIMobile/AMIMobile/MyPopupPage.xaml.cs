using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rg.Plugins.Popup.Services;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace AMIMobile
{
    public partial class MyPopupPage : Popup
    {
        ObservableCollection<DetailADS> Banner;
        public class DetailADS
        {
            public int ID { get; set; }
            public string Img { get; set; }


        }
        public MyPopupPage()
        {
            InitializeComponent();
            Banner = new ObservableCollection<DetailADS>
            {
                new DetailADS{ID=1,Img="img_loadprofile.png"},
                 new DetailADS{ID=2,Img="img_loadprofile.png"},
                  new DetailADS{ID=3,Img="img_loadprofile.png"},

            };

            Collection_ADS2.ItemsSource = Banner;

        }
        void Btn_Close2(object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }
    }
}

