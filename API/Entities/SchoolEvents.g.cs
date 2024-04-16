using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a schoolevents entity with essential details
    /// </summary>
    public class SchoolEvents
    {
        /// <summary>
        /// TenantId of the SchoolEvents 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the SchoolEvents 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Title of the SchoolEvents 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Description of the SchoolEvents 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// StartTime of the SchoolEvents 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// EndTime of the SchoolEvents 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Venue of the SchoolEvents 
        /// </summary>
        public string? Venue { get; set; }

        /// <summary>
        /// CreatedOn of the SchoolEvents 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the SchoolEvents 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the SchoolEvents 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the SchoolEvents 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}