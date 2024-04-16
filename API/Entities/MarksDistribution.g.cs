using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a marksdistribution entity with essential details
    /// </summary>
    public class MarksDistribution
    {
        /// <summary>
        /// Primary key for the MarksDistribution 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TenantId of the MarksDistribution 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Foreign key referencing the ExamPaper to which the MarksDistribution belongs 
        /// </summary>
        public Guid? ExamPaperId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ExamPaper
        /// </summary>
        [ForeignKey("ExamPaperId")]
        public ExamPaper? ExamPaperId_ExamPaper { get; set; }
        /// <summary>
        /// DistributionType of the MarksDistribution 
        /// </summary>
        public string? DistributionType { get; set; }
        /// <summary>
        /// MaxMarks of the MarksDistribution 
        /// </summary>
        public int? MaxMarks { get; set; }
        /// <summary>
        /// Weightage of the MarksDistribution 
        /// </summary>
        public int? Weightage { get; set; }

        /// <summary>
        /// CreatedOn of the MarksDistribution 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the MarksDistribution 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the MarksDistribution 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the MarksDistribution 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}