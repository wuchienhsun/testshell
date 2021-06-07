using System;
using MvvmHelpers;

namespace testshell.Models
{
    public class Loan
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Date { get; set; }
        public string InterestRate { get; set; }
        public string Period { get; set; }

        public static implicit operator Loan(ObservableRangeCollection<Loan> v)
        {
            throw new NotImplementedException();
        }
    }
}
