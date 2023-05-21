using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace SuperAIClient.ViewModels;

public class MessageViewModel:ViewModelBase
{
    public string Id { get; set; }
    public string Name { get; set; }

    public string Content { get; set; } = @"
如果要禁用整个应用程序的剪裁功能，可以在项目文件（.csproj）中设置 `PublishTrimmed` 为 `false`。 启用/禁用剪裁功能示例：

```xml
<PropertyGroup>
  <PublishTrimmed>false</PublishTrimmed>
</PropertyGroup>
```
";

    //public IImage HeadIconURL { get; set; } = new Bitmap("../Assets/receiver.png");
    public ChatUserType UserType { get; set; } = ChatUserType.Receiver;
    public ChatContentType ContentType { get; set; }
    public Color Background { get; set; } =Color.Parse("#e3e1db");
    public string Orientation { get; set; } = "Left";
    public string OrientationInt { get; set; } = "1";
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