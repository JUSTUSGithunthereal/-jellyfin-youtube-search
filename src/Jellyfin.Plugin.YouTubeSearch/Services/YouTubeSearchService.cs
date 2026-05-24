namespace Jellyfin.Plugin.YouTubeSearch.Services;

public class YouTubeSearchService
{
    public Task<List<string>> SearchAsync(string query)
    {
        return Task.FromResult(new List<string>
        {
            $"YouTube Result: {query}"
        });
    }
}
