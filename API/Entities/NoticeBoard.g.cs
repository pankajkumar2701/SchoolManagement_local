using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a noticeboard entity with essential details
    /// </summary>
    public class NoticeBoard
    {
        /// <summary>
        /// TenantId of the NoticeBoard 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the NoticeBoard 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Title of the NoticeBoard 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Description of the NoticeBoard 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// PostedDate of the NoticeBoard 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// CreatedOn of the NoticeBoard 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the NoticeBoard 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the NoticeBoard 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the NoticeBoard 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}