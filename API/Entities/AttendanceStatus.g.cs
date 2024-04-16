using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a attendancestatus entity with essential details
    /// </summary>
    public class AttendanceStatus
    {
        /// <summary>
        /// Primary key for the AttendanceStatus 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TenantId of the AttendanceStatus 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Status of the AttendanceStatus 
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// CreatedOn of the AttendanceStatus 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the AttendanceStatus 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the AttendanceStatus 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the AttendanceStatus 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}