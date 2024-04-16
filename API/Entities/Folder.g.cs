using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a folder entity with essential details
    /// </summary>
    public class Folder
    {
        /// <summary>
        /// TenantId of the Folder 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Folder 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Folder 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Folder to which the Folder belongs 
        /// </summary>
        public Guid? ParentFolderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Folder
        /// </summary>
        [ForeignKey("ParentFolderId")]
        public Folder? ParentFolderId_Folder { get; set; }

        /// <summary>
        /// CreatedOn of the Folder 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Folder 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Folder 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Folder 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}