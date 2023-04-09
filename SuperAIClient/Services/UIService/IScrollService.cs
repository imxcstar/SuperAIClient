namespace SuperAIClient.Services.UIService
{
    public interface IScrollService
    {
        public ValueTask ScrollToElementBottomAsync(string id);
    }
}
