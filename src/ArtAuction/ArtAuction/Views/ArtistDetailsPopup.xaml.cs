using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ArtAuction.Views
{
    public partial class ArtistDetailsPopup : ContentView
    {
        public ArtistDetailsPopup()
        {
            InitializeComponent();
        }
        public delegate void ClickExpandDelegate();

        public ClickExpandDelegate OnExpandTapped { get; set; }

        public double FirstSectionHeight
        {
            get
            {
                return FirstSection.Height;
            }
        }

        private void FirstSection_Tapped(object sender, EventArgs e)
        {
            OnExpandTapped?.Invoke();
        }
    }
}
