using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a examinationboard entity with essential details
    /// </summary>
    public class ExaminationBoard
    {
        /// <summary>
        /// TenantId of the ExaminationBoard 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ExaminationBoard 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the ExaminationBoard 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the ExaminationBoard 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ExaminationBoard 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ExaminationBoard 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ExaminationBoard 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}