using MonkeySharp.Domain.Artikel;

namespace MonkeySharp.Domain.Vorgaben
{
    public record VerkaufpreislisteListItem(string               VKPreisliste_ID,
                                            string               Bezeichnung,
                                            string               Beschreibung,
                                            bool                 Standard,
                                            ArtikelkalkbasisEnum BerechnungArt,
                                            ArtikelkalkmargeEnum MargeArt);
}