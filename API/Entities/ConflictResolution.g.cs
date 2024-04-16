using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a conflictresolution entity with essential details
    /// </summary>
    public class ConflictResolution
    {
        /// <summary>
        /// TenantId of the ConflictResolution 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ConflictResolution 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// ResolutionType of the ConflictResolution 
        /// </summary>
        public string? ResolutionType { get; set; }
        /// <summary>
        /// ResolutionMethod of the ConflictResolution 
        /// </summary>
        public string? ResolutionMethod { get; set; }

        /// <summary>
        /// CreatedOn of the ConflictResolution 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ConflictResolution 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ConflictResolution 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ConflictResolution 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}