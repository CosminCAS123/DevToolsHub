using Microsoft.JSInterop;


namespace DevToolsHub.Services;

public class ClipboardService
{
    private readonly IJSRuntime _js;

    public ClipboardService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task CopyToClipboard(string text)
    {
        await _js.InvokeVoidAsync("navigator.clipboard.writeText", text);
    }
}
