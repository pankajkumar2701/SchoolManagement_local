using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a versioning entity with essential details
    /// </summary>
    public class Versioning
    {
        /// <summary>
        /// TenantId of the Versioning 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Versioning 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// VersionNumber of the Versioning 
        /// </summary>
        public string? VersionNumber { get; set; }

        /// <summary>
        /// ReleaseDate of the Versioning 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }
        /// <summary>
        /// Description of the Versioning 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Versioning 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Versioning 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Versioning 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Versioning 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}