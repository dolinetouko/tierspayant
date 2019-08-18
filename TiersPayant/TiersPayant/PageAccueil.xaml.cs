using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TiersPayant
{
    /// <summary>
    /// Logique d'interaction pour PageAccueil.xaml
    /// </summary>
    public partial class PageAccueil : Window
    {
        public PageAccueil()
        {
            InitializeComponent();
        }

       /* private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed; 
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }*/
        /*private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }*/
        private void Logout(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
        private void listViewMenu_SelectionChange(object sender, RoutedEventArgs e)
        {
            int index = listViewMenu.SelectedIndex;
           // MoveCursorMenu(index);

            switch(index){

                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControl2());
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControl1());
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControl4());
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControl3());
                    break;
                default:
                    break;
        }

        }
        /*private void MoveCursorMenu(int index)
        {
            transitionigContentSlice.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, 0, 0, (224 + (60 * index)));

        }*/

        
    }
}
