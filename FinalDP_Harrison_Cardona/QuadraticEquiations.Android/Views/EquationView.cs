using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using QuadraticEquiations.Core.ViewModels;

namespace QuadraticEquiations.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class EquationView : MvxActivity<EquiationViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.EquationPage);
        }
    }
}