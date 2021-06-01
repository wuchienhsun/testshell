using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using MvvmHelpers.Commands;
using testshell.Models;

namespace testshell.ViewModels
{
    public class MyViewModel : ViewModelBase
    {
        //public ObservableRangeCollection<Coffee> Coffee { get; set; }
        //public ObservableRangeCollection<Grouping<string, Coffee>> CoffeeGroups { get; set; }
        public ObservableRangeCollection<Loan> Loan { get; set; }
        public ObservableRangeCollection<Grouping<string, Loan>> LoanGroups { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public MyViewModel()
        {
            Title = "Coffee list";


            //Coffee = new ObservableRangeCollection<Coffee>();
            //CoffeeGroups = new ObservableRangeCollection<Grouping<string, Coffee>>();

            Loan = new ObservableRangeCollection<Loan>();
            LoanGroups = new ObservableRangeCollection<Grouping<string, Loan>>();

            Loan.Add(new Loan { Id = ">", Name = "# Loan 1", Amount = "$1,000", Date = "2020/10/24" });
            Loan.Add(new Loan { Id = ">", Name = "# Loan 2", Amount = "$5,000", Date = "2020/10/26" });
            Loan.Add(new Loan { Id = ">", Name = "# Loan 3", Amount = "$10,000", Date = "2020/10/22" });
            Loan.Add(new Loan { Id = ">", Name = "# Loan 4", Amount = "$2,000", Date = "2020/10/01" });
            LoanGroups.Add(new Grouping<string, Loan>("Loan group 1", new[] { Loan[2] }));
            LoanGroups.Add(new Grouping<string, Loan>("Loan group 1", Loan.Take(2)));

            //var image = "https://www.yesplz.coffee/app/uploads/2020/11/emptybag-min.png";

            //Coffee.Add(new Coffee { Roaster = "Yes Plz", Name = "Sip of Sunshine", Image = image });
            //Coffee.Add(new Coffee { Roaster = "Yes Plz", Name = "Potent Potable", Image = image });
            //Coffee.Add(new Coffee { Roaster = "Blue Bottle", Name = "Kenya Kiambu Handege", Image = image });
            //Coffee.Add(new Coffee { Roaster = "Blue Bottle", Name = "Kenya Kiambu Handege", Image = image });
            //Coffee.Add(new Coffee { Roaster = "Blue Bottle", Name = "Kenya Kiambu Handege", Image = image });
            //Coffee.Add(new Coffee { Roaster = "Blue Bottle", Name = "Kenya Kiambu Handege", Image = image });
            //Coffee.Add(new Coffee { Roaster = "Blue Bottle", Name = "Kenya Kiambu Handege", Image = image });

            //CoffeeGroups.Add(new Grouping<string, Coffee>("Blue Bottle", new[] { Coffee[2] }));
            //CoffeeGroups.Add(new Grouping<string, Coffee>("Yes Plz", Coffee.Take(2)));

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
