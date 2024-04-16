using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a resource entity with essential details
    /// </summary>
    public class Resource
    {
        /// <summary>
        /// TenantId of the Resource 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Resource 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the ResourceType to which the Resource belongs 
        /// </summary>
        public Guid? ResourceType { get; set; }

        /// <summary>
        /// Navigation property representing the associated ResourceType
        /// </summary>
        [ForeignKey("ResourceType")]
        public ResourceType? ResourceType_ResourceType { get; set; }
        /// <summary>
        /// Description of the Resource 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Resource 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Resource 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Resource 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Resource 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}