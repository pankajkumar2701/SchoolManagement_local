using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a extracurricularactivity entity with essential details
    /// </summary>
    public class ExtraCurricularActivity
    {
        /// <summary>
        /// TenantId of the ExtraCurricularActivity 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ExtraCurricularActivity 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the ExtraCurricularActivity 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the ExtraCurricularActivity 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the ExtraCurricularActivity 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ExtraCurricularActivity 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ExtraCurricularActivity 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ExtraCurricularActivity 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}