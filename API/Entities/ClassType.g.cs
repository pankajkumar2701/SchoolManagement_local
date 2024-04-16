using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a classtype entity with essential details
    /// </summary>
    public class ClassType
    {
        /// <summary>
        /// TenantId of the ClassType 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ClassType 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TypeName of the ClassType 
        /// </summary>
        public string? TypeName { get; set; }
        /// <summary>
        /// Description of the ClassType 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the ClassType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ClassType 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ClassType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ClassType 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}