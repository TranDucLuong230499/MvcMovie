using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Lỗi Tittle")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]

        public DateTime RelaeseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "")]
        [Required(ErrorMessage ="Lỗi Genre")]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string Category { get; set; }

        public string CheckRadio { get; set; }
        [Required(ErrorMessage = "Lỗi TextArea")]
        public string TextArea { get; set; }

        [DataType(DataType.Upload)]
        public string File { get; set; }
    }
}
