using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a agenda entity with essential details
    /// </summary>
    public class Agenda
    {
        /// <summary>
        /// TenantId of the Agenda 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Agenda 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Item of the Agenda 
        /// </summary>
        public string? Item { get; set; }
        /// <summary>
        /// Description of the Agenda 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// DueDate of the Agenda 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Foreign key referencing the StatusUpdate to which the Agenda belongs 
        /// </summary>
        public Guid? StatusUpdateId { get; set; }

        /// <summary>
        /// Navigation property representing the associated StatusUpdate
        /// </summary>
        [ForeignKey("StatusUpdateId")]
        public StatusUpdate? StatusUpdateId_StatusUpdate { get; set; }

        /// <summary>
        /// CreatedOn of the Agenda 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Agenda 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Agenda 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Agenda 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}