using System;
using Newtonsoft.Json;

namespace MonkeySharp.Domain.Firmen
{
    public record FirmaItem
    {
        [JsonProperty("Firma_Name")]
        public string? FirmaName { get; set; }

        [JsonProperty("Firma_Zusatz")]
        public string? FirmaZusatz { get; set; }

        [JsonProperty("Firma_Geschaeftsfuehrer")]
        public string? FirmaGeschaeftsfuehrer { get; set; }

        [JsonProperty("Firma_Strasse")]
        public string? FirmaStrasse { get; set; }

        [JsonProperty("Firma_Plz")]
        public string? FirmaPlz { get; set; }

        [JsonProperty("Firma_Ort")]
        public string? FirmaOrt { get; set; }

        [JsonProperty("Firma_Telefon")]
        public string? FirmaTelefon { get; set; }

        [JsonProperty("Firma_Telefax")]
        public string? FirmaTelefax { get; set; }

        [JsonProperty("Firma_Email")]
        public string? FirmaEmail { get; set; }

        [JsonProperty("Firma_Internet")]
        public string? FirmaInternet { get; set; }

        [JsonProperty("Firma_RegisterGericht")]
        public string? FirmaRegisterGericht { get; set; }

        [JsonProperty("Firma_RegisterNummer")]
        public string? FirmaRegisterNummer { get; set; }

        [JsonProperty("Firma_BankKonto")]
        public string? FirmaBankKonto { get; set; }

        [JsonProperty("Firma_BankBlz")]
        public string? FirmaBankBlz { get; set; }

        [JsonProperty("Firma_BankIBAN")]
        public string? FirmaBankIBAN { get; set; }

        [JsonProperty("Firma_BankBIC")]
        public string? FirmaBankBIC { get; set; }

        [JsonProperty("Firma_BankName")]
        public string? FirmaBankName { get; set; }

        [JsonProperty("Firma_UStPflicht")]
        public bool FirmaUStPflicht { get; set; }

        [JsonProperty("Firma_UStIDNummer")]
        public string? FirmaUStIDNummer { get; set; }

        [JsonProperty("Firma_Kontenplan")]
        public string? FirmaKontenplan { get; set; }

        [JsonProperty("Firma_GEArt")]
        public int FirmaGEArt { get; set; }

        [JsonProperty("Firma_FALand")]
        public string? FirmaFALand { get; set; }

        [JsonProperty("Firma_FANummer")]
        public string? FirmaFANummer { get; set; }

        [JsonProperty("Firma_FAName")]
        public string? FirmaFAName { get; set; }

        [JsonProperty("Firma_FAZusatz")]
        public string? FirmaFAZusatz { get; set; }

        [JsonProperty("Firma_FAStrasse")]
        public string? FirmaFAStrasse { get; set; }

        [JsonProperty("Firma_FAPlz")]
        public string? FirmaFAPlz { get; set; }

        [JsonProperty("Firma_FAOrt")]
        public string? FirmaFAOrt { get; set; }

        [JsonProperty("Firma_FABundesland")]
        public string? FirmaFABundesland { get; set; }

        [JsonProperty("Firma_FAStNrPrefix")]
        public string? FirmaFAStNrPrefix { get; set; }

        [JsonProperty("Firma_FASteuernummer")]
        public string? FirmaFASteuernummer { get; set; }

        [JsonProperty("Firma_FAStNrPostfix")]
        public string? FirmaFAStNrPostfix { get; set; }

        [JsonProperty("Firma_FATelefon")]
        public string? FirmaFATelefon { get; set; }

        [JsonProperty("Firma_FATelefax")]
        public string? FirmaFATelefax { get; set; }

        [JsonProperty("Firma_FABankKonto")]
        public string? FirmaFABankKonto { get; set; }

        [JsonProperty("Firma_FABankBlz")]
        public string? FirmaFABankBlz { get; set; }

        [JsonProperty("Firma_FABankName")]
        public string? FirmaFABankName { get; set; }

        [JsonProperty("Firma_FAMemo")]
        public string? FirmaFAMemo { get; set; }

        [JsonProperty("Firma_SBName")]
        public string? FirmaSBName { get; set; }

        [JsonProperty("Firma_SBZusatz")]
        public string? FirmaSBZusatz { get; set; }

