using System;
using PluginInterface;

namespace PluginBase
{
    public class BotManager : IBot
    {
        public int version { get; set; } = 5;
        public string data { get; set; } = "this is some info.";
        public string hiddenDataFromPlugin = "account_password";

        public void DoAction()
        {
            Console.WriteLine("Doing action!");
        }

        public bool DoAnotherAction(string var1, int var2)
        {
            Console.WriteLine(var2 + "\t |" + var1);
            return true;
        }
    }
}