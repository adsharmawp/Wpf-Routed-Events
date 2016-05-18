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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfRoutedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox.Text += "Window Preview Mouse Down" + Environment.NewLine;
        }

        private void GridPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox.Text += "Grid Preview Mouse Down" + Environment.NewLine;
        }

        private void SPPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox.Text += "Stack Preview Mouse Down" + Environment.NewLine;
        }

        private void WindowMouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox.Text += "Window Mouse Down" + Environment.NewLine;
        }

        private void GridMouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox.Text += "Grid Mouse Down" + Environment.NewLine;
        }

        private void StackPanelMouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox.Text += "Stack Panel Mouse Down" + Environment.NewLine;
        }
    }
}
