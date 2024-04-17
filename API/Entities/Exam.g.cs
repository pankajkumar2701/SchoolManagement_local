using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a exam entity with essential details
    /// </summary>
    public class Exam
    {
        /// <summary>
        /// TenantId of the Exam 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Exam 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Exam 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Subject of the Exam 
        /// </summary>
        public string? Subject { get; set; }

        /// <summary>
        /// StartDate of the Exam 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the Exam 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// CreatedOn of the Exam 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Exam 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Exam 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Exam 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}