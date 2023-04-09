using BlazorComponent.JSInterop;
using Microsoft.JSInterop;
using SuperAIClient.Services.UIService;

namespace SuperAIClient.Interop
{
    public class JSScrollInterop : JSModule, IScrollService
    {
        public JSScrollInterop(IJSRuntime js) : base(js, "./js/scrollInterop.js")
        {
        }

        public async ValueTask ScrollToElementBottomAsync(string id)
        {
            await InvokeVoidAsync("scrollToElementBottom", id, 44);
        }
    }
}
