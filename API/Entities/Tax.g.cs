using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a tax entity with essential details
    /// </summary>
    public class Tax
    {
        /// <summary>
        /// TenantId of the Tax 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Tax 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TaxName of the Tax 
        /// </summary>
        public string? TaxName { get; set; }
        /// <summary>
        /// TaxRate of the Tax 
        /// </summary>
        public int? TaxRate { get; set; }

        /// <summary>
        /// CreatedOn of the Tax 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Tax 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Tax 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Tax 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}