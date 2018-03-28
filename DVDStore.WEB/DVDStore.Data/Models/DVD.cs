﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web;
using System.Data.Entity;



namespace DVDStore.Data.Models
{
    
    public class DVD
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        public string Actor { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        [Display(Name = "Cover")]
        public byte[] PictureSmall { get; set; }
        //public byte[] Picture { get; set; }
        // Foreign Key
        public virtual Ratings RatingsID { get; set; }
        // Foreign Key
        public virtual Genres GenresID { get; set; }
        // Foreign Key
        public virtual SalesInfo SalesInfoID { get; set; }
        //Foreign Key
        public virtual List<Actor> Actors { get; set; }
    }

    
    //public class MovieDBContext : DbContext
    //{
    //    public DbSet<DVD> DVDs { get; set; }
    //}
}
