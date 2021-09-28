namespace MonkeySharp.Domain.Vorgaben
{
    public record ZahlungsBedingungEinkaufListItem(string          Bezeichnung,
                                                   ZahlungsartEnum Zahlungsart,
                                                   int             TageNetto,
                                                   int             TageSkonto,
                                                   float           ProzentSkonto);
}
