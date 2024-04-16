using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a exampaper entity with essential details
    /// </summary>
    public class ExamPaper
    {
        /// <summary>
        /// Primary key for the ExamPaper 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TenantId of the ExamPaper 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Title of the ExamPaper 
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Date of the ExamPaper 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// CreatedOn of the ExamPaper 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ExamPaper 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ExamPaper 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ExamPaper 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}