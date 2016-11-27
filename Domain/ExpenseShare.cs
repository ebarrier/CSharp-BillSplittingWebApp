using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ExpenseShare
    {
        [Key]
        [Column(Order = 1)]
        public int PersonId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ExpenseId { get; set; }

        public virtual Person Person { get; set; }

        public virtual Expense Expense { get; set; }
    }
}
