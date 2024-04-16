using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a billingfrequency entity with essential details
    /// </summary>
    public class BillingFrequency
    {
        /// <summary>
        /// TenantId of the BillingFrequency 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the BillingFrequency 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Frequency of the BillingFrequency 
        /// </summary>
        public string? Frequency { get; set; }
        /// <summary>
        /// Interval of the BillingFrequency 
        /// </summary>
        public int? Interval { get; set; }

        /// <summary>
        /// CreatedOn of the BillingFrequency 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the BillingFrequency 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the BillingFrequency 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the BillingFrequency 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}