using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a billingcycle entity with essential details
    /// </summary>
    public class BillingCycle
    {
        /// <summary>
        /// TenantId of the BillingCycle 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the BillingCycle 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// CycleName of the BillingCycle 
        /// </summary>
        public string? CycleName { get; set; }

        /// <summary>
        /// StartDate of the BillingCycle 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the BillingCycle 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// CreatedOn of the BillingCycle 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the BillingCycle 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the BillingCycle 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the BillingCycle 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}