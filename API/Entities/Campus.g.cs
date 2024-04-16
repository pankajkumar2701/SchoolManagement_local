using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a campus entity with essential details
    /// </summary>
    public class Campus
    {
        /// <summary>
        /// TenantId of the Campus 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Campus 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the Campus 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field Address of the Campus 
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// CreatedOn of the Campus 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Campus 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Campus 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Campus 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}