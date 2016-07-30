using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFExample
{
    public class Position
    {
        [Key]
        public Guid Id { get; set; }

        //Market this field as primary key
        [Index(IsUnique = true)]
        public int Code { get; set; }

        //Set max length on Name to 50 characters (nvarchar(50))
        [MaxLength(50)]
        public string Name { get; set; }
    }
}