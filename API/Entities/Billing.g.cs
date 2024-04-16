using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a billing entity with essential details
    /// </summary>
    public class Billing
    {
        /// <summary>
        /// TenantId of the Billing 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Billing 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the Billing 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Amount of the Billing 
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// DueDate of the Billing 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Discount to which the Billing belongs 
        /// </summary>
        public Guid? DiscountId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Discount
        /// </summary>
        [ForeignKey("DiscountId")]
        public Discount? DiscountId_Discount { get; set; }

        /// <summary>
        /// CreatedOn of the Billing 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Billing 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Billing 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Billing 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}