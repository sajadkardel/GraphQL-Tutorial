using System;
using System.ComponentModel.DataAnnotations;

namespace GraphQL.Server_Tutorial.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}
