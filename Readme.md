<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128587445/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E466)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# XAF - Add Custom Buttons (Actions) to Lookup and Popup Windows

This example adds a new **Action In Popup** button to popup/lookup windows. Click on this button invokes a custom [Action](https://docs.devexpress.com/eXpressAppFramework/112622/ui-construction/controllers-and-actions/actions) (display a sample message box). 

To display a custom button, create a new [ViewController](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController) with a [Simple Action](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.SimpleAction) and set its [`Category`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.Category) property to `PopupActions`.


Refer to the following topic for more information: [Add Actions to a Pop-up Window](https://docs.devexpress.com/eXpressAppFramework/112804/ui-construction/controllers-and-actions/add-actions-to-a-popup-window).

![image](https://user-images.githubusercontent.com/14300209/225921128-c14fc411-d304-4cb8-9d47-2080f2d1ec86.png)

## Files to Review

* [PopupListViewController.cs](./CS/EFCore/PopupActionEF/PopupActionEF.Module/Controllers/PopupListViewController.cs)

## Documentation

* [How to: Reorder an Action Container's Actions Collection](https://docs.devexpress.com/eXpressAppFramework/112815/ui-construction/controllers-and-actions/actions/how-to-reorder-an-action-containers-actions-collection)
* [How to: Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/402145/ui-construction/controllers-and-actions/actions/how-to-place-an-action-in-a-different-location)
* [Action Containers](https://docs.devexpress.com/eXpressAppFramework/112610/ui-construction/action-containers)
* [Actions](https://docs.devexpress.com/eXpressAppFramework/112622/ui-construction/controllers-and-actions/actions)

## More Examples

* [XAF Blazor - Implement a custom Action type](https://github.com/DevExpress-Examples/xaf-custom-action-type-blazor)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF_how-to-add-custom-buttons-actions-to-the-lookup-and-popup-windows&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF_how-to-add-custom-buttons-actions-to-the-lookup-and-popup-windows&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
