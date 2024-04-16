using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a filestorage entity with essential details
    /// </summary>
    public class FileStorage
    {
        /// <summary>
        /// TenantId of the FileStorage 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the FileStorage 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// FileName of the FileStorage 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FilePath of the FileStorage 
        /// </summary>
        public string? FilePath { get; set; }
        /// <summary>
        /// ContentType of the FileStorage 
        /// </summary>
        public string? ContentType { get; set; }
        /// <summary>
        /// FileSize of the FileStorage 
        /// </summary>
        public int? FileSize { get; set; }

        /// <summary>
        /// CreatedOn of the FileStorage 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the FileStorage 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the FileStorage 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the FileStorage 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}