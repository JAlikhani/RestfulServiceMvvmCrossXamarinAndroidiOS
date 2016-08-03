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
    public class DataBindingViewModel : MvxViewModel
    {
        public Action func;

        public DataBindingViewModel()
        {
            MenuItems = new List<MenuItem>
                {
                    new MenuItem("Restful Service", this, GoNextPage),
                    new MenuItem("Data Binding", this, GoNextPage),
                };
        }

        public List<MenuItem> MenuItems { get; private set; }

        public class MenuItem
        {
            public MenuItem(string title, DataBindingViewModel parent, Action command)
            {
                Title = title;
                GoCommand = new MvxCommand(command);
            }

            public string Title { get; private set; }
            public ICommand GoCommand { get; private set; }
        }

        private void GoNextPage()
        {
            ShowViewModel<RestfulServiceViewModel>();
        }
    }
}
