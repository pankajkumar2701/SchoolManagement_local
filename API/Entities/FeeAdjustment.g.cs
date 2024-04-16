using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a feeadjustment entity with essential details
    /// </summary>
    public class FeeAdjustment
    {
        /// <summary>
        /// TenantId of the FeeAdjustment 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the FeeAdjustment 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// AdjustmentType of the FeeAdjustment 
        /// </summary>
        public string? AdjustmentType { get; set; }
        /// <summary>
        /// Amount of the FeeAdjustment 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// Reason of the FeeAdjustment 
        /// </summary>
        public string? Reason { get; set; }

        /// <summary>
        /// CreatedOn of the FeeAdjustment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the FeeAdjustment 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the FeeAdjustment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the FeeAdjustment 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}