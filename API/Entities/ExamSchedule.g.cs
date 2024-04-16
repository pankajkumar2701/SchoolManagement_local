using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a examschedule entity with essential details
    /// </summary>
    public class ExamSchedule
    {
        /// <summary>
        /// TenantId of the ExamSchedule 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ExamSchedule 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Exam to which the ExamSchedule belongs 
        /// </summary>
        public Guid? ExamId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Exam
        /// </summary>
        [ForeignKey("ExamId")]
        public Exam? ExamId_Exam { get; set; }
        /// <summary>
        /// Foreign key referencing the ExamSubject to which the ExamSchedule belongs 
        /// </summary>
        public Guid? ExamSubjectId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ExamSubject
        /// </summary>
        [ForeignKey("ExamSubjectId")]
        public ExamSubject? ExamSubjectId_ExamSubject { get; set; }

        /// <summary>
        /// Date of the ExamSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// StartTime of the ExamSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// EndTime of the ExamSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// CreatedOn of the ExamSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ExamSchedule 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ExamSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ExamSchedule 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}