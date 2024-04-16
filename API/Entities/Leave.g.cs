using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a leave entity with essential details
    /// </summary>
    public class Leave
    {
        /// <summary>
        /// TenantId of the Leave 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Leave 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Leave 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// DaysAllowed of the Leave 
        /// </summary>
        public int? DaysAllowed { get; set; }

        /// <summary>
        /// CreatedOn of the Leave 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Leave 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Leave 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Leave 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}