using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a installment entity with essential details
    /// </summary>
    public class Installment
    {
        /// <summary>
        /// TenantId of the Installment 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Installment 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Term to which the Installment belongs 
        /// </summary>
        [Required]
        public Guid TermId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Term
        /// </summary>
        [ForeignKey("TermId")]
        public Term? TermId_Term { get; set; }

        /// <summary>
        /// DueDate of the Installment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Amount of the Installment 
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// CreatedOn of the Installment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Installment 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Installment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Installment 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}