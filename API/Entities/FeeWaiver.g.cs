using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a feewaiver entity with essential details
    /// </summary>
    public class FeeWaiver
    {
        /// <summary>
        /// TenantId of the FeeWaiver 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the FeeWaiver 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the FeeWaiver 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Amount of the FeeWaiver 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// Percentage of the FeeWaiver 
        /// </summary>
        public int? Percentage { get; set; }

        /// <summary>
        /// ValidFrom of the FeeWaiver 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// ValidUntil of the FeeWaiver 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// CreatedOn of the FeeWaiver 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the FeeWaiver 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the FeeWaiver 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the FeeWaiver 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}