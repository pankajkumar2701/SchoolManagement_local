using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a event entity with essential details
    /// </summary>
    public class Event
    {
        /// <summary>
        /// TenantId of the Event 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Event 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Title of the Event 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Description of the Event 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// StartDate of the Event 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the Event 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Location of the Event 
        /// </summary>
        public string? Location { get; set; }

        /// <summary>
        /// CreatedOn of the Event 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Event 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Event 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Event 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}