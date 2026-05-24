using MediaBrowser.Common.Plugins;

namespace Jellyfin.Plugin.YouTubeSearch;

public class Plugin : BasePlugin
{
    public override string Name => "YouTube Search";

    public override Guid Id => Guid.Parse("d0fa0c61-4af4-4f18-aab6-4a0f7f7e0d01");
}
