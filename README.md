# PluginBase

A simple plugin loader that exposes specific values and methods to the plugin, but still keeps everything else hidden.

Main application should implement IBot.
Plugins should implement IPlugin.


This is compatible with obfuscators. 
Tested on main class and interface obfuscation, leaving plugin unobfuscated and obfuscated.
