using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DevExpress.Wpf.Grid;

namespace ColumnHeaderCustomizationArea {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        #region #events
        private void TableView_ShowGridMenu(object sender, GridMenuEventArgs e) {
            // Check whether this event was raised for a column's context menu.
            // If not - exit and leave the menu shown.
            if (e.MenuType != GridMenuType.Column) return;

            // Check whether this event was raised for a custom button.
            // If not - exit and hide the menu.
            if ((e.TargetElement as Control).Tag == null) {
                e.Handled = true;
                return;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            // Show the context menu when a custom button is clicked.
            view.GridMenu.ShowPopup(sender as Button);
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e) {
            // Don't show the context menu when a custom button is right-clicked.
            e.Handled = true;
        }
        #endregion #events
    }
}
