using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMyVersion.Models;
using System.ComponentModel.DataAnnotations;

namespace VidlyMyVersion.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        //[Required(ErrorMessage ="The Genre field is required.")]
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number In Stock")]
        public int? NumberInStock { get; set; }

        public NewMovieViewModel()
        {
            Id = 0;
        }
        public NewMovieViewModel(Movie movie)
        {
                Id = movie.Id;
                Name = movie.Name;
                ReleaseDate = movie.ReleaseDate;
                NumberInStock = movie.NumberInStock;
                GenreId = movie.GenreId;
        }
    }
}