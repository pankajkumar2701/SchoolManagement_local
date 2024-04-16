using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a timelog entity with essential details
    /// </summary>
    public class TimeLog
    {
        /// <summary>
        /// TenantId of the TimeLog 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the TimeLog 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the WorkSchedule to which the TimeLog belongs 
        /// </summary>
        public Guid? WorkScheduleId { get; set; }

        /// <summary>
        /// Navigation property representing the associated WorkSchedule
        /// </summary>
        [ForeignKey("WorkScheduleId")]
        public WorkSchedule? WorkScheduleId_WorkSchedule { get; set; }

        /// <summary>
        /// StartTime of the TimeLog 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// EndTime of the TimeLog 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// CreatedOn of the TimeLog 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the TimeLog 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the TimeLog 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the TimeLog 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}