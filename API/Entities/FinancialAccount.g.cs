using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a financialaccount entity with essential details
    /// </summary>
    public class FinancialAccount
    {
        /// <summary>
        /// TenantId of the FinancialAccount 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the FinancialAccount 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// AccountName of the FinancialAccount 
        /// </summary>
        public string? AccountName { get; set; }
        /// <summary>
        /// AccountType of the FinancialAccount 
        /// </summary>
        public string? AccountType { get; set; }
        /// <summary>
        /// Currency of the FinancialAccount 
        /// </summary>
        public string? Currency { get; set; }

        /// <summary>
        /// CreatedOn of the FinancialAccount 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the FinancialAccount 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the FinancialAccount 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the FinancialAccount 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}