namespace SuperAI.Shared.Services.StorageService
{
    public interface IStorageService
    {
        public ValueTask SetAsync<T>(string key, T value);
        public ValueTask<T?> GetAsync<T>(string key);
        public ValueTask RemoveAsync(string key);
        public ValueTask ClearAsync();
    }
}
