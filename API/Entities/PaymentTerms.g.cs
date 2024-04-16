using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a paymentterms entity with essential details
    /// </summary>
    public class PaymentTerms
    {
        /// <summary>
        /// TenantId of the PaymentTerms 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PaymentTerms 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TermName of the PaymentTerms 
        /// </summary>
        public string? TermName { get; set; }
        /// <summary>
        /// Days of the PaymentTerms 
        /// </summary>
        public int? Days { get; set; }

        /// <summary>
        /// CreatedOn of the PaymentTerms 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the PaymentTerms 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the PaymentTerms 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the PaymentTerms 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}