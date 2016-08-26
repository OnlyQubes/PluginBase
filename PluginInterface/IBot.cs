using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginInterface
{
    /*
        This should be implemented by the
        main application and should contain
        all values that should be exposed to
        the plugins. Once the plugins are loaded
        the main class passes it self as this interface.
    */

    public interface IBot
    {
        int version { get; set; }
        string data { get; set; }

        void DoAction();
        bool DoAnotherAction(string var1, int var2);
    }
}
