using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a performancereview entity with essential details
    /// </summary>
    public class PerformanceReview
    {
        /// <summary>
        /// Primary key for the PerformanceReview 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Employee to which the PerformanceReview belongs 
        /// </summary>
        public Guid? EmployeeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Employee
        /// </summary>
        [ForeignKey("EmployeeId")]
        public Employee? EmployeeId_Employee { get; set; }

        /// <summary>
        /// ReviewDate of the PerformanceReview 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ReviewDate { get; set; }
        /// <summary>
        /// Rating of the PerformanceReview 
        /// </summary>
        public int? Rating { get; set; }
        /// <summary>
        /// Comments of the PerformanceReview 
        /// </summary>
        public string? Comments { get; set; }

        /// <summary>
        /// CreatedOn of the PerformanceReview 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the PerformanceReview 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the PerformanceReview 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the PerformanceReview 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}