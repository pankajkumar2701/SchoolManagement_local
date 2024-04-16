using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a benefits entity with essential details
    /// </summary>
    public class Benefits
    {
        /// <summary>
        /// Primary key for the Benefits 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the Benefits 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// HealthInsurance of the Benefits 
        /// </summary>
        public string? HealthInsurance { get; set; }
        /// <summary>
        /// RetirementPlan of the Benefits 
        /// </summary>
        public string? RetirementPlan { get; set; }
        /// <summary>
        /// PaidTimeOff of the Benefits 
        /// </summary>
        public int? PaidTimeOff { get; set; }

        /// <summary>
        /// CreatedOn of the Benefits 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Benefits 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Benefits 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Benefits 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}