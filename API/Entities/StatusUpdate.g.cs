using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a statusupdate entity with essential details
    /// </summary>
    public class StatusUpdate
    {
        /// <summary>
        /// TenantId of the StatusUpdate 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the StatusUpdate 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Comment of the StatusUpdate 
        /// </summary>
        public string? Comment { get; set; }
        /// <summary>
        /// AuthorId of the StatusUpdate 
        /// </summary>
        public Guid? AuthorId { get; set; }

        /// <summary>
        /// CreatedOn of the StatusUpdate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the StatusUpdate 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the StatusUpdate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the StatusUpdate 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}