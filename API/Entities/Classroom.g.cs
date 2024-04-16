using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a classroom entity with essential details
    /// </summary>
    public class Classroom
    {
        /// <summary>
        /// TenantId of the Classroom 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Classroom 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Classroom 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Capacity of the Classroom 
        /// </summary>
        public int? Capacity { get; set; }
        /// <summary>
        /// Foreign key referencing the Section to which the Classroom belongs 
        /// </summary>
        public Guid? SectionId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Section
        /// </summary>
        [ForeignKey("SectionId")]
        public Section? SectionId_Section { get; set; }

        /// <summary>
        /// CreatedOn of the Classroom 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Classroom 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Classroom 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Classroom 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}