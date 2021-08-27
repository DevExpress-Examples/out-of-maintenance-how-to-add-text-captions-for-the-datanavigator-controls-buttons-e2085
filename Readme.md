<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128618898/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2085)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to add text captions for the DataNavigator control's buttons


<p>The current DataNavigator control does not allow the display of texts on its buttons. We do have plans to implement this functionality in the future (see the <br />
 <a href="https://supportcenter.devexpress.com/ticket/details/cs59753/add-text-caption-property-and-shortcut-key-property-for-built-in-and-custom-buttons-of">Add Text (Caption) Property and Shortcut Key Property for Built-In and Custom Buttons of the DataNavigator Control</a> suggestion). </p><p>At this moment, you can use the following workaround. Generate images containing necessary texts dynamically and assign them using the DataNavigator's ImageList property. This example demonstrates how this solution can be implemented.</p>

<br/>


