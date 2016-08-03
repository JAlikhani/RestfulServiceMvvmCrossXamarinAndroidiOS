using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using Android.Support.V4.Widget;
using Android.Support.V4.View;

namespace RestfulServiceXamarinAndroidiOS.Droid.Views
{
    [Activity(Label = "RestfulServiceView")]
    public class RestfulServiceView : MvxActivity
    {
        public DrawerLayout DrawerLayout { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RestfulServiceView);
        }

    }
}