using SuperAI.Client.Services.StorageService;
using SuperAI.Client.Component.ChatMsgList;
using SuperAI.Client.Component.HistoryMsgList;
using System.Threading.Tasks;

namespace SuperAI.Client.Component.MainView
{
    public class ChatInfo
    {
        private readonly IStorageService _storageService;

        public List<HistoryMsgItem> HistoryMsgItem { get; set; } = new List<HistoryMsgItem>();
        public Dictionary<string, List<ChatMsgItem>> ChatMsgItem { get; set; } = new Dictionary<string, List<ChatMsgItem>>();
        public string SelectHistoryMsgId { get; set; } = "";
        public string OpenAIApiKey { get; set; } = "";

        public ChatInfo()
        {
        }

        public ChatInfo(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public async Task LoadAsync()
        {
            try
            {
                var tmp = await _storageService.GetAsync<ChatInfo>("chatInfo") ?? new ChatInfo();
                HistoryMsgItem = tmp.HistoryMsgItem;
                ChatMsgItem = tmp.ChatMsgItem;
                SelectHistoryMsgId = tmp.SelectHistoryMsgId;
                OpenAIApiKey = tmp.OpenAIApiKey;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task SaveAsync()
        {
            await _storageService.SetAsync("chatInfo", this);
        }

        public HistoryMsgItem AddHistoryMsg(string title)
        {
            var ret = new HistoryMsgItem()
            {
                Id = Guid.NewGuid().ToString(),
                Title = title
            };
            HistoryMsgItem.Insert(0, ret);
            return ret;
        }
    }
}
