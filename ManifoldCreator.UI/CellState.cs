using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManifoldCreator.UI
{
    public class CellState
    {
        public PolygonState TopLeft { get; set; }
        public PolygonState TopRight { get; set; }
        public PolygonState RightTop { get; set; }
        public PolygonState RightBottom { get; set; }
        public PolygonState BottomRight { get; set; }
        public PolygonState BottomLeft { get; set; }
        public PolygonState LeftBottom { get; set; }
        public PolygonState LeftTop { get; set; }

        public FoldLineState Top { get; set; }
        public FoldLineState Right { get; set; }
        public FoldLineState Bottom { get; set; }
        public FoldLineState Left { get; set; }
        public FoldLineState TopLeftBottomRight { get; set; }
        public FoldLineState TopRightBottomLeft { get; set; }
    }
}
