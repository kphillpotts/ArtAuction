using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArtAuction
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        const uint AnimationSpeed = 300;

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BidPopup.OnExpandTapped += ExpandPopup;
            ArtistDetailsPopup.OnExpandTapped += ExpandArtistDetails;

        }


        private void ExpandPopup()
        {
            var height = BidPopup.Height;

            BidPopup.TranslateTo(0, this.Height - height, AnimationSpeed, Easing.SinInOut);
        }

        private void ExpandArtistDetails()
        {
            ArtistDetailsPopup.TranslateTo(0, 80, AnimationSpeed, Easing.SinInOut);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            BidPopup.OnExpandTapped -= ExpandPopup;
            ArtistDetailsPopup.OnExpandTapped -= ExpandArtistDetails;
        }


        private void BidPopupButton_Clicked(object sender, EventArgs e)
        {
            var pageHeight = Height;
            var firstSection = BidPopup.FirstSectionHeight;
            PageFader.FadeTo(1, AnimationSpeed, Easing.SinInOut);
            BidPopup.TranslateTo(0, pageHeight-firstSection, AnimationSpeed, Easing.SinInOut);
        }

        private void PageFader_Tapped(object sender, EventArgs e)
        {
            PageFader.FadeTo(0, AnimationSpeed, Easing.SinInOut);
            BidPopup.TranslateTo(0, Height, AnimationSpeed, Easing.SinInOut);
            ArtistDetailsPopup.TranslateTo(0, Height, AnimationSpeed, Easing.SinInOut);
        }

        private void Artist_Tapped(object sender, EventArgs e)
        {
            var pageHeight = Height;
            var firstSection = ArtistDetailsPopup.FirstSectionHeight;
            PageFader.FadeTo(1, AnimationSpeed, Easing.SinInOut);
            ArtistDetailsPopup.TranslateTo(0, pageHeight - firstSection, AnimationSpeed, Easing.SinInOut);
        }
    }
}
