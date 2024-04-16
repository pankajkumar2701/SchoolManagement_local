using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a documentcategory entity with essential details
    /// </summary>
    public class DocumentCategory
    {
        /// <summary>
        /// TenantId of the DocumentCategory 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DocumentCategory 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the DocumentCategory 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// CategoryName of the DocumentCategory 
        /// </summary>
        public string? CategoryName { get; set; }

        /// <summary>
        /// CreatedOn of the DocumentCategory 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the DocumentCategory 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the DocumentCategory 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the DocumentCategory 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}