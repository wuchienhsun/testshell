using System;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;
using testshell.Models;

namespace testshell.ViewModels
{
    public class LoanDeatilViewModel : ViewModelBase
    {
        public Loan Loan { get; set; }
        public Repayment Repayment { get; set; }
        //public Loan_repayment Loan_repayment { get; set; }
        public ObservableRangeCollection<Loan_repayment> Loan_repayment { get; set; }
        //public ObservableRangeCollection<Grouping<string, Loan_repayment>> Loan_repaymentGroup { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public LoanDeatilViewModel()
        {
            Title = "Loan Detail";


            Loan = new Loan { Id = ">", Name = "# Loan 2", Amount = "$5,000", Date = "2020/10/26" };

            Repayment = new Repayment
            {
                Id = "1",
                actualRepaymentDate = "2020/10/25",
                repaymentDate = "2020/10/26",
                payStatus = true,
                Amount = "$2,000"
            };

            Loan_repayment = new ObservableRangeCollection<Loan_repayment>();


            Loan_repayment.Add(new Loan_repayment() { loan = Loan, repayment = Repayment });

            //Loan_repaymentGroup = new ObservableRangeCollection<Grouping<string, Loan_repayment>>
            //{
            //    new Grouping<string, Loan_repayment>("group 1", new[] { Loan_repayment })
            //};




            //Repayment.Add(new Repayment
            //{
            //    Id = "2",
            //    actualRepaymentDate = null,
            //    repaymentDate = "2020/11/26",
            //    payStatus = false,
            //    Amount = "$2,000"
            //});
            //Repayment.Add(new Repayment
            //{
            //    Id = "3",
            //    actualRepaymentDate = null,
            //    repaymentDate = "2020/12/26",
            //    payStatus = false,
            //    Amount = "$2,000"
            //});

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
