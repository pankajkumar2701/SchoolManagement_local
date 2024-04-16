using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a parentguardian entity with essential details
    /// </summary>
    public class ParentGuardian
    {
        /// <summary>
        /// TenantId of the ParentGuardian 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ParentGuardian 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the ParentGuardian 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// FirstName of the ParentGuardian 
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// LastName of the ParentGuardian 
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// Foreign key referencing the ContactInformation to which the ParentGuardian belongs 
        /// </summary>
        public Guid? ContactInformationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ContactInformation
        /// </summary>
        [ForeignKey("ContactInformationId")]
        public ContactInformation? ContactInformationId_ContactInformation { get; set; }
        /// <summary>
        /// Foreign key referencing the Address to which the ParentGuardian belongs 
        /// </summary>
        public Guid? AddressId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Address
        /// </summary>
        [ForeignKey("AddressId")]
        public Address? AddressId_Address { get; set; }

        /// <summary>
        /// CreatedOn of the ParentGuardian 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ParentGuardian 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ParentGuardian 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ParentGuardian 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}