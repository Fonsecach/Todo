using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Todo.Models
{
    public class Tasks
    {
        [Key]
        public Guid Id { get; set;}
        [ForeignKey("UserId")][Required]
        public Guid UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; }
        [Required][MinLength(3)][MaxLength(25)]
        public string Title { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastModifiedAt { get;} = DateTime.Now;
        public string Status { get; set; } = "Pendente";

        public Tasks()
    {
        Id = Guid.NewGuid();
    }
    }
}