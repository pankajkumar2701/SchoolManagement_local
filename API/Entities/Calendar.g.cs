using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a calendar entity with essential details
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// TenantId of the Calendar 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Calendar 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Calendar 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the Calendar 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Calendar 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Calendar 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Calendar 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Calendar 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}