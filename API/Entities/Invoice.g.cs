using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a invoice entity with essential details
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// TenantId of the Invoice 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Invoice 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// InvoiceNumber of the Invoice 
        /// </summary>
        public string? InvoiceNumber { get; set; }

        /// <summary>
        /// IssueDate of the Invoice 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// DueDate of the Invoice 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Currency to which the Invoice belongs 
        /// </summary>
        public Guid? CurrencyId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Currency
        /// </summary>
        [ForeignKey("CurrencyId")]
        public Currency? CurrencyId_Currency { get; set; }
        /// <summary>
        /// Foreign key referencing the PaymentMethod to which the Invoice belongs 
        /// </summary>
        public Guid? PaymentMethodId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PaymentMethod
        /// </summary>
        [ForeignKey("PaymentMethodId")]
        public PaymentMethod? PaymentMethodId_PaymentMethod { get; set; }

        /// <summary>
        /// CreatedOn of the Invoice 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Invoice 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Invoice 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Invoice 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}