using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using MonkeySharp.Domain.Firmen;

namespace MonkeySharp.Example
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            // Setup
            var config = JsonSerializer.Deserialize<MonkeyApiConfig>(await File.ReadAllTextAsync("appsettings.json"));
            var monkeyApi = new MonkeyApi(config);

            Console.WriteLine("Api Info: " + await monkeyApi.ApiInformation.ApiInfoGetAsync());

            Console.WriteLine("Alle Firmen: ");
            foreach (var fli in await monkeyApi.Firma.FirmaListAsync() ?? new List<FirmaListItem>())
                Console.WriteLine($"> {fli.Firma_ID}: {fli.Bezeichnung}");

            var firma = await monkeyApi.Firma.FirmaGetAsync();
            Console.WriteLine("Aktuelle Firma: " + firma);

            foreach (var fli in (await monkeyApi.Vorgaben.ZahlungsbedingungVerkaufListAsync())!)
                Console.WriteLine($"{fli}");

            foreach (var druckFormularListItem in (await monkeyApi.Vorgaben.DruckformularListAsync())!)
                Console.WriteLine(druckFormularListItem);


            // End
            Console.ReadLine();
        }
    }
}
