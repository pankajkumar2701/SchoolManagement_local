using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a payment entity with essential details
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// TenantId of the Payment 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Payment 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Billing to which the Payment belongs 
        /// </summary>
        public Guid? BillingId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Billing
        /// </summary>
        [ForeignKey("BillingId")]
        public Billing? BillingId_Billing { get; set; }
        /// <summary>
        /// Amount of the Payment 
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// Date of the Payment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// CreatedOn of the Payment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Payment 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Payment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Payment 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}