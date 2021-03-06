﻿using System;
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

        public int ExpenseShareId { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        public int ExpenseId { get; set; }

        public virtual Person Person { get; set; }

        public virtual Expense Expense { get; set; }
    }
}
