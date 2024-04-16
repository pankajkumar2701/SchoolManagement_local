using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a documentstatus entity with essential details
    /// </summary>
    public class DocumentStatus
    {
        /// <summary>
        /// TenantId of the DocumentStatus 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DocumentStatus 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the DocumentStatus 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// StatusName of the DocumentStatus 
        /// </summary>
        public string? StatusName { get; set; }

        /// <summary>
        /// CreatedOn of the DocumentStatus 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the DocumentStatus 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the DocumentStatus 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the DocumentStatus 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}