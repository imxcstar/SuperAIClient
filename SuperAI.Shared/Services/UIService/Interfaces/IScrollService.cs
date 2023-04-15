namespace SuperAI.Shared.Services.UIService
{
    public interface IScrollService
    {
        public ValueTask ScrollToElementBottomAsync(string id);
        public ValueTask SetupScrollListenerAsync(object element, object dotnetHelper);
        public ValueTask ScrollToBottomAsync(object element);
        public ValueTask ScrollToBottomAndWaitElementAsync(object element, string id);
    }
}
