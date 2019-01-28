using System.ComponentModel;

namespace CarRent.Services
{
    public enum ServiceResultStatus
    {
        [Description("Błąd")]
        Error = 0,

        [Description("Sukces")]
        Success = 1,

        [Description("Ostrzeżenie")]
        Warning = 2,

        [Description("Informacja")]
        Information = 3,

    }
}