using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a feeitem entity with essential details
    /// </summary>
    public class FeeItem
    {
        /// <summary>
        /// TenantId of the FeeItem 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the FeeItem 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the FeeCategory to which the FeeItem belongs 
        /// </summary>
        public Guid? FeeCategoryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated FeeCategory
        /// </summary>
        [ForeignKey("FeeCategoryId")]
        public FeeCategory? FeeCategoryId_FeeCategory { get; set; }
        /// <summary>
        /// Name of the FeeItem 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Amount of the FeeItem 
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// CreatedOn of the FeeItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the FeeItem 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the FeeItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the FeeItem 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}