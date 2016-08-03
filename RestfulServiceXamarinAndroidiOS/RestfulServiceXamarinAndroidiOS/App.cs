using MvvmCross.Platform.IoC;

namespace RestfulServiceXamarinAndroidiOS
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //RegisterAppStart<ViewModels.RestfulServiceViewModel>();
            RegisterAppStart<ViewModels.DataBindingViewModel>();


        }
    }
}
