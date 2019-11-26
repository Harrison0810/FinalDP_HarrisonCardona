using MvvmCross.IoC;
using MvvmCross.ViewModels;
using QuadraticEquiations.Core.ViewModels;

namespace QuadraticEquiations.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<EquiationViewModel>();
        }
    }
}
