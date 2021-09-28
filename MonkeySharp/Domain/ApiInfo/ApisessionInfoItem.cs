namespace MonkeySharp.Domain.ApiInfo
{
    public record ApisessionInfoItem(
        string         App_Datenbank,
        string         App_DBSchemaVersion,
        string         Firma_ID,
        string         Benutzer_ID,
        string         User_Name,
        UserAccessItem UserAccessItemList // Ab Version 17.2
    );
}