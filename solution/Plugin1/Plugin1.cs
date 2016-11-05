using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin1
{
    class Plugin1 : Framework.IPlugin
    {
        private string name = "Plugin1";
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
