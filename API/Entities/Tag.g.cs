using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a tag entity with essential details
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// TenantId of the Tag 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Tag 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Tag 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the Tag 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Tag 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Tag 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Tag 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Tag 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}