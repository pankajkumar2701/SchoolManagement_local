using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a email entity with essential details
    /// </summary>
    public class Email
    {
        /// <summary>
        /// TenantId of the Email 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Email 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Subject of the Email 
        /// </summary>
        public string? Subject { get; set; }
        /// <summary>
        /// Body of the Email 
        /// </summary>
        public string? Body { get; set; }
        /// <summary>
        /// SenderId of the Email 
        /// </summary>
        public Guid? SenderId { get; set; }
        /// <summary>
        /// RecipientId of the Email 
        /// </summary>
        public Guid? RecipientId { get; set; }

        /// <summary>
        /// CreatedOn of the Email 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Email 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Email 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Email 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}