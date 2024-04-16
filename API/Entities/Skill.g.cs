using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a skill entity with essential details
    /// </summary>
    public class Skill
    {
        /// <summary>
        /// Primary key for the Skill 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Skill 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the Skill 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Skill 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Skill 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Skill 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Skill 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}