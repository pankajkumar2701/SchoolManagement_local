using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a gradingscale entity with essential details
    /// </summary>
    public class GradingScale
    {
        /// <summary>
        /// TenantId of the GradingScale 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the GradingScale 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Grade of the GradingScale 
        /// </summary>
        public string? Grade { get; set; }
        /// <summary>
        /// Description of the GradingScale 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the GradingScale 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the GradingScale 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the GradingScale 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the GradingScale 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}