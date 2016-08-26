using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterface;

namespace PluginBase
{
    class Program
    {
        static void Main(string[] args)
        {
            BotManager bot = new BotManager();
            List<IPlugin> loadedPlugins = PluginLoader.LoadPlugins(bot);

            Console.WriteLine($"Loaded {loadedPlugins.Count} plugins");
            Console.ReadLine();
        }
    }
}
