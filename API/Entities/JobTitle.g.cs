using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a jobtitle entity with essential details
    /// </summary>
    public class JobTitle
    {
        /// <summary>
        /// TenantId of the JobTitle 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the JobTitle 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the JobTitle 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the JobTitle 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the JobTitle 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the JobTitle 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the JobTitle 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}