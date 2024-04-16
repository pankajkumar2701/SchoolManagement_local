using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a examroom entity with essential details
    /// </summary>
    public class ExamRoom
    {
        /// <summary>
        /// TenantId of the ExamRoom 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ExamRoom 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// RoomNumber of the ExamRoom 
        /// </summary>
        public string? RoomNumber { get; set; }
        /// <summary>
        /// Capacity of the ExamRoom 
        /// </summary>
        public int? Capacity { get; set; }

        /// <summary>
        /// CreatedOn of the ExamRoom 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ExamRoom 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ExamRoom 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ExamRoom 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}