using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a channel entity with essential details
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// TenantId of the Channel 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Channel 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Channel 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the Channel 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Channel 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Channel 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Channel 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Channel 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}