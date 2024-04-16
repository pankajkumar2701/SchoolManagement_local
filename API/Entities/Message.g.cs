using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a message entity with essential details
    /// </summary>
    public class Message
    {
        /// <summary>
        /// TenantId of the Message 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Message 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Text of the Message 
        /// </summary>
        public string? Text { get; set; }
        /// <summary>
        /// Foreign key referencing the Workspace to which the Message belongs 
        /// </summary>
        public Guid? SenderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Workspace
        /// </summary>
        [ForeignKey("SenderId")]
        public Workspace? SenderId_Workspace { get; set; }
        /// <summary>
        /// Foreign key referencing the Workspace to which the Message belongs 
        /// </summary>
        public Guid? RecipientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Workspace
        /// </summary>
        [ForeignKey("RecipientId")]
        public Workspace? RecipientId_Workspace { get; set; }

        /// <summary>
        /// CreatedOn of the Message 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Message 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Message 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Message 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}