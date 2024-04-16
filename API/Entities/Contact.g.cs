using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a contact entity with essential details
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// TenantId of the Contact 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Contact 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// FirstName of the Contact 
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// LastName of the Contact 
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// Email of the Contact 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Phone of the Contact 
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// Address of the Contact 
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// CreatedOn of the Contact 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Contact 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Contact 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Contact 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}