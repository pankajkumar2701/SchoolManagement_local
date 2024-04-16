using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a assignment entity with essential details
    /// </summary>
    public class Assignment
    {
        /// <summary>
        /// TenantId of the Assignment 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Assignment 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Title of the Assignment 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Foreign key referencing the Course to which the Assignment belongs 
        /// </summary>
        public Guid? CourseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Course
        /// </summary>
        [ForeignKey("CourseId")]
        public Course? CourseId_Course { get; set; }

        /// <summary>
        /// DueDate of the Assignment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Weight of the Assignment 
        /// </summary>
        public int? Weight { get; set; }

        /// <summary>
        /// CreatedOn of the Assignment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Assignment 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Assignment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Assignment 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}