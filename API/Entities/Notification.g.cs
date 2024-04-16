using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a notification entity with essential details
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// TenantId of the Notification 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Notification 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Type of the Notification 
        /// </summary>
        public string? Type { get; set; }
        /// <summary>
        /// Message of the Notification 
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Foreign key referencing the Workspace to which the Notification belongs 
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Workspace
        /// </summary>
        [ForeignKey("UserId")]
        public Workspace? UserId_Workspace { get; set; }

        /// <summary>
        /// CreatedOn of the Notification 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Notification 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Notification 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Notification 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}