using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using PluginInterface;
using System.Linq;

namespace PluginBase
{
    public static class PluginLoader
    {
        /// <summary>
        /// The location where the
        /// plugin files should be stored
        /// for them to be loaded.
        /// </summary>
        public static string pluginLocation = AppDomain.CurrentDomain.BaseDirectory + "plugins\\";

        /// <summary>
        /// Loads the plugins.
        /// </summary>
        /// <param name="botManager"></param>
        /// <returns></returns>
        public static List<IPlugin> LoadPlugins(BotManager botManager)
        {
            //Get all plugins in the directory.
            string[] allPluginPaths = Directory.GetFiles(pluginLocation);
            List<IPlugin> loadedPlugins = new List<IPlugin>();

            //Load each plugin.
            for (int i = 0; i < allPluginPaths.Length; i++)
            {
                //Load the dll.
                Assembly tempAssembly = Assembly.LoadFrom(allPluginPaths[i]);

                //Check each class inside of 
                //the dll.
                foreach (Type type in tempAssembly.GetExportedTypes())
                {
                    //Check if the type mathces to
                    //our plugin type.
                    if (!type.GetInterfaces().Contains(typeof(IPlugin)))
                        continue;

                    //Convert it to our plugin type.
                    IPlugin pluginInstance = Activator.CreateInstance(type) as IPlugin;
                    loadedPlugins.Add(pluginInstance);
                    pluginInstance.OnLoaded(botManager);
                }
            }

            return loadedPlugins;
        }
    }
}