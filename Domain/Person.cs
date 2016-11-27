using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        public string PersonName { get; set; }

        public virtual Event Event { get; set; }

        public virtual ICollection<ExpenseShare> ExpenseShares { get; set; }

    }
}
