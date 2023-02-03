using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MW2_Menu.Menu.EventHandler;
using MW2_Menu.Menu.Item.EventHandler;

namespace MW2_Menu.Menu
{
    public class menuDef : MenuItemStylable
    {
        #region Properties
        public string? Name { get; internal set; }
        public bool? Fullscreen { get; internal set; }
        public Rectangle? Rect { get; internal set; }
        public string? SoundLoop { get; internal set; }
        public int? fadeCycle { get; internal set; }
        public int? fadeClamp { get; internal set; }
        public float? fadeAmount { get; internal set; }
        public List<itemDef> ItemDefs { get; internal set; } = new List<itemDef>();
        #endregion
        #region EventHandlers
        public onOpen? onOpen { get; internal set; }
        public onClose? onClose { get; internal set; }
        public onEsc? onEsc { get; internal set; }
        #endregion
    }
}
