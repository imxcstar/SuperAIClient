using BlazorComponent.JSInterop;
using Microsoft.JSInterop;

namespace SuperAI.Shared.Services.UIService
{
    public class JSScrollInterop : JSModule, IScrollService
    {
        public JSScrollInterop(IJSRuntime js) : base(js, "./_content/SuperAI.Shared/js/scrollInterop.js")
        {
        }

        public async ValueTask ScrollToBottomAndWaitElementAsync(object element, string id)
        {
            await InvokeVoidAsync("scrollToBottomAndWaitElement", element, id, 44);
        }

        public async ValueTask ScrollToBottomAsync(object element)
        {
            await InvokeVoidAsync("scrollToBottom", element);
        }

        public async ValueTask ScrollToElementBottomAsync(string id)
        {
            await InvokeVoidAsync("scrollToElementBottom", id, 44);
        }

        public async ValueTask SetupScrollListenerAsync(object element, object dotnetHelper)
        {
            await InvokeVoidAsync("setupScrollListener", element, dotnetHelper);
        }
    }
}
