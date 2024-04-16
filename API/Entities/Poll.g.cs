using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a poll entity with essential details
    /// </summary>
    public class Poll
    {
        /// <summary>
        /// TenantId of the Poll 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Poll 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Question of the Poll 
        /// </summary>
        public string? Question { get; set; }
        /// <summary>
        /// Option1 of the Poll 
        /// </summary>
        public string? Option1 { get; set; }
        /// <summary>
        /// Option2 of the Poll 
        /// </summary>
        public string? Option2 { get; set; }
        /// <summary>
        /// Option3 of the Poll 
        /// </summary>
        public string? Option3 { get; set; }
        /// <summary>
        /// Option4 of the Poll 
        /// </summary>
        public string? Option4 { get; set; }

        /// <summary>
        /// CreatedOn of the Poll 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Poll 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Poll 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Poll 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}