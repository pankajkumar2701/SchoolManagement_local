using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a timeoffapproval entity with essential details
    /// </summary>
    public class TimeOffApproval
    {
        /// <summary>
        /// TenantId of the TimeOffApproval 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the TimeOffApproval 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// ApproverId of the TimeOffApproval 
        /// </summary>
        public Guid? ApproverId { get; set; }
        /// <summary>
        /// Foreign key referencing the TimeOff to which the TimeOffApproval belongs 
        /// </summary>
        public Guid? TimeOffId { get; set; }

        /// <summary>
        /// Navigation property representing the associated TimeOff
        /// </summary>
        [ForeignKey("TimeOffId")]
        public TimeOff? TimeOffId_TimeOff { get; set; }
        /// <summary>
        /// Status of the TimeOffApproval 
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// CreatedOn of the TimeOffApproval 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the TimeOffApproval 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the TimeOffApproval 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the TimeOffApproval 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}