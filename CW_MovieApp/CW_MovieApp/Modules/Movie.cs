using CW_MovieApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CW_MovieApp.Modules
{
    public class Movie
    {
        public int Id { get; set; }
        /*[Required(ErrorMessage = "Name of movie is required!")]*/
        public string Title { get; set; }
        /*[Required(ErrorMessage = "Longness of movie is required!")]*/
        public string TimeOfMovie { get; set; }
        public bool WithSubtitles { get; set; }
        public int Rating { get; set; }

/*[Required(ErrorMessage = "Actor of movie is required!")]*/
        public int? ActorId { get; set; }

        [ForeignKey("ActorId")]
        public Actor? Actor { get; set; }

    }
}
