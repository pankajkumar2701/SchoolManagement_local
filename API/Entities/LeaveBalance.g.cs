using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a leavebalance entity with essential details
    /// </summary>
    public class LeaveBalance
    {
        /// <summary>
        /// TenantId of the LeaveBalance 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the LeaveBalance 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Employee to which the LeaveBalance belongs 
        /// </summary>
        public Guid? EmployeeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Employee
        /// </summary>
        [ForeignKey("EmployeeId")]
        public Employee? EmployeeId_Employee { get; set; }
        /// <summary>
        /// Foreign key referencing the LeaveType to which the LeaveBalance belongs 
        /// </summary>
        public Guid? LeaveTypeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated LeaveType
        /// </summary>
        [ForeignKey("LeaveTypeId")]
        public LeaveType? LeaveTypeId_LeaveType { get; set; }
        /// <summary>
        /// Balance of the LeaveBalance 
        /// </summary>
        public int? Balance { get; set; }

        /// <summary>
        /// CreatedOn of the LeaveBalance 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the LeaveBalance 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the LeaveBalance 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the LeaveBalance 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}