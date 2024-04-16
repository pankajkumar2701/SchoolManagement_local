using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a audittrail entity with essential details
    /// </summary>
    public class AuditTrail
    {
        /// <summary>
        /// TenantId of the AuditTrail 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the AuditTrail 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// ActionType of the AuditTrail 
        /// </summary>
        public string? ActionType { get; set; }
        /// <summary>
        /// EntityName of the AuditTrail 
        /// </summary>
        public string? EntityName { get; set; }
        /// <summary>
        /// EntityId of the AuditTrail 
        /// </summary>
        public Guid? EntityId { get; set; }
        /// <summary>
        /// UserId of the AuditTrail 
        /// </summary>
        public Guid? UserId { get; set; }
        /// <summary>
        /// Details of the AuditTrail 
        /// </summary>
        public string? Details { get; set; }

        /// <summary>
        /// CreatedOn of the AuditTrail 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the AuditTrail 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the AuditTrail 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the AuditTrail 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}