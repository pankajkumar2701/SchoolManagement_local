using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a student entity with essential details
    /// </summary>
    public class Student
    {
        /// <summary>
        /// TenantId of the Student 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Student 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Student 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// DateOfBirth of the Student 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// AdmissionDate of the Student 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AdmissionDate { get; set; }

        /// <summary>
        /// CreatedOn of the Student 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Student 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Student 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Student 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}