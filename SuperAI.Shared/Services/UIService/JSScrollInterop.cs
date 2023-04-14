using BlazorComponent.JSInterop;
using Microsoft.JSInterop;

namespace SuperAI.Shared.Services.UIService
{
    public class JSScrollInterop : JSModule, IScrollService
    {
        public JSScrollInterop(IJSRuntime js) : base(js, "./_content/SuperAI.Shared/js/scrollInterop.js")
        {
        }

        public async ValueTask ScrollToElementBottomAsync(string id)
        {
            await InvokeVoidAsync("scrollToElementBottom", id, 44);
        }
    }
}
