using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a currency entity with essential details
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// TenantId of the Currency 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Currency 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the Currency 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Currency 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Symbol of the Currency 
        /// </summary>
        public string? Symbol { get; set; }

        /// <summary>
        /// CreatedOn of the Currency 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Currency 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Currency 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Currency 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}