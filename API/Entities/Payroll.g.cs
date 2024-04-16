using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolManagement_local.Entities
{
    /// <summary> 
    /// Represents a payroll entity with essential details
    /// </summary>
    public class Payroll
    {
        /// <summary>
        /// Primary key for the Payroll 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Employee to which the Payroll belongs 
        /// </summary>
        public Guid? EmployeeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Employee
        /// </summary>
        [ForeignKey("EmployeeId")]
        public Employee? EmployeeId_Employee { get; set; }
        /// <summary>
        /// Foreign key referencing the Salary to which the Payroll belongs 
        /// </summary>
        public Guid? SalaryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Salary
        /// </summary>
        [ForeignKey("SalaryId")]
        public Salary? SalaryId_Salary { get; set; }
        /// <summary>
        /// Foreign key referencing the Benefits to which the Payroll belongs 
        /// </summary>
        public Guid? BenefitsId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Benefits
        /// </summary>
        [ForeignKey("BenefitsId")]
        public Benefits? BenefitsId_Benefits { get; set; }

        /// <summary>
        /// StartDate of the Payroll 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the Payroll 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// CreatedOn of the Payroll 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Payroll 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Payroll 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Payroll 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}