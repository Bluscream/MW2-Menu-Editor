using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW2_Menu.Menu.Item.EventHandler;

namespace MW2_Menu.Menu
{
    public class itemDef : MenuItemBase
    {
        #region Properties
        public string? Visible { get; internal set; }
        public string? Disabled { get; internal set; }
        public RectangleF? BackColor { get; internal set; }
        public string? Background { get; internal set; }
        public exp? Exp { get; internal set; }
        public int? TextFont { get; internal set; }
        public int? TextAlign { get; internal set; }
        public int? TextAlignX { get; internal set; }
        public int? TextAlignY { get; internal set; }
        public float? TextScale { get; internal set; }
        #endregion
        #region EventHandlers
        public onFocus? onFocus { get; internal set; }
        public leaveFocus? leaveFocus { get; internal set; }
        public action? action { get; internal set; }
        #endregion
    }
}
