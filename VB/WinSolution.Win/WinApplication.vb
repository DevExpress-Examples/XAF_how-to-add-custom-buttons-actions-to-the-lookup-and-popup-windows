Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.Win

Namespace WinSolution.Win

    Public Partial Class WinSolutionWindowsFormsApplication
        Inherits WinApplication

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub WinSolutionWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DatabaseVersionMismatchEventArgs)
            e.Updater.Update()
            e.Handled = True
        End Sub
    End Class
End Namespace
