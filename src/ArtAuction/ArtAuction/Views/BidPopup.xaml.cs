using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtAuction.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BidPopup : ContentView
	{

        public delegate void ClickExpandDelegate();

        public ClickExpandDelegate OnExpandTapped { get; set; }

		public BidPopup ()
		{
			InitializeComponent ();
		}

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