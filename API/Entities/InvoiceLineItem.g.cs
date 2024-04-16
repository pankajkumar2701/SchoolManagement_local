using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a invoicelineitem entity with essential details
    /// </summary>
    public class InvoiceLineItem
    {
        /// <summary>
        /// TenantId of the InvoiceLineItem 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the InvoiceLineItem 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Invoice to which the InvoiceLineItem belongs 
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Invoice
        /// </summary>
        [ForeignKey("InvoiceId")]
        public Invoice? InvoiceId_Invoice { get; set; }
        /// <summary>
        /// Foreign key referencing the FeeItem to which the InvoiceLineItem belongs 
        /// </summary>
        public Guid? FeeItemId { get; set; }

        /// <summary>
        /// Navigation property representing the associated FeeItem
        /// </summary>
        [ForeignKey("FeeItemId")]
        public FeeItem? FeeItemId_FeeItem { get; set; }
        /// <summary>
        /// Quantity of the InvoiceLineItem 
        /// </summary>
        public int? Quantity { get; set; }
        /// <summary>
        /// Amount of the InvoiceLineItem 
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// CreatedOn of the InvoiceLineItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the InvoiceLineItem 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the InvoiceLineItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the InvoiceLineItem 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}