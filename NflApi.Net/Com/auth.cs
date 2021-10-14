using Newtonsoft.Json;
using RestSharp;
using System;

namespace NFL.Com
{
    /// <summary>
    /// Authentication for NFL.com API. Refresh every hour.
    /// </summary>
    public class Auth
    {
        public int expiresIn { get; set; }
        public DateTime expiration { get; set; }
        public object refreshToken { get; set; }
        public string accessToken { get; set; }
        /// <summary>
        /// Creates an authentication token. Must pass through other requests.
        /// </summary>
        public static Auth GetAuth()
        {
            var client = new RestClient("https://www.nfl.com/oauth/nfl/token/client");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            var body = @"{""ClientType"":""WEB_DESKTOP_DESKTOP"",""DeviceId"":""218c5d3a-f0c7-4291-a50f-a65ef91f3ee7"",""DeviceInfo"":null,""NetworkType"":null,""UserAgent"":""Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/94.0.4606.71 Safari/537.36""}
" + "\n" +
            @"";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<Auth>(response.Content);
            ret.expiration = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(ret.expiresIn).ToLocalTime();
            return ret;
        }
    }
}
