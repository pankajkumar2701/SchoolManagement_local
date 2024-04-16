using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a workflowstep entity with essential details
    /// </summary>
    public class WorkflowStep
    {
        /// <summary>
        /// TenantId of the WorkflowStep 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the WorkflowStep 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the WorkflowStep 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Workflow to which the WorkflowStep belongs 
        /// </summary>
        public Guid? WorkflowId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Workflow
        /// </summary>
        [ForeignKey("WorkflowId")]
        public Workflow? WorkflowId_Workflow { get; set; }
        /// <summary>
        /// Sequence of the WorkflowStep 
        /// </summary>
        public int? Sequence { get; set; }

        /// <summary>
        /// CreatedOn of the WorkflowStep 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the WorkflowStep 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the WorkflowStep 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the WorkflowStep 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}