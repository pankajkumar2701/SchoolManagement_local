using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a class entity with essential details
    /// </summary>
    public class Class
    {
        /// <summary>
        /// TenantId of the Class 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Class 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Class 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Semester to which the Class belongs 
        /// </summary>
        public Guid? SemesterId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Semester
        /// </summary>
        [ForeignKey("SemesterId")]
        public Semester? SemesterId_Semester { get; set; }

        /// <summary>
        /// CreatedOn of the Class 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Class 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Class 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Class 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}