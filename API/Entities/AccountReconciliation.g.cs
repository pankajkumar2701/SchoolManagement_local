using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a accountreconciliation entity with essential details
    /// </summary>
    public class AccountReconciliation
    {
        /// <summary>
        /// TenantId of the AccountReconciliation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the AccountReconciliation 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the FinancialAccount to which the AccountReconciliation belongs 
        /// </summary>
        public Guid? FinancialAccountId { get; set; }

        /// <summary>
        /// Navigation property representing the associated FinancialAccount
        /// </summary>
        [ForeignKey("FinancialAccountId")]
        public FinancialAccount? FinancialAccountId_FinancialAccount { get; set; }

        /// <summary>
        /// StartDate of the AccountReconciliation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the AccountReconciliation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// StatementBalance of the AccountReconciliation 
        /// </summary>
        public int? StatementBalance { get; set; }

        /// <summary>
        /// CreatedOn of the AccountReconciliation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the AccountReconciliation 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the AccountReconciliation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the AccountReconciliation 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}