using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a documentarchive entity with essential details
    /// </summary>
    public class DocumentArchive
    {
        /// <summary>
        /// TenantId of the DocumentArchive 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DocumentArchive 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// DocumentId of the DocumentArchive 
        /// </summary>
        public Guid? DocumentId { get; set; }
        /// <summary>
        /// Foreign key referencing the ArchiveLocation to which the DocumentArchive belongs 
        /// </summary>
        public Guid? ArchiveLocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ArchiveLocation
        /// </summary>
        [ForeignKey("ArchiveLocationId")]
        public ArchiveLocation? ArchiveLocationId_ArchiveLocation { get; set; }
        /// <summary>
        /// Foreign key referencing the RetentionSchedule to which the DocumentArchive belongs 
        /// </summary>
        public Guid? RetentionScheduleId { get; set; }

        /// <summary>
        /// Navigation property representing the associated RetentionSchedule
        /// </summary>
        [ForeignKey("RetentionScheduleId")]
        public RetentionSchedule? RetentionScheduleId_RetentionSchedule { get; set; }
        /// <summary>
        /// Foreign key referencing the ReviewSchedule to which the DocumentArchive belongs 
        /// </summary>
        public Guid? ReviewScheduleId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ReviewSchedule
        /// </summary>
        [ForeignKey("ReviewScheduleId")]
        public ReviewSchedule? ReviewScheduleId_ReviewSchedule { get; set; }

        /// <summary>
        /// Required field DateArchived of the DocumentArchive 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime DateArchived { get; set; }

        /// <summary>
        /// CreatedOn of the DocumentArchive 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the DocumentArchive 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the DocumentArchive 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the DocumentArchive 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}