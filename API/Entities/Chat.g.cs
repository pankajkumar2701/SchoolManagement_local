using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a chat entity with essential details
    /// </summary>
    public class Chat
    {
        /// <summary>
        /// TenantId of the Chat 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Chat 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Message of the Chat 
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// SenderId of the Chat 
        /// </summary>
        public Guid? SenderId { get; set; }
        /// <summary>
        /// RecipientId of the Chat 
        /// </summary>
        public Guid? RecipientId { get; set; }

        /// <summary>
        /// CreatedOn of the Chat 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Chat 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Chat 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Chat 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}