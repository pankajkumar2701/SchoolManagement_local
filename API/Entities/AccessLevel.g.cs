using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a accesslevel entity with essential details
    /// </summary>
    public class AccessLevel
    {
        /// <summary>
        /// TenantId of the AccessLevel 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the AccessLevel 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the AccessLevel 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the AccessLevel 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the AccessLevel 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the AccessLevel 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the AccessLevel 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}