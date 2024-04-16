using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a autoclassification entity with essential details
    /// </summary>
    public class AutoClassification
    {
        /// <summary>
        /// TenantId of the AutoClassification 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the AutoClassification 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// ClassificationType of the AutoClassification 
        /// </summary>
        public string? ClassificationType { get; set; }
        /// <summary>
        /// ClassificationRules of the AutoClassification 
        /// </summary>
        public string? ClassificationRules { get; set; }
        /// <summary>
        /// IsActive of the AutoClassification 
        /// </summary>
        public int? IsActive { get; set; }

        /// <summary>
        /// CreatedOn of the AutoClassification 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the AutoClassification 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the AutoClassification 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the AutoClassification 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}