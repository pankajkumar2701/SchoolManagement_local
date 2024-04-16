using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a address entity with essential details
    /// </summary>
    public class Address
    {
        /// <summary>
        /// TenantId of the Address 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Address 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Address 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Street of the Address 
        /// </summary>
        public string? Street { get; set; }
        /// <summary>
        /// City of the Address 
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// State of the Address 
        /// </summary>
        public string? State { get; set; }
        /// <summary>
        /// PostalCode of the Address 
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// Country of the Address 
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// CreatedOn of the Address 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Address 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Address 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Address 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}