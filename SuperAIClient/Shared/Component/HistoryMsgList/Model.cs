namespace SuperAIClient.Shared.Component.HistoryMsgList
{
    public class HistoryMsgItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.UtcNow;
    }
}
