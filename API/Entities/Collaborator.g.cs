using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a collaborator entity with essential details
    /// </summary>
    public class Collaborator
    {
        /// <summary>
        /// TenantId of the Collaborator 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Collaborator 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// UserId of the Collaborator 
        /// </summary>
        public Guid? UserId { get; set; }
        /// <summary>
        /// Foreign key referencing the Project to which the Collaborator belongs 
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Project
        /// </summary>
        [ForeignKey("ProjectId")]
        public Project? ProjectId_Project { get; set; }
        /// <summary>
        /// Role of the Collaborator 
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// CreatedOn of the Collaborator 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Collaborator 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Collaborator 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Collaborator 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}