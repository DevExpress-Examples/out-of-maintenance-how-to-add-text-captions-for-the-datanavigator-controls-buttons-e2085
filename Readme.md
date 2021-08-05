<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to add text captions for the DataNavigator control's buttons


<p>The current DataNavigator control does not allow the display of texts on its buttons. We do have plans to implement this functionality in the future (see the <br />
 <a href="https://supportcenter.devexpress.com/ticket/details/cs59753/add-text-caption-property-and-shortcut-key-property-for-built-in-and-custom-buttons-of">Add Text (Caption) Property and Shortcut Key Property for Built-In and Custom Buttons of the DataNavigator Control</a> suggestion). </p><p>At this moment, you can use the following workaround. Generate images containing necessary texts dynamically and assign them using the DataNavigator's ImageList property. This example demonstrates how this solution can be implemented.</p>

<br/>


