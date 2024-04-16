using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a activityfeed entity with essential details
    /// </summary>
    public class ActivityFeed
    {
        /// <summary>
        /// TenantId of the ActivityFeed 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ActivityFeed 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Content of the ActivityFeed 
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// AuthorId of the ActivityFeed 
        /// </summary>
        public Guid? AuthorId { get; set; }

        /// <summary>
        /// CreatedOn of the ActivityFeed 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ActivityFeed 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ActivityFeed 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ActivityFeed 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}