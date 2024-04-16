using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a documenttemplate entity with essential details
    /// </summary>
    public class DocumentTemplate
    {
        /// <summary>
        /// TenantId of the DocumentTemplate 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DocumentTemplate 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the DocumentTemplate 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Content of the DocumentTemplate 
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// CreatedOn of the DocumentTemplate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the DocumentTemplate 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the DocumentTemplate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the DocumentTemplate 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}