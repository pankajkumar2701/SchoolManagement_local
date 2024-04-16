using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a absence entity with essential details
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// TenantId of the Absence 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Absence 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the AbsenceType to which the Absence belongs 
        /// </summary>
        public Guid? AbsenceTypeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated AbsenceType
        /// </summary>
        [ForeignKey("AbsenceTypeId")]
        public AbsenceType? AbsenceTypeId_AbsenceType { get; set; }

        /// <summary>
        /// StartDate of the Absence 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the Absence 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Reason of the Absence 
        /// </summary>
        public string? Reason { get; set; }

        /// <summary>
        /// CreatedOn of the Absence 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Absence 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Absence 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Absence 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}