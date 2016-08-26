using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterface;

namespace TestPlugin
{
    public class TestPluginClass : IPlugin
    {
        private IBot mainClass;

        public string GetName()
        {
            return "Test plugin";
        }

        public string GetAuthor()
        {
            return "John";
        }

        public int GetVersion()
        {
            return 1;
        }

        public void OnLoaded(IBot mainClass)
        {
            this.mainClass = mainClass;

            //Call some test functions.
            mainClass.DoAction();
            this.mainClass.DoAnotherAction("Test plugin doing actions!", GetVersion());
        }
    }
}
