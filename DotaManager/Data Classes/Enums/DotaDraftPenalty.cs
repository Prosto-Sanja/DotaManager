using System.ComponentModel;

namespace DotaManager.Data_Classes.Enums
{
    internal enum DotaDraftPenalty
    {
        [Description("None")]
        DotaPenaltyNone = 0,

        [Description("30 Sec Ban")]
        DotaPenalty30 = 1,

        [Description("70 Sec Ban")]
        DotaPenalty70 = 2,

        [Description("110 Sec Ban")]
        DotaPenalty110 = 3,
    }
}
