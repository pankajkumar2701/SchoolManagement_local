using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a fee entity with essential details
    /// </summary>
    public class Fee
    {
        /// <summary>
        /// TenantId of the Fee 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Fee 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Student to which the Fee belongs 
        /// </summary>
        public Guid? StudentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Student
        /// </summary>
        [ForeignKey("StudentId")]
        public Student? StudentId_Student { get; set; }
        /// <summary>
        /// FeeType of the Fee 
        /// </summary>
        public string? FeeType { get; set; }
        /// <summary>
        /// Amount of the Fee 
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// DueDate of the Fee 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// CreatedOn of the Fee 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Fee 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Fee 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Fee 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}