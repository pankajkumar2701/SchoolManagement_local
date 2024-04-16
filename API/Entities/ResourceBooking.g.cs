using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a resourcebooking entity with essential details
    /// </summary>
    public class ResourceBooking
    {
        /// <summary>
        /// TenantId of the ResourceBooking 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ResourceBooking 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the ResourceRequest to which the ResourceBooking belongs 
        /// </summary>
        public Guid? ResourceRequestId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ResourceRequest
        /// </summary>
        [ForeignKey("ResourceRequestId")]
        public ResourceRequest? ResourceRequestId_ResourceRequest { get; set; }

        /// <summary>
        /// Required field BookingStartDate of the ResourceBooking 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime BookingStartDate { get; set; }

        /// <summary>
        /// Required field BookingEndDate of the ResourceBooking 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime BookingEndDate { get; set; }
        /// <summary>
        /// Status of the ResourceBooking 
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// CreatedOn of the ResourceBooking 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ResourceBooking 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ResourceBooking 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ResourceBooking 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}