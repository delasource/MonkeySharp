using System.Threading.Tasks;
using MonkeySharp.Domain.ApiInfo;

namespace MonkeySharp.Apis
{
    public class ApiInformationApi
    {
        private readonly MonkeyApi _api;

        internal ApiInformationApi(MonkeyApi api)
        {
            _api = api;
        }

        public async Task<ApiInfoItem?> ApiInfoGetAsync()
        {
            return await _api.ApiCallSingleAsync<ApiInfoItem>("apiInfoGet");
        }

        public async Task<ApisessionInfoItem?> ApiInfoGetSessionAsync()
        {
            return await _api.ApiCallSingleAsync<ApisessionInfoItem>("apisessionInfoGet");
        }
    }
}
