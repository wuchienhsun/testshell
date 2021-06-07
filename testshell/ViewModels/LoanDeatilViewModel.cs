using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;
using testshell.Models;

namespace testshell.ViewModels
{
    public class LoanDeatilViewModel : ViewModelBase
    {
        public Loan Loan { get; set; }
        public List<Repayment> Repayment { get; set; }
        public ObservableRangeCollection<Loan_repayment> Loan_repayment { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public LoanDeatilViewModel()
        {
            Title = "Loan Detail";


            Loan = new Loan { Id = ">", Name = "# Loan 2", Amount = "$5,000", Date = "2020/10/26", InterestRate = "19%", Period = "3 terms" };

            Repayment = new List<Repayment>()
            {
                new Repayment {
                Id = "1",
                actualRepaymentDate = "2020/10/25",
                repaymentDate = "2020/10/26",
                payStatus = true,
                Amount = "$2,000"
                },
                new Repayment {
                Id = "1",
                actualRepaymentDate = "2020/10/25",
                repaymentDate = "2020/10/26",
                payStatus = true,
                Amount = "$2,000"
                },
            };

            Loan_repayment = new ObservableRangeCollection<Loan_repayment>();


            Loan_repayment.Add(new Loan_repayment() { loan = Loan, repayment = Repayment });

            RefreshCommand = new AsyncCommand(Refresh);



        }

        async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            IsBusy = false;
        }
    }
}
