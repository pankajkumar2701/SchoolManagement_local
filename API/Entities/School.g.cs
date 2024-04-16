using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a school entity with essential details
    /// </summary>
    public class School
    {
        /// <summary>
        /// TenantId of the School 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the School 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the School 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Address of the School 
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        /// PhoneNumber of the School 
        /// </summary>
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// Email of the School 
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// CreatedOn of the School 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the School 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the School 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the School 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}