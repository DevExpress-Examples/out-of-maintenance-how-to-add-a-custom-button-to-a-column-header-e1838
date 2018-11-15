<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to add a custom button to a column header


<p>The following example demonstrates how to modify a column header in a grid's Table View. In this sample, it is illustrated how to add a button with an icon to a column header's customization area.</p>


<h3>Description</h3>

<p>For this, it is necessary to define a <strong>DataTemplate</strong>, which represents a button, and assign it to the <strong>TableView.ColumnHeaderCustomizationAreaTemplate</strong> property. This template specifies a button and some of its properties. For example, it invokes the standard context menu on clicking this button (but disables invoking this menu when either the column header or the custom button within it are clicked).</p>

<br/>


