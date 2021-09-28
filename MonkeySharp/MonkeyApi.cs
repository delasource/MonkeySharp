using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using MonkeySharp.Apis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MonkeySharp
{
    public class MonkeyApi
    {
        public const string VERSION = "1.0.0";

        internal readonly HttpClient HttpClient;

        private readonly MonkeyApiConfig           _config;
        private readonly Random                    _random = new();
        private readonly AuthenticationHeaderValue _authenticationHeader;

        private string _firmaId;

        public Encoding Encoding { get; set; } = Encoding.UTF8;

        public FirmaApi          Firma          { get; }
        public VorgabenApi       Vorgaben       { get; }
        public ApiInformationApi ApiInformation { get; }


        public MonkeyApi(MonkeyApiConfig? config = null)
        {
            _config = config ?? new("http://127.0.0.1:8084/monkeyOfficeConnectJSON", "admin", "admin");

            _authenticationHeader = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_config.Username}:{_config.Password}")));
            _firmaId = _config.DefaultFirmaId ?? "";

            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Add("User-Agent",
                $"MonkeySharp/{VERSION} (DotNet/{Environment.Version}/{Environment.OSVersion})");

            Firma          = new FirmaApi(this);
            Vorgaben       = new VorgabenApi(this);
            ApiInformation = new ApiInformationApi(this);
        }

        public void SetFirmaId(string firmaId)
        {
            _firmaId = firmaId;
        }


        private async Task<HttpResponseMessage> DoRequestAsync(string command, object? parameter)
        {
            if (string.IsNullOrEmpty(_firmaId) && command is not "apisessionInfoGet" or "apiInfoGet" or "firmaList")
                throw new AuthenticationException("You need to set a 'FirmaID' in order to access this api.");

            string requestString =
                $"{{\"{command}\":{(parameter != null ? JsonConvert.SerializeObject(parameter) : "\"\"")}}}";

            var httpRequestMessage = new HttpRequestMessage
            {
                Method     = HttpMethod.Post,
                RequestUri = new Uri(_config.ApiUrl),
                Headers =
                {
                    { "mbl-ident", _firmaId }
                    // { HttpRequestHeader.Authorization.ToString(), "Bearer xxxxxxxxxxxxxxxxxxx" },
                    // { HttpRequestHeader.Accept.ToString(), "application/json" },
                },
                Content = new StringContent(requestString, Encoding,
                    "application/json") // TODO media-type is redundant?
            };

            httpRequestMessage.Headers.Authorization = _authenticationHeader;

            return await HttpClient.SendAsync(httpRequestMessage);
        }

        /// <summary>
        /// Command is usually lowerCamelCase
        /// parameter may be an object (to add or modify), or null
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameter"></param>
        /// <typeparam name="TResponse"></typeparam>
        /// <returns></returns>
        internal async Task<TResponse?> ApiCallSingleAsync<TResponse>(
            string  command,
            object? parameter = null)
            where TResponse : class
        {
            try
            {
                var    httpResponse          = await DoRequestAsync(command, parameter);
                string responseContentString = await httpResponse.Content.ReadAsStringAsync();

                string? returnDataContent = JToken.Parse(responseContentString)
                    .SelectToken($"{command}Response.ReturnData.*")
                    ?.ToString();

                return returnDataContent == null
                    ? null
                    : JsonConvert.DeserializeObject<TResponse>(returnDataContent);
            }
            catch (Exception ex)
            {
                // TODO Log error
                Console.WriteLine(ex);
                return null;
            }
        }

        /// <summary>
        /// Command is usually lowerCamelCase
        /// parameter may be an object (to add or modify), or null
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameter"></param>
        /// <typeparam name="TResponse"></typeparam>
        /// <returns></returns>
        internal async Task<IEnumerable<TResponse>?> ApiCallEnumerableAsync<TResponse>(
            string  command,
            object? parameter = null)
            where TResponse : class
        {
            try
            {
                var    httpResponse          = await DoRequestAsync(command, parameter);
                string responseContentString = await httpResponse.Content.ReadAsStringAsync();

                string? array = JToken.Parse(responseContentString)
                    .SelectToken($"{command}Response.ReturnData.*", false)
                    ?.ToString();

                return array == null
                    ? null
                    : JsonConvert.DeserializeObject<IEnumerable<TResponse>>(array);
            }
            catch (Exception ex)
            {
                // TODO Log error
                Console.WriteLine(ex);
                return null;
            }
        }
        /*
        /// <summary>
        /// Command is usually lowerCamelCase
        /// parameter may be an object (to add or modify), or null
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameter"></param>
        /// <typeparam name="TResponse"></typeparam>
        /// <returns></returns>
        internal async Task<MonkeySharpResponse<TResponse>> InternalCallApiSingleAsync<TResponse>(
            string  command,
            object? parameter = null)
            where TResponse : class
        {
            string responseContentString = "";
            try
            {
                var httpResponse = await DoRequestAsync(command, parameter);
                responseContentString = await httpResponse.Content.ReadAsStringAsync();
                var x = JsonSerializer.Deserialize<CatchallResponseWrapper>(responseContentString, _serializeOptions);

                // Successfull ?
                if (x?.Data == null)
                    return new MonkeySharpResponse<TResponse>(null);

                var responseItem = x.Data.FirstOrDefault()
                    .Value
                    .GetProperty("ReturnData")
                    .GetProperty(typeof(TResponse).Name);

                return new MonkeySharpResponse<TResponse>(
                    JsonSerializer.Deserialize<TResponse>(responseItem.GetRawText()));
            }
            catch (KeyNotFoundException)
            {
                return new MonkeySharpResponse<TResponse>(responseContentString);
            }
            catch (Exception ex)
            {
                return new MonkeySharpResponse<TResponse>(ex);
            }
        }

        /// <summary>
        /// Command is usually lowerCamelCase
        /// parameter may be an object (to add or modify), or null
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameter"></param>
        /// <typeparam name="TResponse"></typeparam>
        /// <returns></returns>
        internal async Task<MonkeySharpResponse<IEnumerable<TResponse>>> InternalCallApiArrayAsync<TResponse>(
            string  command,
            object? parameter = null)
            where TResponse : class
        {
            string responseContentString = "";
            try
            {
                var httpResponse = await DoRequestAsync(command, parameter);
                responseContentString = await httpResponse.Content.ReadAsStringAsync();
                var x = JsonSerializer.Deserialize<CatchallResponseWrapper>(responseContentString, _serializeOptions);

                // Successfull ?
                if (x?.Data == null)
                    return new MonkeySharpResponse<IEnumerable<TResponse>>(null);

                var responseItem = x.Data.FirstOrDefault()
                    .Value
                    .GetProperty("ReturnData")
                    .GetProperty(typeof(TResponse).Name);

                return new MonkeySharpResponse<IEnumerable<TResponse>>(
                    JsonSerializer.Deserialize<IEnumerable<TResponse>>(responseItem.GetRawText()));
            }
            catch (KeyNotFoundException)
            {
                return new MonkeySharpResponse<IEnumerable<TResponse>>(responseContentString);
            }
            catch (Exception ex)
            {
                return new MonkeySharpResponse<IEnumerable<TResponse>>(ex);
            }
        }*/
    }
}
