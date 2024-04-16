using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a attendance entity with essential details
    /// </summary>
    public class Attendance
    {
        /// <summary>
        /// TenantId of the Attendance 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Attendance 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Attendance 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Student to which the Attendance belongs 
        /// </summary>
        public Guid? StudentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Student
        /// </summary>
        [ForeignKey("StudentId")]
        public Student? StudentId_Student { get; set; }

        /// <summary>
        /// Date of the Attendance 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Present of the Attendance 
        /// </summary>
        public int? Present { get; set; }

        /// <summary>
        /// CreatedOn of the Attendance 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Attendance 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Attendance 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Attendance 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}