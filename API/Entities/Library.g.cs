using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a library entity with essential details
    /// </summary>
    public class Library
    {
        /// <summary>
        /// TenantId of the Library 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Library 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Library 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Location of the Library 
        /// </summary>
        public string? Location { get; set; }

        /// <summary>
        /// CreatedOn of the Library 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Library 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Library 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Library 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}