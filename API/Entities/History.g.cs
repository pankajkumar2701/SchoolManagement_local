using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a history entity with essential details
    /// </summary>
    public class History
    {
        /// <summary>
        /// TenantId of the History 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the History 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Description of the History 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the History 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the History 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the History 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the History 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}