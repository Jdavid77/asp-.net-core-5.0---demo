using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCORE_Demo.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense Name")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Valor Inválido!!")]
        public double Amount { get; set; }


    }
}