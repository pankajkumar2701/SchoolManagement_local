using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a faculty entity with essential details
    /// </summary>
    public class Faculty
    {
        /// <summary>
        /// TenantId of the Faculty 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Faculty 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Faculty 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Email of the Faculty 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// PhoneNumber of the Faculty 
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// CreatedOn of the Faculty 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Faculty 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Faculty 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Faculty 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}