using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a timeoffrequest entity with essential details
    /// </summary>
    public class TimeOffRequest
    {
        /// <summary>
        /// TenantId of the TimeOffRequest 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the TimeOffRequest 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Employee to which the TimeOffRequest belongs 
        /// </summary>
        public Guid? EmployeeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Employee
        /// </summary>
        [ForeignKey("EmployeeId")]
        public Employee? EmployeeId_Employee { get; set; }

        /// <summary>
        /// StartDate of the TimeOffRequest 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the TimeOffRequest 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Leave to which the TimeOffRequest belongs 
        /// </summary>
        public Guid? LeaveId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Leave
        /// </summary>
        [ForeignKey("LeaveId")]
        public Leave? LeaveId_Leave { get; set; }

        /// <summary>
        /// CreatedOn of the TimeOffRequest 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the TimeOffRequest 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the TimeOffRequest 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the TimeOffRequest 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}