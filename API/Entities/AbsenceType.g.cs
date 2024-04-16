using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a absencetype entity with essential details
    /// </summary>
    public class AbsenceType
    {
        /// <summary>
        /// TenantId of the AbsenceType 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the AbsenceType 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the AbsenceType 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the AbsenceType 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the AbsenceType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the AbsenceType 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the AbsenceType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the AbsenceType 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}