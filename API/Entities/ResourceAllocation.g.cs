using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a resourceallocation entity with essential details
    /// </summary>
    public class ResourceAllocation
    {
        /// <summary>
        /// TenantId of the ResourceAllocation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ResourceAllocation 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Resource to which the ResourceAllocation belongs 
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Resource
        /// </summary>
        [ForeignKey("ResourceId")]
        public Resource? ResourceId_Resource { get; set; }
        /// <summary>
        /// Foreign key referencing the TimeSlot to which the ResourceAllocation belongs 
        /// </summary>
        public Guid? TimeSlotId { get; set; }

        /// <summary>
        /// Navigation property representing the associated TimeSlot
        /// </summary>
        [ForeignKey("TimeSlotId")]
        public TimeSlot? TimeSlotId_TimeSlot { get; set; }

        /// <summary>
        /// CreatedOn of the ResourceAllocation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ResourceAllocation 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ResourceAllocation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ResourceAllocation 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}