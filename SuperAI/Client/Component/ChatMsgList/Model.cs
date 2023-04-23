namespace SuperAI.Client.Component.ChatMsgList
{
    public class ChatMsgItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string HeadIconURL { get; set; }
        public ChatUserType UserType { get; set; }
        public ChatContentType ContentType { get; set; }
    }

    public enum ChatUserType
    {
        Sender,
        Receiver
    }

    public enum ChatContentType
    {
        Text,
        Video,
        Audio,
        Image
    }
}
