using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFExample
{
    public class Employee
    {
        /* It is an anaog of a table in SQL */
        [Key] /* attribute makes a primary key */
        public Guid Id { get; set; }
        //Set max and min length with validation error message

        /* Attributes */
        [MinLength(3)] /* if the number if chars is less than 3, an error message generates automatically.  */
        [MaxLength(100)]
        [Required]
        public string FirstName { get; set; }

        /* Attributes */
        [MinLength(3, ErrorMessage = "Length must be more that 5 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less that 100 characters")]
        [Required]
        public string LastName { get; set; }

        /* Attribute */
        //Set field as not null
        [Required]
        public double Salary { get; set; }

        //Set db type to datetime2, because default is datetime
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }

        [Required]
        public virtual Position Position { get; set; } /* virtual == you may override it */
    }
}