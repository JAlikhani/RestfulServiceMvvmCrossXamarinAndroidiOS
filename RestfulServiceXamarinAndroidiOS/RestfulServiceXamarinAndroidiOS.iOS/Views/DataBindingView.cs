using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using System;
using System.Collections.Generic;
using UIKit;

namespace RestfulServiceXamarinAndroidiOS.iOS.Views
{
    public partial class DataBindingView : MvxTableViewController
    {

        public DataBindingView()
        {
            Title = "Main Options";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new TableSource(TableView);
            this.AddBindings(new Dictionary<object, string>
                {
                    {source, "ItemsSource MenuItems"}
                });

            TableView.Source = source;
            TableView.ReloadData();
        }

        public class TableSource : MvxStandardTableViewSource
        {
            private static readonly NSString Identifier = new NSString("MenuCellIdentifier");
            private const string BindingText = "TitleText Title;SelectedCommand GoCommand";

            public TableSource(UITableView tableView)
                : base(tableView, UITableViewCellStyle.Default, Identifier, BindingText)
            {
            }
        }
    }
}