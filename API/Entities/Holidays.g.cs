using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a holidays entity with essential details
    /// </summary>
    public class Holidays
    {
        /// <summary>
        /// TenantId of the Holidays 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Holidays 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// HolidayDate of the Holidays 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? HolidayDate { get; set; }
        /// <summary>
        /// HolidayName of the Holidays 
        /// </summary>
        public string? HolidayName { get; set; }

        /// <summary>
        /// CreatedOn of the Holidays 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Holidays 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Holidays 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Holidays 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}