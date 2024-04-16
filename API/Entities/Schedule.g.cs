using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a schedule entity with essential details
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// TenantId of the Schedule 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Schedule 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Course to which the Schedule belongs 
        /// </summary>
        public Guid? CourseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Course
        /// </summary>
        [ForeignKey("CourseId")]
        public Course? CourseId_Course { get; set; }

        /// <summary>
        /// StartTime of the Schedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// EndTime of the Schedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Days of the Schedule 
        /// </summary>
        public string? Days { get; set; }

        /// <summary>
        /// CreatedOn of the Schedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Schedule 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Schedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Schedule 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}