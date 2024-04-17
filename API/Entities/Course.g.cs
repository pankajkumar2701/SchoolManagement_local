using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a course entity with essential details
    /// </summary>
    public class Course
    {
        /// <summary>
        /// TenantId of the Course 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Course 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Course 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Required field Code of the Course 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field Credits of the Course 
        /// </summary>
        [Required]
        public int Credits { get; set; }

        /// <summary>
        /// CreatedOn of the Course 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Course 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Course 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Course 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}