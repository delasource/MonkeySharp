using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeySharp.Domain.Vorgaben;

namespace MonkeySharp.Apis
{
    public class VorgabenApi
    {
        private readonly MonkeyApi _api;

        internal VorgabenApi(MonkeyApi api)
        {
            _api = api;
        }

        public async Task<IEnumerable<KostenstelleListItem>?> KostenstellenListAsync()
        {
            return await _api.ApiCallEnumerableAsync<KostenstelleListItem>("kostenstellenList");
        }

        public async Task<IEnumerable<NummernkreisListItem>?> NummernkreisListAsync()
        {
            return await _api.ApiCallEnumerableAsync<NummernkreisListItem>("nummernkreisList");
        }

        public async Task<IEnumerable<ZahlungsBedingungVerkaufListItem>?> ZahlungsbedingungVerkaufListAsync()
        {
            return await _api.ApiCallEnumerableAsync<ZahlungsBedingungVerkaufListItem>("zahlungsbedingungVerkaufList");
        }

        public async Task<IEnumerable<SteuersatzListItem>?> SteuersatzListAsync()
        {
            return await _api.ApiCallEnumerableAsync<SteuersatzListItem>("steuersatzList");
        }

        public async Task<IEnumerable<WaehrungListItem>?> WaehrungListAsync()
        {
            return await _api.ApiCallEnumerableAsync<WaehrungListItem>("WaehrungList");
        }

        public async Task<IEnumerable<VerkaufpreislisteListItem>?> PreislisteVerkaufListAsync()
        {
            return await _api.ApiCallEnumerableAsync<VerkaufpreislisteListItem>("preislisteVerkaufList");
        }

        public async Task<IEnumerable<ZahlungsBedingungEinkaufListItem>?> ZahlungsbedingungEinkaufListAsync()
        {
            return await _api.ApiCallEnumerableAsync<ZahlungsBedingungEinkaufListItem>("zahlungsbedingungEinkaufList");
        }

        public async Task<DruckFormularFilter?> DruckformularFilterTemplateListAsync()
        {
            return await _api.ApiCallSingleAsync<DruckFormularFilter>("druckformularFilterTemplate");
        }

        public async Task<IEnumerable<DruckFormularListItem>?> DruckformularListAsync(
            DruckFormularFilter? filter = null)
        {
            return await _api.ApiCallEnumerableAsync<DruckFormularListItem>("druckformularList",
                filter != null ? new { DruckFormularFilter = filter } : null);
        }
    }
}
