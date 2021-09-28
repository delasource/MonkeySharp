namespace MonkeySharp.Domain.Vorgaben
{
    public record NummernkreisListItem(NummernkreisIdentsEnum NKIdent,
                                       string                 Gruppe,
                                       string                 Bereich,
                                       string                 Aktuell,
                                       string                 Nachfolger);
}