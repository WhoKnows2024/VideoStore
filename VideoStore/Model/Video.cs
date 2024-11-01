using System;
using System.Collections.Generic;

namespace VideoStore.Model
{
    public partial class Video
    {
        public int VideoId { get; set; }
        public string Title { get; set; } = null!;
        public int GenreId { get; set; }
        public DateTime? ReleaseYear { get; set; }
        public int? Length { get; set; }
        public string? Actor { get; set; }
        public int? RatingId { get; set; }
        public int? StatusId { get; set; }
        public int? ReviewRating { get; set; }
        public string? Notes { get; set; }
    }
}
