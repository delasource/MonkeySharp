namespace MonkeySharp.Domain.ApiInfo
{
    public record UserAccessItem(
        string Modul_ID,
        string ModulName,
        bool   Zugriff,
        bool   Anlegen,
        bool   Aendern,
        bool   Loeschen
    );
}