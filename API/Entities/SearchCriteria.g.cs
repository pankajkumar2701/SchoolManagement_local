using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a searchcriteria entity with essential details
    /// </summary>
    public class SearchCriteria
    {
        /// <summary>
        /// TenantId of the SearchCriteria 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the SearchCriteria 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the SearchCriteria 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// FieldType of the SearchCriteria 
        /// </summary>
        public string? FieldType { get; set; }
        /// <summary>
        /// Value of the SearchCriteria 
        /// </summary>
        public string? Value { get; set; }

        /// <summary>
        /// CreatedOn of the SearchCriteria 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the SearchCriteria 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the SearchCriteria 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the SearchCriteria 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}