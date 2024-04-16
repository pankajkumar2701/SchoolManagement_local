using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a room entity with essential details
    /// </summary>
    public class Room
    {
        /// <summary>
        /// TenantId of the Room 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Room 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Building to which the Room belongs 
        /// </summary>
        [Required]
        public Guid BuildingId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Building
        /// </summary>
        [ForeignKey("BuildingId")]
        public Building? BuildingId_Building { get; set; }

        /// <summary>
        /// Required field Number of the Room 
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Required field Capacity of the Room 
        /// </summary>
        [Required]
        public int Capacity { get; set; }

        /// <summary>
        /// CreatedOn of the Room 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Room 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Room 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Room 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}