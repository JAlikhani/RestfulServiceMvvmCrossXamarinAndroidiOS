using CoreGraphics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;

using UIKit;

namespace RestfulServiceXamarinAndroidiOS.iOS.Views
{
    public partial class RestfulServiceView : MvxViewController
    {

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<RestfulServiceView, RestfulServiceXamarinAndroidiOS.ViewModels.RestfulServiceViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);

            var Button = new UIButton(UIButtonType.RoundedRect);
            Button.Frame = new CGRect(10, 200, 300, 30);
            Add(Button);
            set.Bind(Button).To(vm => vm.MyCommand);
            set.Bind(Button).For("Title").To(vm => vm.ButtonTitle);
            /*set.Bind(Slider).To(vm => vm.Slider);
            set.Bind(TextField2).To(vm => vm.Slider);*/
            set.Apply();
        }
    }
}