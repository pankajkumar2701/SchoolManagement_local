using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a semester entity with essential details
    /// </summary>
    public class Semester
    {
        /// <summary>
        /// TenantId of the Semester 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Semester 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the AcademicYear to which the Semester belongs 
        /// </summary>
        public Guid? AcademicYearId { get; set; }

        /// <summary>
        /// Navigation property representing the associated AcademicYear
        /// </summary>
        [ForeignKey("AcademicYearId")]
        public AcademicYear? AcademicYearId_AcademicYear { get; set; }
        /// <summary>
        /// Name of the Semester 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// StartDate of the Semester 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the Semester 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// CreatedOn of the Semester 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Semester 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Semester 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Semester 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}