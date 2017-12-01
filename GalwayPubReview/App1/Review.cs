using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Review
    {

        public Review(string name, string yourReview)
        {
            Name = name;
            YourReview = yourReview;
        }
        public Review(string pub, string name, string yourReview, int bevRating, int atmosRating, int craicRating)
        {
            Pub = pub;
            Name = name;
            YourReview = yourReview;
            BevRating = bevRating;
            AtmosRating = atmosRating;
            CraicRating = craicRating;
        }

        private string Pub { get; set; }
        private string Name { get; set; }
        private string YourReview { get; set; }
        private int BevRating { get; set; }
        private int AtmosRating { get; set; }
        private int CraicRating { get; set; }
    }
}
