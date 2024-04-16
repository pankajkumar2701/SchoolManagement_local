using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a attendancepolicy entity with essential details
    /// </summary>
    public class AttendancePolicy
    {
        /// <summary>
        /// TenantId of the AttendancePolicy 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the AttendancePolicy 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the AttendancePolicy 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// PolicyDetails of the AttendancePolicy 
        /// </summary>
        public string? PolicyDetails { get; set; }

        /// <summary>
        /// CreatedOn of the AttendancePolicy 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the AttendancePolicy 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the AttendancePolicy 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the AttendancePolicy 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}