using System.ComponentModel;
using Padoru.API.Features.Plugins;
using Padoru.API.Structs;

namespace report2
{
    public sealed class Config : IConfig
    {
        [Description("Включён ли плагин или нет")]
        public bool IsEnabled { get; set; } = true;
    }
}