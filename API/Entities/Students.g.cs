using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a students entity with essential details
    /// </summary>
    public class Students
    {
        /// <summary>
        /// TenantId of the Students 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Students 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Students 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// DateOfBirth of the Students 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// AdmissionDate of the Students 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AdmissionDate { get; set; }

        /// <summary>
        /// CreatedOn of the Students 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Students 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Students 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Students 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}