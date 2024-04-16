using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a feeschedule entity with essential details
    /// </summary>
    public class FeeSchedule
    {
        /// <summary>
        /// TenantId of the FeeSchedule 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the FeeSchedule 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the FeeSchedule 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// StartDate of the FeeSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the FeeSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Foreign key referencing the FeeItem to which the FeeSchedule belongs 
        /// </summary>
        public Guid? FeeItemId { get; set; }

        /// <summary>
        /// Navigation property representing the associated FeeItem
        /// </summary>
        [ForeignKey("FeeItemId")]
        public FeeItem? FeeItemId_FeeItem { get; set; }

        /// <summary>
        /// CreatedOn of the FeeSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the FeeSchedule 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the FeeSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the FeeSchedule 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}