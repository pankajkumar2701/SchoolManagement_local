using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a paymentmethod entity with essential details
    /// </summary>
    public class PaymentMethod
    {
        /// <summary>
        /// TenantId of the PaymentMethod 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PaymentMethod 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the PaymentMethod 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the PaymentMethod 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the PaymentMethod 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the PaymentMethod 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the PaymentMethod 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}