using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a share entity with essential details
    /// </summary>
    public class Share
    {
        /// <summary>
        /// TenantId of the Share 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Share 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the FileStorage to which the Share belongs 
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated FileStorage
        /// </summary>
        [ForeignKey("ResourceId")]
        public FileStorage? ResourceId_FileStorage { get; set; }
        /// <summary>
        /// Foreign key referencing the AccessLevel to which the Share belongs 
        /// </summary>
        public Guid? AccessLevelId { get; set; }

        /// <summary>
        /// Navigation property representing the associated AccessLevel
        /// </summary>
        [ForeignKey("AccessLevelId")]
        public AccessLevel? AccessLevelId_AccessLevel { get; set; }

        /// <summary>
        /// ExpirationDate of the Share 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// CreatedOn of the Share 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Share 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Share 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Share 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}