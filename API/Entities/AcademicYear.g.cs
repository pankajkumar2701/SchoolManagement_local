using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a academicyear entity with essential details
    /// </summary>
    public class AcademicYear
    {
        /// <summary>
        /// TenantId of the AcademicYear 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the AcademicYear 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the AcademicYear 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Year of the AcademicYear 
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        /// StartDate of the AcademicYear 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the AcademicYear 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// CreatedOn of the AcademicYear 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the AcademicYear 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the AcademicYear 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the AcademicYear 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}