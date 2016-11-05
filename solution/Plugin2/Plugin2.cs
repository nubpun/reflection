using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Plugin2
{
    class Plugin2 : Framework.IPlugin
    {

        private string name = "Plugin2";
        
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
