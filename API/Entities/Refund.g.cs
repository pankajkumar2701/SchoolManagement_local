using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a refund entity with essential details
    /// </summary>
    public class Refund
    {
        /// <summary>
        /// TenantId of the Refund 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Refund 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Amount of the Refund 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// Reason of the Refund 
        /// </summary>
        public string? Reason { get; set; }

        /// <summary>
        /// CreatedOn of the Refund 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Refund 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Refund 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Refund 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}