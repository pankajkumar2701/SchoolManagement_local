using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a salary entity with essential details
    /// </summary>
    public class Salary
    {
        /// <summary>
        /// Primary key for the Salary 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the Salary 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// BaseSalary of the Salary 
        /// </summary>
        public int? BaseSalary { get; set; }
        /// <summary>
        /// Bonus of the Salary 
        /// </summary>
        public int? Bonus { get; set; }

        /// <summary>
        /// CreatedOn of the Salary 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Salary 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Salary 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Salary 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}