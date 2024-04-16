using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a attendancereport entity with essential details
    /// </summary>
    public class AttendanceReport
    {
        /// <summary>
        /// TenantId of the AttendanceReport 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the AttendanceReport 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Employee to which the AttendanceReport belongs 
        /// </summary>
        [Required]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Employee
        /// </summary>
        [ForeignKey("EmployeeId")]
        public Employee? EmployeeId_Employee { get; set; }

        /// <summary>
        /// Required field AttendanceDate of the AttendanceReport 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime AttendanceDate { get; set; }
        /// <summary>
        /// Status of the AttendanceReport 
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// CreatedOn of the AttendanceReport 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the AttendanceReport 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the AttendanceReport 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the AttendanceReport 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}