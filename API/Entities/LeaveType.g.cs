using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a leavetype entity with essential details
    /// </summary>
    public class LeaveType
    {
        /// <summary>
        /// TenantId of the LeaveType 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the LeaveType 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TypeName of the LeaveType 
        /// </summary>
        [Required]
        public string TypeName { get; set; }
        /// <summary>
        /// PolicyDetails of the LeaveType 
        /// </summary>
        public string? PolicyDetails { get; set; }

        /// <summary>
        /// CreatedOn of the LeaveType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the LeaveType 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the LeaveType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the LeaveType 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}