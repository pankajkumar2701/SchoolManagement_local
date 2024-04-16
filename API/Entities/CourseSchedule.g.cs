using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a courseschedule entity with essential details
    /// </summary>
    public class CourseSchedule
    {
        /// <summary>
        /// TenantId of the CourseSchedule 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the CourseSchedule 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Course to which the CourseSchedule belongs 
        /// </summary>
        [Required]
        public Guid CourseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Course
        /// </summary>
        [ForeignKey("CourseId")]
        public Course? CourseId_Course { get; set; }

        /// <summary>
        /// Foreign key referencing the Room to which the CourseSchedule belongs 
        /// </summary>
        [Required]
        public Guid RoomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Room
        /// </summary>
        [ForeignKey("RoomId")]
        public Room? RoomId_Room { get; set; }

        /// <summary>
        /// Required field StartDateTime of the CourseSchedule 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Required field EndDateTime of the CourseSchedule 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// CreatedOn of the CourseSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the CourseSchedule 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the CourseSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the CourseSchedule 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}