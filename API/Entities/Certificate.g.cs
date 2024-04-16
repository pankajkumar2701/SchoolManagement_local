using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a certificate entity with essential details
    /// </summary>
    public class Certificate
    {
        /// <summary>
        /// Primary key for the Certificate 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TenantId of the Certificate 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// StudentId of the Certificate 
        /// </summary>
        public Guid? StudentId { get; set; }
        /// <summary>
        /// Name of the Certificate 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// IssuedDate of the Certificate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? IssuedDate { get; set; }

        /// <summary>
        /// Validity of the Certificate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Validity { get; set; }

        /// <summary>
        /// CreatedOn of the Certificate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Certificate 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Certificate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Certificate 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}