using System;
using System.Collections.Generic;

namespace VideoStore.Model
{
    public partial class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; } = null!;
        public string GenreDescription { get; set; } = null!;
        public string GenreaStatus { get; set; } = null!;
    }
}
