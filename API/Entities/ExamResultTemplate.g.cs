using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a examresulttemplate entity with essential details
    /// </summary>
    public class ExamResultTemplate
    {
        /// <summary>
        /// Primary key for the ExamResultTemplate 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TenantId of the ExamResultTemplate 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// TemplateName of the ExamResultTemplate 
        /// </summary>
        public string? TemplateName { get; set; }
        /// <summary>
        /// FileName of the ExamResultTemplate 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FileType of the ExamResultTemplate 
        /// </summary>
        public string? FileType { get; set; }

        /// <summary>
        /// CreatedOn of the ExamResultTemplate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ExamResultTemplate 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ExamResultTemplate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ExamResultTemplate 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}