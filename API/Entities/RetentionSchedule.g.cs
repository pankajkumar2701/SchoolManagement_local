using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a retentionschedule entity with essential details
    /// </summary>
    public class RetentionSchedule
    {
        /// <summary>
        /// TenantId of the RetentionSchedule 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the RetentionSchedule 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the RetentionSchedule 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Duration of the RetentionSchedule 
        /// </summary>
        public int? Duration { get; set; }
        /// <summary>
        /// TimeUnit of the RetentionSchedule 
        /// </summary>
        public string? TimeUnit { get; set; }

        /// <summary>
        /// CreatedOn of the RetentionSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the RetentionSchedule 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the RetentionSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the RetentionSchedule 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}