using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciseApi.Models.Components
{
    public class Component
    {
        private DateTime _dateCreated;
        private readonly string _createdBy;
        public Component()
        {
            _createdBy = "Root";
            LastUpdatedBy = "Root";
            PopulateAuditDate();
        }
        public Component(string createdBy)
        {
            _createdBy = createdBy;
            LastUpdatedBy = createdBy;
            PopulateAuditDate();
        }
        [Required]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        [Column("DateCreated")]
        public DateTime DateCreated
        {
            get
            {
                return _dateCreated;
            }
            private set
            {

            }
        }

        [Required(AllowEmptyStrings = false)]
        [Column("CreatedBy")]
        public string CreatedBy
        {
            get
            {
                return _createdBy;
            }
            private set
            {

            }
        }
        [Required]
        public DateTime LastUpdated { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastUpdatedBy { get; set; }

        private void PopulateAuditDate()
        {
            _dateCreated = DateTime.UtcNow;
            LastUpdated = DateTime.UtcNow;
        }
    }
}