        [JsonProperty("Firma_SBStrasse")]
        public string? FirmaSBStrasse { get; set; }

        [JsonProperty("Firma_SBPlz")]
        public string? FirmaSBPlz { get; set; }

        [JsonProperty("Firma_SBOrt")]
        public string? FirmaSBOrt { get; set; }

        [JsonProperty("Firma_SBTelefon")]
        public string? FirmaSBTelefon { get; set; }

        [JsonProperty("Firma_SBTelefax")]
        public string? FirmaSBTelefax { get; set; }

        [JsonProperty("Firma_SBEmail")]
        public string? FirmaSBEmail { get; set; }

        [JsonProperty("Firma_SBBankKonto")]
        public string? FirmaSBBankKonto { get; set; }

        [JsonProperty("Firma_SBBankBlz")]
        public string? FirmaSBBankBlz { get; set; }

        [JsonProperty("Firma_SBBankName")]
        public string? FirmaSBBankName { get; set; }

        [JsonProperty("Firma_SBMemo")]
        public string? FirmaSBMemo { get; set; }

        [JsonProperty("Firma_FALandLSt")]
        public string? FirmaFALandLSt { get; set; }

        [JsonProperty("Firma_FANummerLSt")]
        public string? FirmaFANummerLSt { get; set; }

        [JsonProperty("Firma_FANameLSt")]
        public string? FirmaFANameLSt { get; set; }

        [JsonProperty("Firma_FAZusatzLSt")]
        public string? FirmaFAZusatzLSt { get; set; }

        [JsonProperty("Firma_FAStrasseLSt")]
        public string? FirmaFAStrasseLSt { get; set; }

        [JsonProperty("Firma_FAPlzLSt")]
        public string? FirmaFAPlzLSt { get; set; }

        [JsonProperty("Firma_FAOrtLSt")]
        public string? FirmaFAOrtLSt { get; set; }

        [JsonProperty("Firma_FABundeslandLSt")]
        public string? FirmaFABundeslandLSt { get; set; }

        [JsonProperty("Firma_FAStNrPrefixLSt")]
        public string? FirmaFAStNrPrefixLSt { get; set; }

        [JsonProperty("Firma_FASteuernummerLSt")]
        public string? FirmaFASteuernummerLSt { get; set; }

        [JsonProperty("Firma_FAStNrPostfixLSt")]
        public string? FirmaFAStNrPostfixLSt { get; set; }

        [JsonProperty("Firma_FATelefonLSt")]
        public string? FirmaFATelefonLSt { get; set; }

        [JsonProperty("Firma_FATelefaxLSt")]
        public string? FirmaFATelefaxLSt { get; set; }

        [JsonProperty("Firma_FABankKontoLSt")]
        public string? FirmaFABankKontoLSt { get; set; }

        [JsonProperty("Firma_FABankBlzLSt")]
        public string? FirmaFABankBlzLSt { get; set; }

        [JsonProperty("Firma_FABankNameLSt")]
        public string? FirmaFABankNameLSt { get; set; }

        [JsonProperty("Firma_FAMemoLSt")]
        public string? FirmaFAMemoLSt { get; set; }

        [JsonProperty("Firma_LGName")]
        public string? FirmaLGName { get; set; }

        [JsonProperty("Firma_LGZusatz")]
        public string? FirmaLGZusatz { get; set; }

        [JsonProperty("Firma_LGVerwalter")]
        public string? FirmaLGVerwalter { get; set; }

        [JsonProperty("Firma_LGStrasse")]
        public string? FirmaLGStrasse { get; set; }

        [JsonProperty("Firma_LGPlz")]
        public string? FirmaLGPlz { get; set; }

        [JsonProperty("Firma_LGOrt")]
        public string? FirmaLGOrt { get; set; }

        [JsonProperty("Firma_LGTelefon")]
        public string? FirmaLGTelefon { get; set; }

        [JsonProperty("Firma_LGTelefax")]
        public string? FirmaLGTelefax { get; set; }

        [JsonProperty("Firma_LGEmail")]
        public string? FirmaLGEmail { get; set; }

        [JsonProperty("DatumVon")]
        public DateTime? DatumVon { get; set; }

        [JsonProperty("DatumBis")]
        public DateTime? DatumBis { get; set; }
    }
}
