using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciseApi.Models.Components
{
    public class Component
    {
        [Required]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string? LastUpdatedBy { get; set; }
    }
}

