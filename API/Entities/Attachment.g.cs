using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a attachment entity with essential details
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// TenantId of the Attachment 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Attachment 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// FileName of the Attachment 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FileSize of the Attachment 
        /// </summary>
        public int? FileSize { get; set; }
        /// <summary>
        /// ContentType of the Attachment 
        /// </summary>
        public string? ContentType { get; set; }
        /// <summary>
        /// Foreign key referencing the Content to which the Attachment belongs 
        /// </summary>
        public Guid? ContentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Content
        /// </summary>
        [ForeignKey("ContentId")]
        public Content? ContentId_Content { get; set; }

        /// <summary>
        /// CreatedOn of the Attachment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Attachment 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Attachment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Attachment 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}