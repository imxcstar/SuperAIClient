using BlazorComponent.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SuperAI.Client.Services.StorageService;
using System.Text.Json;

namespace SuperAI.Client.Services.InteropService
{
    public class JSEventInterop : JSModule, IJSEventInterop
    {
        public JSEventInterop(IJSRuntime js) : base(js, "./js/interop/eventInterop.js")
        {
        }

        public async ValueTask HandleCompositionStart(ElementReference element, object dotNetHelper)
        {
            await InvokeVoidAsync("handleCompositionStart", element, dotNetHelper);
        }

        public async ValueTask handleCompositionEnd(ElementReference element, object dotNetHelper)
        {
            await InvokeVoidAsync("handleCompositionEnd", element, dotNetHelper);
        }
    }
}
