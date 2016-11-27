using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Event
    {
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }

    }
}
