using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a document entity with essential details
    /// </summary>
    public class Document
    {
        /// <summary>
        /// TenantId of the Document 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Document 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the Document 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Title of the Document 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Foreign key referencing the DocumentType to which the Document belongs 
        /// </summary>
        public Guid? DocumentTypeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated DocumentType
        /// </summary>
        [ForeignKey("DocumentTypeId")]
        public DocumentType? DocumentTypeId_DocumentType { get; set; }
        /// <summary>
        /// Foreign key referencing the DocumentCategory to which the Document belongs 
        /// </summary>
        public Guid? DocumentCategoryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated DocumentCategory
        /// </summary>
        [ForeignKey("DocumentCategoryId")]
        public DocumentCategory? DocumentCategoryId_DocumentCategory { get; set; }
        /// <summary>
        /// Foreign key referencing the DocumentStatus to which the Document belongs 
        /// </summary>
        public Guid? DocumentStatusId { get; set; }

        /// <summary>
        /// Navigation property representing the associated DocumentStatus
        /// </summary>
        [ForeignKey("DocumentStatusId")]
        public DocumentStatus? DocumentStatusId_DocumentStatus { get; set; }
        /// <summary>
        /// Foreign key referencing the DocumentVersion to which the Document belongs 
        /// </summary>
        public Guid? DocumentVersionId { get; set; }

        /// <summary>
        /// Navigation property representing the associated DocumentVersion
        /// </summary>
        [ForeignKey("DocumentVersionId")]
        public DocumentVersion? DocumentVersionId_DocumentVersion { get; set; }

        /// <summary>
        /// CreatedOn of the Document 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Document 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Document 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Document 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}