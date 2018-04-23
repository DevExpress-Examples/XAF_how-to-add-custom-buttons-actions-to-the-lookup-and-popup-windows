using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using System;
using DevExpress.ExpressApp.Win;
using System.Collections.Generic;

namespace WinSolution.Win {
    public partial class WinSolutionWindowsFormsApplication : WinApplication {
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection);
        }
        public WinSolutionWindowsFormsApplication() {
            InitializeComponent();
        }

        private void WinSolutionWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
        }
    }
}
