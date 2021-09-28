namespace MonkeySharp.Domain.ApiInfo
{
    public record ApiInfoItem(
        string App_Name,
        string App_Homepage,
        string App_Email,
        int    App_MajorVersion,
        int    App_MinorVersion,
        int    App_BugVersion,
        int    App_Build,
        string App_APISchemaVersion,
        string App_CopyRight,
        bool   App_NewVersion
    );
}
