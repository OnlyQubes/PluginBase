namespace PluginInterface
{
    /*
        This should be implemented
        only by the plugins.
    */

    public interface IPlugin
    {
        string GetName();
        string GetAuthor();
        int GetVersion();

        void OnLoaded(IBot mainClass);
    }
}