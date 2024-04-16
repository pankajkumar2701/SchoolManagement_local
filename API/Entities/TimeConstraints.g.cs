using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a timeconstraints entity with essential details
    /// </summary>
    public class TimeConstraints
    {
        /// <summary>
        /// TenantId of the TimeConstraints 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the TimeConstraints 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Resource to which the TimeConstraints belongs 
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Resource
        /// </summary>
        [ForeignKey("ResourceId")]
        public Resource? ResourceId_Resource { get; set; }

        /// <summary>
        /// StartTime of the TimeConstraints 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// EndTime of the TimeConstraints 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// ConstraintType of the TimeConstraints 
        /// </summary>
        public string? ConstraintType { get; set; }

        /// <summary>
        /// CreatedOn of the TimeConstraints 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the TimeConstraints 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the TimeConstraints 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the TimeConstraints 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}