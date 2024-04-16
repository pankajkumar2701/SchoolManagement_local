using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a emergencycontact entity with essential details
    /// </summary>
    public class EmergencyContact
    {
        /// <summary>
        /// TenantId of the EmergencyContact 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the EmergencyContact 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// FirstName of the EmergencyContact 
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// LastName of the EmergencyContact 
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// PhoneNumber of the EmergencyContact 
        /// </summary>
        public int? PhoneNumber { get; set; }
        /// <summary>
        /// Relationship of the EmergencyContact 
        /// </summary>
        public string? Relationship { get; set; }
        /// <summary>
        /// Email of the EmergencyContact 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Foreign key referencing the Student to which the EmergencyContact belongs 
        /// </summary>
        public Guid? StudentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Student
        /// </summary>
        [ForeignKey("StudentId")]
        public Student? StudentId_Student { get; set; }

        /// <summary>
        /// CreatedOn of the EmergencyContact 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the EmergencyContact 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the EmergencyContact 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the EmergencyContact 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}