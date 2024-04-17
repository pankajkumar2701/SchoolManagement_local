using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a teacher entity with essential details
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// TenantId of the Teacher 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Teacher 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Teacher 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// FirstName of the Teacher 
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// LastName of the Teacher 
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// Subject of the Teacher 
        /// </summary>
        public string? Subject { get; set; }

        /// <summary>
        /// CreatedOn of the Teacher 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Teacher 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Teacher 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Teacher 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}