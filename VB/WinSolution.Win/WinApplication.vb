Imports Microsoft.VisualBasic
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports System
Imports DevExpress.ExpressApp.Win
Imports System.Collections.Generic

Namespace WinSolution.Win
	Partial Public Class WinSolutionWindowsFormsApplication
		Inherits WinApplication
		Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
			args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
		End Sub
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub WinSolutionWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			e.Updater.Update()
			e.Handled = True
		End Sub
	End Class
End Namespace
