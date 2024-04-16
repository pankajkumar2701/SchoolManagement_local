using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a workannouncement entity with essential details
    /// </summary>
    public class WorkAnnouncement
    {
        /// <summary>
        /// TenantId of the WorkAnnouncement 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the WorkAnnouncement 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Title of the WorkAnnouncement 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Description of the WorkAnnouncement 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// StartDate of the WorkAnnouncement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the WorkAnnouncement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Teacher to which the WorkAnnouncement belongs 
        /// </summary>
        public Guid? TeacherId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Teacher
        /// </summary>
        [ForeignKey("TeacherId")]
        public Teacher? TeacherId_Teacher { get; set; }
        /// <summary>
        /// Foreign key referencing the Course to which the WorkAnnouncement belongs 
        /// </summary>
        public Guid? CourseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Course
        /// </summary>
        [ForeignKey("CourseId")]
        public Course? CourseId_Course { get; set; }

        /// <summary>
        /// CreatedOn of the WorkAnnouncement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the WorkAnnouncement 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the WorkAnnouncement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the WorkAnnouncement 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}