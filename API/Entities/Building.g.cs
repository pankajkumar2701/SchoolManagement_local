using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a building entity with essential details
    /// </summary>
    public class Building
    {
        /// <summary>
        /// TenantId of the Building 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Building 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Campus to which the Building belongs 
        /// </summary>
        [Required]
        public Guid CampusId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Campus
        /// </summary>
        [ForeignKey("CampusId")]
        public Campus? CampusId_Campus { get; set; }

        /// <summary>
        /// Required field Name of the Building 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field Address of the Building 
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// CreatedOn of the Building 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Building 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Building 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Building 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}