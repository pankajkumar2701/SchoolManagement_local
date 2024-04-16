using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a question entity with essential details
    /// </summary>
    public class Question
    {
        /// <summary>
        /// TenantId of the Question 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Question 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the ExamSubject to which the Question belongs 
        /// </summary>
        public Guid? ExamSubjectId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ExamSubject
        /// </summary>
        [ForeignKey("ExamSubjectId")]
        public ExamSubject? ExamSubjectId_ExamSubject { get; set; }
        /// <summary>
        /// Content of the Question 
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// CreatedOn of the Question 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Question 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Question 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Question 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}