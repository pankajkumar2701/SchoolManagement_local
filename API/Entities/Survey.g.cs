using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a survey entity with essential details
    /// </summary>
    public class Survey
    {
        /// <summary>
        /// TenantId of the Survey 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Survey 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Title of the Survey 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Description of the Survey 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// QuestionCount of the Survey 
        /// </summary>
        public int? QuestionCount { get; set; }

        /// <summary>
        /// CreatedOn of the Survey 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Survey 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Survey 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Survey 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}