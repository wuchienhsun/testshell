using System;
using MvvmHelpers;

namespace testshell.Models
{
    public class Repayment
    {
        public string Id { get; set; }
        // 實際還款日
        public string actualRepaymentDate { get; set; }
        // 應還款日
        public string repaymentDate { get; set; }

        public bool payStatus { get; set; }

        public string Amount { get; set; }

        public static implicit operator Repayment(ObservableRangeCollection<Repayment> v)
        {
            throw new NotImplementedException();
        }
    }
}
