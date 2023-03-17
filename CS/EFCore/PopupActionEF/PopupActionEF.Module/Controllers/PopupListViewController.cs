using DevExpress.ExpressApp;
using DevExpress.XtraEditors;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.BaseImpl;
using PopupAction.Module.BusinessObjects;

namespace PopupAction.Module {
    public class ShowPopupController : ViewController {
        public ShowPopupController() {
            PopupWindowShowAction showPopupAction = new PopupWindowShowAction(
                this,
                "ShowPopup",
                DevExpress.Persistent.Base.PredefinedCategory.View
            );
            showPopupAction.CustomizePopupWindowParams += this.showPopupAction_CustomizePopupWindowParams;
        }
        private void showPopupAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
            e.View = Application.CreateListView(e.Application.CreateObjectSpace(typeof(Contact)), typeof(Contact), false);
        }
    }
    public class ActionInPopupController : ViewController {
        public ActionInPopupController() {
            SimpleAction actionInPopup = new SimpleAction(this,
                "ActionInPopup",
                DevExpress.Persistent.Base.PredefinedCategory.PopupActions
            );
            //Refer to the https://docs.devexpress.com/eXpressAppFramework/112815 help article to see how to reorder Actions within the PopupActions container.
            actionInPopup.Execute += actionInPopup_Execute;
        }
        void actionInPopup_Execute(object sender, SimpleActionExecuteEventArgs e) {
            Application.ShowViewStrategy.ShowMessage(string.Format("Hello {0}!", e.CurrentObject));
        }
    }
}
