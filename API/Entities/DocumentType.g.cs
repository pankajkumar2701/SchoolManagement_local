using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a documenttype entity with essential details
    /// </summary>
    public class DocumentType
    {
        /// <summary>
        /// TenantId of the DocumentType 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DocumentType 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the DocumentType 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// TypeName of the DocumentType 
        /// </summary>
        public string? TypeName { get; set; }

        /// <summary>
        /// CreatedOn of the DocumentType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the DocumentType 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the DocumentType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the DocumentType 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}