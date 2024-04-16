using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a archivelocation entity with essential details
    /// </summary>
    public class ArchiveLocation
    {
        /// <summary>
        /// TenantId of the ArchiveLocation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ArchiveLocation 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the ArchiveLocation 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Address of the ArchiveLocation 
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// CreatedOn of the ArchiveLocation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ArchiveLocation 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ArchiveLocation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ArchiveLocation 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}