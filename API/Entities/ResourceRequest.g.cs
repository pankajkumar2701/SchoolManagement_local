using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a resourcerequest entity with essential details
    /// </summary>
    public class ResourceRequest
    {
        /// <summary>
        /// TenantId of the ResourceRequest 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ResourceRequest 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// RequesterId of the ResourceRequest 
        /// </summary>
        public Guid? RequesterId { get; set; }
        /// <summary>
        /// ResourceId of the ResourceRequest 
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// Required field StartDate of the ResourceRequest 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Required field EndDate of the ResourceRequest 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Status of the ResourceRequest 
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// CreatedOn of the ResourceRequest 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ResourceRequest 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ResourceRequest 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ResourceRequest 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}