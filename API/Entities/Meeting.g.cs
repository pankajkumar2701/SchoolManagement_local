using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a meeting entity with essential details
    /// </summary>
    public class Meeting
    {
        /// <summary>
        /// TenantId of the Meeting 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Meeting 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Title of the Meeting 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Description of the Meeting 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// StartTime of the Meeting 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// EndTime of the Meeting 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Attendees of the Meeting 
        /// </summary>
        public string? Attendees { get; set; }

        /// <summary>
        /// CreatedOn of the Meeting 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Meeting 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Meeting 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Meeting 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}