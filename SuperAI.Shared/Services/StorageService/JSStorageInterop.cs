using BlazorComponent.JSInterop;
using Microsoft.JSInterop;
using System.Text.Json;

namespace SuperAI.Shared.Services.StorageService
{
    public class JSStorageInterop : JSModule, IStorageService
    {
        public JSStorageInterop(IJSRuntime js) : base(js, "./_content/SuperAI.Shared/js/storageInterop.js")
        {
        }

        public async ValueTask ClearAsync()
        {
            await InvokeVoidAsync("clear");
        }

        public async ValueTask<T?> GetAsync<T>(string key)
        {
            var ret = await InvokeAsync<string>("getItem", key);
            return string.IsNullOrWhiteSpace(ret) ? default : JsonSerializer.Deserialize<T>(ret);
        }

        public async ValueTask RemoveAsync(string key)
        {
            await InvokeVoidAsync("removeItem", key);
        }

        public async ValueTask SetAsync<T>(string key, T value)
        {
            await InvokeVoidAsync("setItem", key, JsonSerializer.Serialize(value));
        }
    }
}
