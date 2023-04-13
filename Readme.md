<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128587445/22.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E466)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# XAF - How to add custom buttons ( Actions ) to the lookup and popup windows

You can show custom buttons ([Actions](https://docs.devexpress.com/eXpressAppFramework/112622/ui-construction/controllers-and-actions/actions)) near the **New**, **Clear**, **OK**, and **Cancel** buttons in lookup and popup List Views. For this purpose, create a new View Controller with a [Simple Action](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.SimpleAction) and set its [`Category`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.Category) property to `PopupActions`.

This example adds a new **Action In Popup** Action to popup/lookup List Views. When a user clicks this Action, the application displays a sample message box.

Refer to the following topic for more information: [Add Actions to a Pop-up Window](https://docs.devexpress.com/eXpressAppFramework/112804/ui-construction/controllers-and-actions/add-actions-to-a-popup-window).

![image](https://user-images.githubusercontent.com/14300209/225921128-c14fc411-d304-4cb8-9d47-2080f2d1ec86.png)

## Files to Review

* [PopupListViewController.cs](./CS/EFCore/PopupActionEF/PopupActionEF.Module/Controllers/PopupListViewController.cs)

## Documentation

* [How to: Reorder an Action Container's Actions Collection](https://docs.devexpress.com/eXpressAppFramework/112815/ui-construction/controllers-and-actions/actions/how-to-reorder-an-action-containers-actions-collection)
* [How to: Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/402145/ui-construction/controllers-and-actions/actions/how-to-place-an-action-in-a-different-location)
* [Action Containers](https://docs.devexpress.com/eXpressAppFramework/112610/ui-construction/action-containers)

## More Examples

* [XAF Blazor - Implement a custom Action type](https://github.com/DevExpress-Examples/xaf-custom-action-type-blazor)
