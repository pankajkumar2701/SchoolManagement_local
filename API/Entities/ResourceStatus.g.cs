using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a resourcestatus entity with essential details
    /// </summary>
    public class ResourceStatus
    {
        /// <summary>
        /// TenantId of the ResourceStatus 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ResourceStatus 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Status of the ResourceStatus 
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// CreatedOn of the ResourceStatus 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ResourceStatus 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ResourceStatus 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ResourceStatus 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}