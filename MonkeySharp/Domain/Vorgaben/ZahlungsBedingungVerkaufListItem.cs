namespace MonkeySharp.Domain.Vorgaben
{
    public record ZahlungsBedingungVerkaufListItem(string          Bezeichnung,
                                                   ZahlungsartEnum Zahlungsart,
                                                   int             TageNetto,
                                                   int             TageSkonto,
                                                   float           ProzentSkonto,
                                                   bool            NichtMahnen);
}
