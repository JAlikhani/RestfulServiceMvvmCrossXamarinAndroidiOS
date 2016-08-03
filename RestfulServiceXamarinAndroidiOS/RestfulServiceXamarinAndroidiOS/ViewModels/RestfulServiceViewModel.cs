using MvvmCross.Core.ViewModels;
using RestfulServiceXamarinAndroidiOS.Model;
using RestfulServiceXamarinAndroidiOS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RestfulServiceXamarinAndroidiOS.ViewModels
{
    public class RestfulServiceViewModel : MvxViewModel
    {
        private string _hello = "Try Data Binding!";

        public string Hello
        {
            get { return _hello; }
            set { SetProperty(ref _hello, value); }
        }

        public string ButtonTitle => "Author of 'In Search of Lost Time? (Try Restful Service)";

        private MvxCommand _myCommand;
        public ICommand MyCommand
        {
            get
            {
                _myCommand = _myCommand ?? new MvxCommand(RestfulService);
                return _myCommand;
            }
        }

        private async void RestfulService()
        {
            Hello = "Please wait...";
            string url = "http://floating-fjord-16663.herokuapp.com/";
            Books books = await WebService.GetURL<Books>(url, "GET", "application/json");
            Hello = books.book[0].author;
        }
    }
}
