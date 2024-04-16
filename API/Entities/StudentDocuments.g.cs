using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a studentdocuments entity with essential details
    /// </summary>
    public class StudentDocuments
    {
        /// <summary>
        /// TenantId of the StudentDocuments 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the StudentDocuments 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Student to which the StudentDocuments belongs 
        /// </summary>
        public Guid? StudentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Student
        /// </summary>
        [ForeignKey("StudentId")]
        public Student? StudentId_Student { get; set; }
        /// <summary>
        /// Foreign key referencing the DocumentTypes to which the StudentDocuments belongs 
        /// </summary>
        public Guid? DocumentTypeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated DocumentTypes
        /// </summary>
        [ForeignKey("DocumentTypeId")]
        public DocumentTypes? DocumentTypeId_DocumentTypes { get; set; }
        /// <summary>
        /// FileName of the StudentDocuments 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FileSize of the StudentDocuments 
        /// </summary>
        public int? FileSize { get; set; }

        /// <summary>
        /// CreatedOn of the StudentDocuments 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the StudentDocuments 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the StudentDocuments 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the StudentDocuments 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}