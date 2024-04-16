using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a evaluationcriteria entity with essential details
    /// </summary>
    public class EvaluationCriteria
    {
        /// <summary>
        /// Primary key for the EvaluationCriteria 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TenantId of the EvaluationCriteria 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Criteria of the EvaluationCriteria 
        /// </summary>
        public string? Criteria { get; set; }
        /// <summary>
        /// Weightage of the EvaluationCriteria 
        /// </summary>
        public int? Weightage { get; set; }

        /// <summary>
        /// CreatedOn of the EvaluationCriteria 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the EvaluationCriteria 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the EvaluationCriteria 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the EvaluationCriteria 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}