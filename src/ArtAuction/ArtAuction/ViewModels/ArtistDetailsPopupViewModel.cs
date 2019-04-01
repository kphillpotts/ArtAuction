using System;
using System.Collections.ObjectModel;
using ArtAuction.Models;

namespace ArtAuction.ViewModels
{
    public class ArtistDetailsPopupViewModel
    {
        public ObservableCollection<ArtWork> ArtWorks { get; set; } = new ObservableCollection<ArtWork>
        {
            new ArtWork{ ImagePath = "peachtree.jpg" , Name = "Peach Tree in Blossom", Price = 950000, Height = 300},
            new ArtWork{ ImagePath = "redvineyard.jpg" , Name = "The Red Vineyard", Price = 425000, Height = 200},
            new ArtWork{ ImagePath = "fields.jpg", Name = "Awesome Fields", Price = 621000, Height = 200},
            new ArtWork{ ImagePath = "cafeterrace.jpeg", Name = "Cafe Terrace at Night", Price = 1920000, Height = 200},
            new ArtWork{ ImagePath = "cypresses.jpg", Name = "Cypresses", Price = 172000, Height = 300},
            new ArtWork{ ImagePath = "willow.jpg", Name = "Great Landscape", Price = 50000, Height = 200},
        };
    }
}