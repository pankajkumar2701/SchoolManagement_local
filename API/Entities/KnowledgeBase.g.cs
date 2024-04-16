using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a knowledgebase entity with essential details
    /// </summary>
    public class KnowledgeBase
    {
        /// <summary>
        /// TenantId of the KnowledgeBase 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the KnowledgeBase 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Category of the KnowledgeBase 
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// CreatedOn of the KnowledgeBase 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the KnowledgeBase 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the KnowledgeBase 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the KnowledgeBase 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}