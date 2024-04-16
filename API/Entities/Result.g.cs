using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a result entity with essential details
    /// </summary>
    public class Result
    {
        /// <summary>
        /// TenantId of the Result 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Result 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// StudentId of the Result 
        /// </summary>
        public Guid? StudentId { get; set; }
        /// <summary>
        /// TotalMarks of the Result 
        /// </summary>
        public int? TotalMarks { get; set; }

        /// <summary>
        /// CreatedOn of the Result 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Result 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Result 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Result 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}