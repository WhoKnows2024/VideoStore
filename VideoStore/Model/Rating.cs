using System;
using System.Collections.Generic;

namespace VideoStore.Model
{
    public partial class Rating
    {
        public int RatingId { get; set; }
        public string RatingCode { get; set; } = null!;
        public string RatingDescription { get; set; } = null!;
        public string? RatingStatus { get; set; }
    }
}
