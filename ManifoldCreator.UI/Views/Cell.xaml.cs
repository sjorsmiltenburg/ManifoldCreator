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
    /// Interaction logic for Cell.xaml
    /// </summary>
    public partial class Cell : UserControl
    {
        Brush DefaultBrush = Brushes.Blue;
        Brush State1Brush = Brushes.Black;
        Brush State2Brush = Brushes.White;

        List<Polygon> Polygons { get; set; } = new List<Polygon>();

        public int X { get; set; }
        public int Y { get; set; }

        public CellState GetCellState()
        {
            return new CellState
            {
                TopLeft = GetCellState(TopLeft),
                TopRight = GetCellState(TopRight),
                RightTop = GetCellState(RightTop),
                RightBottom = GetCellState(RightBottom),
                BottomRight = GetCellState(BottomRight),
                BottomLeft = GetCellState(BottomLeft),
                LeftBottom = GetCellState(LeftBottom),
                LeftTop = GetCellState(LeftTop)
            };
        }

        private PolygonState GetCellState(Polygon polygon)
        {
            if (polygon.Fill == DefaultBrush)
            {
                return PolygonState.Default;
            }
            else if (polygon.Fill == State1Brush)
            {
                return PolygonState.Black;
            }
            else //if (polygon.Fill == State2Brush)
            {
                return PolygonState.White;
            }
        }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            InitializeComponent();

            Polygons.Add(TopLeft);
            Polygons.Add(TopRight);
            Polygons.Add(RightTop);
            Polygons.Add(RightBottom);
            Polygons.Add(BottomRight);
            Polygons.Add(BottomLeft);
            Polygons.Add(LeftBottom);
            Polygons.Add(LeftTop);

            foreach (var polygon in Polygons)
            {
                SubscribeEvents(polygon);
            }
        }

        private void SubscribeEvents(Polygon polygon)
        {
            polygon.Stroke = Brushes.Black;
            polygon.StrokeThickness = 1;
            polygon.Fill = DefaultBrush;
            polygon.MouseEnter += Polygon_MouseEnter;
            polygon.MouseDown += Polygon_MouseDown;
        }

        private void Polygon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var polygon = sender as Polygon;
            //if (polygon.Fill == DefaultBrush)
            //{
            //    BrushHelper.Instance.PaintBrush = State1Brush;
            //}
            //else if (polygon.Fill == State1Brush)
            //{
            //    BrushHelper.Instance.PaintBrush = State2Brush;
            //}
            //else if (polygon.Fill == State2Brush)
            //{
            //    BrushHelper.Instance.PaintBrush = DefaultBrush;
            //}
            polygon.Fill = BrushHelper.Instance.PaintBrush;
        }

        private void Polygon_MouseEnter(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var polygon = sender as Polygon;
                polygon.Fill = BrushHelper.Instance.PaintBrush;
            }
        }

    }

}
