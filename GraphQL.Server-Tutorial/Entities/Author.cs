using System.ComponentModel.DataAnnotations;

namespace GraphQL.Server_Tutorial.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public bool IsAlive { get; set; }
    }
}
