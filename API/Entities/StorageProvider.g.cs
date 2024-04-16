using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a storageprovider entity with essential details
    /// </summary>
    public class StorageProvider
    {
        /// <summary>
        /// TenantId of the StorageProvider 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the StorageProvider 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the StorageProvider 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Type of the StorageProvider 
        /// </summary>
        public string? Type { get; set; }
        /// <summary>
        /// Configuration of the StorageProvider 
        /// </summary>
        public string? Configuration { get; set; }

        /// <summary>
        /// CreatedOn of the StorageProvider 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the StorageProvider 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the StorageProvider 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the StorageProvider 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}