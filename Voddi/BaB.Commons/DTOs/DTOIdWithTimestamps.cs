using System;
using System.ComponentModel.DataAnnotations;

namespace GPAG.Commons.DTOs
{

    public abstract class DTOIdWithTimestamps<T> : DTOId<T>
    {
        [Required]
        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [MaxLength(80)]
        [Display(Name ="Created by")]
        public string CreatedBy { get; set; }

        [Required]
        [Display(Name = "Modified at")]
        public DateTime ModifiedAt { get; set; }

        [Required]
        [MaxLength(80)]
        [Display(Name = "Modified by")]
        public string ModifiedBy { get; set; }

        public DTOIdWithTimestamps()
        {
        }

        public DTOIdWithTimestamps(string createdBy, DateTime createdAt, string modifiedBy, DateTime modifiedAt)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.ModifiedAt = modifiedAt;
            this.ModifiedBy = modifiedBy;
        }
    }
}