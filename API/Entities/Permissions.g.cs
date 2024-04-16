using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a permissions entity with essential details
    /// </summary>
    public class Permissions
    {
        /// <summary>
        /// TenantId of the Permissions 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Permissions 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Permissions 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the Permissions 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Permissions 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Permissions 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Permissions 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Permissions 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}