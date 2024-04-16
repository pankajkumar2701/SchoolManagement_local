using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a timeoff entity with essential details
    /// </summary>
    public class TimeOff
    {
        /// <summary>
        /// TenantId of the TimeOff 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the TimeOff 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// StartDate of the TimeOff 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the TimeOff 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Reason of the TimeOff 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// Foreign key referencing the TimeOffApproval to which the TimeOff belongs 
        /// </summary>
        public Guid? TimeOffApprovalId { get; set; }

        /// <summary>
        /// Navigation property representing the associated TimeOffApproval
        /// </summary>
        [ForeignKey("TimeOffApprovalId")]
        public TimeOffApproval? TimeOffApprovalId_TimeOffApproval { get; set; }

        /// <summary>
        /// CreatedOn of the TimeOff 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the TimeOff 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the TimeOff 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the TimeOff 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}