using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a contactinformation entity with essential details
    /// </summary>
    public class ContactInformation
    {
        /// <summary>
        /// TenantId of the ContactInformation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ContactInformation 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the ContactInformation 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// PhoneNumber of the ContactInformation 
        /// </summary>
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// Email of the ContactInformation 
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// CreatedOn of the ContactInformation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ContactInformation 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ContactInformation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ContactInformation 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}