using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW2_Menu.Menu
{
    public class MenuItemStylable : MenuItemBase
    {
        public int? Style { get; internal set; }
        public bool? Decoration { get; internal set; }
        public RectangleF? ForeColor { get; internal set; }
        public RectangleF? FocusColor { get; internal set; }
    }
}
