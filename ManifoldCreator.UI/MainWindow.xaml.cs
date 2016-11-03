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

namespace ManifoldCreator.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 8; i++)
            {
                MainGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(50) });
            }
            for (int i = 0; i < 8; i++)
            {
                MainGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(50) });
            }

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    var newCell = new Cell() { DataContext = new CellViewModel(x, y) };
                    Grid.SetRow(newCell, y);
                    Grid.SetColumn(newCell, x);
                    MainGrid.Children.Add(newCell);
                }
            }         
        }
    }

    public class BrushHelper
    {
        private static BrushHelper _instance;
        public static BrushHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BrushHelper();
                }
                return _instance;
            }
        }

        private BrushHelper()
        {}

        public Brush PaintBrush { get; set; }
    }
}
