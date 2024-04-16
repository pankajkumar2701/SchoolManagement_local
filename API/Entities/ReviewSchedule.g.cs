using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a reviewschedule entity with essential details
    /// </summary>
    public class ReviewSchedule
    {
        /// <summary>
        /// TenantId of the ReviewSchedule 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ReviewSchedule 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the ReviewSchedule 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Frequency of the ReviewSchedule 
        /// </summary>
        public int? Frequency { get; set; }
        /// <summary>
        /// TimeUnit of the ReviewSchedule 
        /// </summary>
        public string? TimeUnit { get; set; }

        /// <summary>
        /// CreatedOn of the ReviewSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ReviewSchedule 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ReviewSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ReviewSchedule 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}