﻿using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("rating")]
        public string Rating { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("runtime_mins")]
        public int RuntimeMins { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        //DTO
        public class MovieResponseDTO
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public int Runtime {  get; set; }

            public MovieResponseDTO(Movie movie)
            {
                ID = movie.Id;
                Title = movie.Title;
                Runtime = movie.RuntimeMins;
                
            }
        }
    }
}
