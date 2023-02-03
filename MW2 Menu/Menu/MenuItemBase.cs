using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW2_Menu.Menu
{
    public class MenuItemBase
    {
        public List<string> Includes { get; private set; } = new List<string>();
        public List<string> Defines { get; private set; } = new List<string>();
    }
}
