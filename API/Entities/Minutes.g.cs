using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a minutes entity with essential details
    /// </summary>
    public class Minutes
    {
        /// <summary>
        /// TenantId of the Minutes 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Minutes 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// MeetingNotes of the Minutes 
        /// </summary>
        public string? MeetingNotes { get; set; }
        /// <summary>
        /// Foreign key referencing the VideoConference to which the Minutes belongs 
        /// </summary>
        public Guid? VideoConferenceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated VideoConference
        /// </summary>
        [ForeignKey("VideoConferenceId")]
        public VideoConference? VideoConferenceId_VideoConference { get; set; }

        /// <summary>
        /// CreatedOn of the Minutes 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Minutes 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Minutes 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Minutes 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}