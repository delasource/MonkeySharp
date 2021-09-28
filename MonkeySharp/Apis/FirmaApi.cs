using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeySharp.Domain.Firmen;

namespace MonkeySharp.Apis
{
    public class FirmaApi
    {
        private readonly MonkeyApi _api;

        internal FirmaApi(MonkeyApi api)
        {
            _api = api;
        }

        /// <summary>
        /// Get informations about the current selected Firma.
        /// Remember to set a FirmaID
        /// </summary>
        /// <returns></returns>
        public async Task<FirmaItem?> FirmaGetAsync()
        {
            return await _api.ApiCallSingleAsync<FirmaItem>("firmaGet");
        }

        /// <summary>
        /// Gets a list of all Firmen
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<FirmaListItem>?> FirmaListAsync()
        {
            return await _api.ApiCallEnumerableAsync<FirmaListItem>("firmaList");
        }
    }
}
