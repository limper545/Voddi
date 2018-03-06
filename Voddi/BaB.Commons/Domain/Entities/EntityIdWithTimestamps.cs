using System;
using System.ComponentModel.DataAnnotations;

namespace GPAG.Commons.Domain.Entities
{

    public abstract class EntityIdWithTimestamps<T> : EntityId<T>
    {
        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [MaxLength(80)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime ModifiedAt { get; set; }

        [Required]
        [MaxLength(80)]
        public string ModifiedBy { get; set; }

        public EntityIdWithTimestamps()
        {
        }

        public EntityIdWithTimestamps(string createdBy, DateTime createdAt, string modifiedBy, DateTime modifiedAt)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.ModifiedAt = modifiedAt;
            this.ModifiedBy = modifiedBy;
        }
    }
}