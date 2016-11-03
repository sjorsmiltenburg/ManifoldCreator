using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ManifoldCreator.UI
{
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
        { }

        public Brush PaintBrush { get; set; }
    }
}
