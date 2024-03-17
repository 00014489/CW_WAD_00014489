using CW_MovieApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace CW_MovieApp.Modules
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TimeOfMovie { get; set; }
        public bool WithSubtitles { get; set; }
        public int Rating { get; set; }

    }
}
