using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a answer entity with essential details
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// TenantId of the Answer 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Answer 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Question to which the Answer belongs 
        /// </summary>
        public Guid? QuestionId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Question
        /// </summary>
        [ForeignKey("QuestionId")]
        public Question? QuestionId_Question { get; set; }
        /// <summary>
        /// Content of the Answer 
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// Correct of the Answer 
        /// </summary>
        public int? Correct { get; set; }

        /// <summary>
        /// CreatedOn of the Answer 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Answer 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Answer 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Answer 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}