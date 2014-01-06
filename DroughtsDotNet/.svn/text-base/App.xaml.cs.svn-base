using System.Windows;
using System.Windows.Threading;

namespace DroughtsDotNet {

    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application {
        private Bootstrapper _bootstrapper;

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            this._bootstrapper = new Bootstrapper();
            this._bootstrapper.Run();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {
        }
    }
}