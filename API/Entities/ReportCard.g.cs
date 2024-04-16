using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a reportcard entity with essential details
    /// </summary>
    public class ReportCard
    {
        /// <summary>
        /// TenantId of the ReportCard 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ReportCard 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Class to which the ReportCard belongs 
        /// </summary>
        public Guid? ClassId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Class
        /// </summary>
        [ForeignKey("ClassId")]
        public Class? ClassId_Class { get; set; }
        /// <summary>
        /// Scores of the ReportCard 
        /// </summary>
        public string? Scores { get; set; }
        /// <summary>
        /// TotalMarks of the ReportCard 
        /// </summary>
        public int? TotalMarks { get; set; }

        /// <summary>
        /// CreatedOn of the ReportCard 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ReportCard 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ReportCard 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ReportCard 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}