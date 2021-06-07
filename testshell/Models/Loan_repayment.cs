using System;
using System.Collections.Generic;

namespace testshell.Models
{
    public class Loan_repayment
    {
        public Loan loan { get; set; }
        public List<Repayment> repayment { get; set; }
    }
}
