using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a content entity with essential details
    /// </summary>
    public class Content
    {
        /// <summary>
        /// TenantId of the Content 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Content 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Title of the Content 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Description of the Content 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Foreign key referencing the KnowledgeBase to which the Content belongs 
        /// </summary>
        public Guid? KnowledgeBaseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated KnowledgeBase
        /// </summary>
        [ForeignKey("KnowledgeBaseId")]
        public KnowledgeBase? KnowledgeBaseId_KnowledgeBase { get; set; }

        /// <summary>
        /// CreatedOn of the Content 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Content 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Content 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Content 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}