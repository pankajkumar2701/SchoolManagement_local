using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a documentversion entity with essential details
    /// </summary>
    public class DocumentVersion
    {
        /// <summary>
        /// TenantId of the DocumentVersion 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DocumentVersion 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the DocumentVersion 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// VersionNumber of the DocumentVersion 
        /// </summary>
        public string? VersionNumber { get; set; }

        /// <summary>
        /// CreatedOn of the DocumentVersion 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the DocumentVersion 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the DocumentVersion 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the DocumentVersion 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}