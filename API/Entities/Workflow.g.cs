using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a workflow entity with essential details
    /// </summary>
    public class Workflow
    {
        /// <summary>
        /// TenantId of the Workflow 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Workflow 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Workflow 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the Workflow 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Foreign key referencing the Approval to which the Workflow belongs 
        /// </summary>
        public Guid? ApprovalId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Approval
        /// </summary>
        [ForeignKey("ApprovalId")]
        public Approval? ApprovalId_Approval { get; set; }

        /// <summary>
        /// CreatedOn of the Workflow 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Workflow 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Workflow 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Workflow 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}