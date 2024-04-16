using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a transcript entity with essential details
    /// </summary>
    public class Transcript
    {
        /// <summary>
        /// TenantId of the Transcript 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Transcript 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Student to which the Transcript belongs 
        /// </summary>
        public Guid? StudentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Student
        /// </summary>
        [ForeignKey("StudentId")]
        public Student? StudentId_Student { get; set; }
        /// <summary>
        /// Foreign key referencing the Course to which the Transcript belongs 
        /// </summary>
        public Guid? CourseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Course
        /// </summary>
        [ForeignKey("CourseId")]
        public Course? CourseId_Course { get; set; }
        /// <summary>
        /// Foreign key referencing the Grade to which the Transcript belongs 
        /// </summary>
        public Guid? GradeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Grade
        /// </summary>
        [ForeignKey("GradeId")]
        public Grade? GradeId_Grade { get; set; }

        /// <summary>
        /// CreatedOn of the Transcript 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Transcript 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Transcript 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Transcript 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}