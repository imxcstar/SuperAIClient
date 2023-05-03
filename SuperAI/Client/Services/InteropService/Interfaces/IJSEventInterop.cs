using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace SuperAI.Client.Services.InteropService
{
    public interface IJSEventInterop
    {
        public ValueTask HandleCompositionStart(ElementReference element, object dotNetHelper);

        public ValueTask handleCompositionEnd(ElementReference element, object dotNetHelper);
    }
}
