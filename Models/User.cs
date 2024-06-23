using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required][MinLength(3)][MaxLength(25)]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastModifiedAt { get;} = DateTime.Now;

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
