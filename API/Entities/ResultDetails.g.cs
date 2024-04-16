using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a resultdetails entity with essential details
    /// </summary>
    public class ResultDetails
    {
        /// <summary>
        /// TenantId of the ResultDetails 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ResultDetails 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Result to which the ResultDetails belongs 
        /// </summary>
        public Guid? ResultId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Result
        /// </summary>
        [ForeignKey("ResultId")]
        public Result? ResultId_Result { get; set; }
        /// <summary>
        /// Foreign key referencing the ExamSubject to which the ResultDetails belongs 
        /// </summary>
        public Guid? ExamSubjectId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ExamSubject
        /// </summary>
        [ForeignKey("ExamSubjectId")]
        public ExamSubject? ExamSubjectId_ExamSubject { get; set; }
        /// <summary>
        /// MarksObtained of the ResultDetails 
        /// </summary>
        public int? MarksObtained { get; set; }

        /// <summary>
        /// CreatedOn of the ResultDetails 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ResultDetails 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ResultDetails 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ResultDetails 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}