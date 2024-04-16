using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a examresultnotification entity with essential details
    /// </summary>
    public class ExamResultNotification
    {
        /// <summary>
        /// Primary key for the ExamResultNotification 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TenantId of the ExamResultNotification 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Foreign key referencing the ExamPaper to which the ExamResultNotification belongs 
        /// </summary>
        public Guid? ExamPaperId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ExamPaper
        /// </summary>
        [ForeignKey("ExamPaperId")]
        public ExamPaper? ExamPaperId_ExamPaper { get; set; }

        /// <summary>
        /// NotificationDate of the ExamResultNotification 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? NotificationDate { get; set; }

        /// <summary>
        /// CreatedOn of the ExamResultNotification 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ExamResultNotification 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ExamResultNotification 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ExamResultNotification 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}