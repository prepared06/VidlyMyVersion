﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMyVersion.Models.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        //[Required(ErrorMessage ="The Genre field is required.")]
        public int GenreId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}