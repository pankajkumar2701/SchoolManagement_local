using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a timetabletemplate entity with essential details
    /// </summary>
    public class TimetableTemplate
    {
        /// <summary>
        /// TenantId of the TimetableTemplate 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the TimetableTemplate 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the TimetableTemplate 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the TimetableTemplate 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the TimetableTemplate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the TimetableTemplate 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the TimetableTemplate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the TimetableTemplate 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}