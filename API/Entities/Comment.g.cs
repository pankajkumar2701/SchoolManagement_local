using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a comment entity with essential details
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// TenantId of the Comment 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Comment 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Content to which the Comment belongs 
        /// </summary>
        public Guid? ContentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Content
        /// </summary>
        [ForeignKey("ContentId")]
        public Content? ContentId_Content { get; set; }
        /// <summary>
        /// Text of the Comment 
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// CreatedOn of the Comment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Comment 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Comment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Comment 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}