using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Expense
    {
        public int ExpenseId { get; set; }

        [Required]
        public string ExpenseName { get; set; }

        [Required]
        public float ExpenseAmount { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        public int EventId { get; set; }

        public virtual ICollection<ExpenseShare> ExpenseShares { get; set; }

        public virtual Event Event { get; set; }
    }
}
