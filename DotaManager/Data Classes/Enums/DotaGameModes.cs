using System.ComponentModel;

namespace DotaManager.Data_Classes.Enums
{
    internal enum DotaGameModes
    {
        [Description("None")]
        DotaGamemodeNone = 0,

        [Description("All Pick")]
        DotaGamemodeAp = 1,

        [Description("Captains Mode")]
        DotaGamemodeCm = 2,

        [Description("Random Draft")]
        DotaGamemodeRd = 3,

        [Description("Single Draft")]
        DotaGamemodeSd = 4,

        [Description("All Random")]
        DotaGamemodeAr = 5,

        [Description("Intro")]
        DotaGamemodeIntro = 6,

        [Description("Least Played")]
        DotaGamemodeLp = 12,

        [Description("Limited Heroes")]
        DotaGamemodePool1 = 13,

        [Description("Custom")]
        DotaGamemodeCustom = 15,

        [Description("Captains Draft")]
        DotaGamemodeCd = 16,

        [Description("Ability Draft")]
        DotaGamemodeAbilityDraft = 18,

        [Description("All Random DM")]
        DotaGamemodeArdm = 20,

        [Description("1v1 Mid")]
        DotaGamemode1V1Mid = 21,

        [Description("All Draft")]
        DotaGamemodeAllDraft = 22
    }
}
