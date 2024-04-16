using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a resourcetype entity with essential details
    /// </summary>
    public class ResourceType
    {
        /// <summary>
        /// TenantId of the ResourceType 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ResourceType 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// ResourceTypeName of the ResourceType 
        /// </summary>
        public string? ResourceTypeName { get; set; }

        /// <summary>
        /// CreatedOn of the ResourceType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ResourceType 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ResourceType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ResourceType 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}