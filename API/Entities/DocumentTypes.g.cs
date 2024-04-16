using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a documenttypes entity with essential details
    /// </summary>
    public class DocumentTypes
    {
        /// <summary>
        /// TenantId of the DocumentTypes 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DocumentTypes 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TypeName of the DocumentTypes 
        /// </summary>
        public string? TypeName { get; set; }

        /// <summary>
        /// CreatedOn of the DocumentTypes 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the DocumentTypes 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the DocumentTypes 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the DocumentTypes 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}