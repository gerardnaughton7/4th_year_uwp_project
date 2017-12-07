using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GPWebApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Pub { get; set; }
        public string Name { get; set; }
        public string YourReview { get; set; }
        public int BevRating { get; set; }
        public int AtmosRating { get; set; }
        public int CraicRating { get; set; }
    }
}