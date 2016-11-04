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

namespace ManifoldCreator.UI.Views
{
    /// <summary>
    /// Interaction logic for PaintMenu.xaml
    /// </summary>
    public partial class PaintMenu : UserControl
    {
        public PaintMenu()
        {
            InitializeComponent();
        }

        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            BrushHelper.Instance.PaintBrush = Brushes.Blue;
        }

        private void BlackButton_Click(object sender, RoutedEventArgs e)
        {
            BrushHelper.Instance.PaintBrush = Brushes.Black;
        }

        private void WhiteButton_Click(object sender, RoutedEventArgs e)
        {
            BrushHelper.Instance.PaintBrush = Brushes.White;
        }
    }
}
