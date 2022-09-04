using MediaTool.Plugin.Core;

namespace MediaTool.Plugin.Template;

public class PluginBase : Plugin
{
    public override string Name { get; set; } = "My Plugin";
    public override string Description { get; set; } = "This is my new plugin.";
    public override string Author { get; set; } = "Me";
    
    public override void OnLoad()
    {
        Console.WriteLine($"{Name} has been loaded!");
    }

    public override void OnUnload()
    {
        Console.WriteLine($"{Name} has been unloaded!");
    }
}
