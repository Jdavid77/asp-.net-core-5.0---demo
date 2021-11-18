using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace ASPNETCORE_Demo.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }


    }
}