using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a discussion entity with essential details
    /// </summary>
    public class Discussion
    {
        /// <summary>
        /// TenantId of the Discussion 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Discussion 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Topic of the Discussion 
        /// </summary>
        public string? Topic { get; set; }
        /// <summary>
        /// Description of the Discussion 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Discussion 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Discussion 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Discussion 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Discussion 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}