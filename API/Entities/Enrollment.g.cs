using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a enrollment entity with essential details
    /// </summary>
    public class Enrollment
    {
        /// <summary>
        /// TenantId of the Enrollment 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Enrollment 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Enrollment 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Foreign key referencing the Student to which the Enrollment belongs 
        /// </summary>
        [Required]
        public Guid StudentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Student
        /// </summary>
        [ForeignKey("StudentId")]
        public Student? StudentId_Student { get; set; }

        /// <summary>
        /// Foreign key referencing the Course to which the Enrollment belongs 
        /// </summary>
        [Required]
        public Guid CourseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Course
        /// </summary>
        [ForeignKey("CourseId")]
        public Course? CourseId_Course { get; set; }

        /// <summary>
        /// EnrollDate of the Enrollment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EnrollDate { get; set; }

        /// <summary>
        /// CreatedOn of the Enrollment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Enrollment 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Enrollment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Enrollment 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}