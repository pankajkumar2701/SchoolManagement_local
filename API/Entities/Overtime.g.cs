using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a overtime entity with essential details
    /// </summary>
    public class Overtime
    {
        /// <summary>
        /// TenantId of the Overtime 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Overtime 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Date of the Overtime 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Hours of the Overtime 
        /// </summary>
        public int? Hours { get; set; }
        /// <summary>
        /// Reason of the Overtime 
        /// </summary>
        public string? Reason { get; set; }

        /// <summary>
        /// CreatedOn of the Overtime 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Overtime 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Overtime 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Overtime 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}