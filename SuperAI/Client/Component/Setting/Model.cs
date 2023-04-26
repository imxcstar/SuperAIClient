using System.ComponentModel.DataAnnotations;

namespace SuperAI.Client.Component.Setting
{
    public class SettingInfo
    {
        [Required]
        public string URL { get; set; }

        [Required]
        [Range(0, 1)]
        public int Mode { get; set; }
    }

    public enum SettingMode
    {
        Chat,
        MudGame
    }
}
