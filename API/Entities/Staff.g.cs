using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a staff entity with essential details
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// TenantId of the Staff 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Staff 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Staff 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Designation of the Staff 
        /// </summary>
        public string? Designation { get; set; }
        /// <summary>
        /// Email of the Staff 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// PhoneNumber of the Staff 
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// CreatedOn of the Staff 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Staff 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Staff 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Staff 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}