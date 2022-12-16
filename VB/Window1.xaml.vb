Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports DevExpress.Xpf.Grid

Namespace ColumnHeaderCustomizationArea

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

'#Region "#events"
        Private Sub TableView_ShowGridMenu(ByVal sender As Object, ByVal e As GridMenuEventArgs)
            ' Check whether this event was raised for a column's context menu.
            ' If not - exit and leave the menu shown.
            If e.MenuType <> GridMenuType.Column Then Return
            ' Check whether this event was raised for a custom button.
            ' If not - exit and hide the menu.
            If TryCast(e.TargetElement, Control).Tag Is Nothing Then
                e.Handled = True
                Return
            End If
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ' Show the context menu when a custom button is clicked.
            Me.view.GridMenu.ShowPopup(TryCast(sender, Button))
        End Sub

        Private Sub Button_PreviewMouseRightButtonUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            ' Don't show the context menu when a custom button is right-clicked.
            e.Handled = True
        End Sub
'#End Region  ' #events
    End Class
End Namespace
