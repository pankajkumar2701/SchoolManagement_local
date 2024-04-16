using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a project entity with essential details
    /// </summary>
    public class Project
    {
        /// <summary>
        /// TenantId of the Project 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Project 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Project 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the Project 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// StartDate of the Project 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the Project 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Status of the Project 
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// CreatedOn of the Project 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Project 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Project 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Project 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}