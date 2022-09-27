using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsKitchen.Menu
{
    public class ElementMenu
    { 
        public string Name { get; set; }
        public int time { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }
}
