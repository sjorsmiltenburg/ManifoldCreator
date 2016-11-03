using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ManifoldCreator.UI
{
    public class CellViewModel
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Brush TopLeft { get; set; } = Brushes.Blue;

        public CellViewModel(int x, int y)
        {  
            X = X;
            Y = Y;
        }        
    }

    public class CellState
    {
        bool TopLeft { get; set; }
        bool TopRight { get; set; }
        bool RightTop { get; set; }
        bool RightBottom { get; set; }        
        bool BottomRight { get; set; }
        bool BottomLeft { get; set; }
        bool LeftBottom { get; set; }
        bool LeftTop { get; set; }

        FoldLineState Top { get; set; }
        FoldLineState Right { get; set; }
        FoldLineState Bottom { get; set; }
        FoldLineState Left { get; set; }
        FoldLineState TopLeftBottomRight { get; set; }
        FoldLineState TopRightBottomLeft { get; set; }
    }

    public enum FoldLineState
    {
        None,
        Inwards,
        Outwards
    }
}
