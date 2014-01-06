using System.Windows;
using BehrendtHoeting.Patterns.Mvvm;
using Microsoft.Practices.Unity;

namespace DroughtsDotNet {

    public class Bootstrapper : UnityBootstrapper {

        protected override System.Windows.DependencyObject CreateShell() {
            return this.Container.Resolve<MainWindow>();
        }

        protected override void InitializeMainWindow() {
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer() {
            base.ConfigureContainer();
            this.Container.RegisterType<object, object>();
        }
    }
}