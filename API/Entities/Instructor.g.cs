using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a instructor entity with essential details
    /// </summary>
    public class Instructor
    {
        /// <summary>
        /// TenantId of the Instructor 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Instructor 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Instructor 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Required field FirstName of the Instructor 
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Required field LastName of the Instructor 
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Required field Email of the Instructor 
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Required field PhoneNumber of the Instructor 
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// CreatedOn of the Instructor 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Instructor 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Instructor 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Instructor 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}