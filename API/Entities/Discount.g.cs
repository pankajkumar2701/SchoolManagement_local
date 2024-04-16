using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a discount entity with essential details
    /// </summary>
    public class Discount
    {
        /// <summary>
        /// TenantId of the Discount 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Discount 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Discount 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Percentage of the Discount 
        /// </summary>
        public int? Percentage { get; set; }

        /// <summary>
        /// CreatedOn of the Discount 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Discount 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Discount 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Discount 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}