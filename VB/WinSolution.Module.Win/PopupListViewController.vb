Imports DevExpress.ExpressApp
Imports DevExpress.XtraEditors
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.BaseImpl

Namespace WinSolution.Module.Win

    Public Class ShowPopupController
        Inherits ViewController

        Public Sub New()
            Dim showPopupAction As PopupWindowShowAction = New PopupWindowShowAction(Me, "ShowPopup", DevExpress.Persistent.Base.PredefinedCategory.View)
            AddHandler showPopupAction.CustomizePopupWindowParams, AddressOf showPopupAction_CustomizePopupWindowParams
        End Sub

        Private Sub showPopupAction_CustomizePopupWindowParams(ByVal sender As Object, ByVal e As CustomizePopupWindowParamsEventArgs)
            e.View = Application.CreateListView(e.Application.CreateObjectSpace(), GetType(Person), False)
        End Sub
    End Class

    Public Class ActionInPopupController
        Inherits ViewController

        Public Sub New()
            Dim actionInPopup As SimpleAction = New SimpleAction(Me, "ActionInPopup", DevExpress.Persistent.Base.PredefinedCategory.PopupActions)
            'Dennis: Refer to the http://documentation.devexpress.com/#Xaf/CustomDocument2815 help article to see how to reorder Actions within the PopupActions container.
            AddHandler actionInPopup.Execute, AddressOf actionInPopup_Execute
        End Sub

        Private Sub actionInPopup_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs)
            XtraMessageBox.Show(String.Format("Hello {0}!", e.CurrentObject))
        End Sub
    End Class
End Namespace
