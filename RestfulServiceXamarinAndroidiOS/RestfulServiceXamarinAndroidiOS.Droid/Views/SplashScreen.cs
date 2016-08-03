using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace RestfulServiceXamarinAndroidiOS.Droid
{
    [Activity(
        Label = "RestfulServiceXamarinAndroidiOS.Droid"
        , MainLauncher = true
        //commented by me, Icon = "Drawable/Icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
