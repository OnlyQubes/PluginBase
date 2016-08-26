using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginInterface
{
    public interface IBot
    {
        int version { get; set; }
        string data { get; set; }

        void DoAction();
        bool DoAnotherAction(string var1, int var2);
    }
}
