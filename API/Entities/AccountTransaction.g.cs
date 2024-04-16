using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a accounttransaction entity with essential details
    /// </summary>
    public class AccountTransaction
    {
        /// <summary>
        /// TenantId of the AccountTransaction 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the AccountTransaction 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the FinancialAccount to which the AccountTransaction belongs 
        /// </summary>
        public Guid? FinancialAccountId { get; set; }

        /// <summary>
        /// Navigation property representing the associated FinancialAccount
        /// </summary>
        [ForeignKey("FinancialAccountId")]
        public FinancialAccount? FinancialAccountId_FinancialAccount { get; set; }
        /// <summary>
        /// TransactionType of the AccountTransaction 
        /// </summary>
        public string? TransactionType { get; set; }
        /// <summary>
        /// Amount of the AccountTransaction 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// Description of the AccountTransaction 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the AccountTransaction 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the AccountTransaction 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the AccountTransaction 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the AccountTransaction 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}