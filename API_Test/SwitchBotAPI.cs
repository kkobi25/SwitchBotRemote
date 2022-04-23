using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using SwitchBot.Devices;
using Newtonsoft.Json;


namespace SwitchBot.API
{
    public enum StatusCode : int
    {
        Success = 100,
        SystemError = 190
    }

    [JsonObject]
    public class APIResponse
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; private set; }

        [JsonProperty("message")]
        public string Message { get; private set; }

        [JsonProperty("body")]
        public object Body { get; private set; }

        public bool ParseBodyToDeviceList(SwitchBotAPI _api)
        {
            DeviceList deviceList = null;
            try
            {
                deviceList = JsonConvert.DeserializeObject<DeviceList>(this.Body.ToString());
            }
            catch
            {
                this.Body = null;
                return false;
            }
            foreach (var dev in deviceList.PhysicalDeviceList)
                dev.SetAPI(_api);
            foreach (var dev in deviceList.InfraredRemoteList)
                dev.SetAPI(_api);
            this.Body = deviceList;
            return true;
        }

        public override string ToString()
        {
            string msg = string.Format("StatusCode:{0},Message:{1},Body:{2}",
                this.StatusCode,
                this.Message,
                this.Body);
            return msg;
        }

    }

    public class SwitchBotAPI:IDisposable
    {
        private readonly string BaseUri = "https://api.switch-bot.com/v1.0/devices";
        private HttpClient _httpClient = null;
        private bool disposedValue;

        public readonly string AuthToken;

        public SwitchBotAPI(string token)
        {
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30.0);
            AuthToken = token;
        }
        public async Task<APIResponse> CheckStatusAsync()
        {
            string strResponse;
            using (var request = new HttpRequestMessage(new HttpMethod("GET"), BaseUri))
            {
                if (!request.Headers.TryAddWithoutValidation("Authorization", AuthToken))
                    return null;

                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead))
                {
                    strResponse = await response.Content.ReadAsStringAsync();
                }
            }
            try
            {
                APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(strResponse);
                if (!apiResponse.ParseBodyToDeviceList(this))
                    return null;

                return apiResponse;
            }
            catch
            {
                return null;
            }            
        }

        public async Task<APIResponse> SendControlCommandAsync(Device device, string command, 
            string parameter = "default",
            string commandType = "command")
        {
            string strResponse;
            using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"{BaseUri}/{device.DeviceID}/commands"))
            {
                // Header (authorization)
                if (!request.Headers.TryAddWithoutValidation("Authorization", AuthToken))
                    return null;

                // data (command)
                string content = "{\"command\":\"" + command + "\"," +
                    "\"parameter\":\"" + parameter + "\"," +
                    "\"commandType\":\"" + commandType + "\"}";
                request.Content = new StringContent(content, System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead))
                {
                    strResponse = await response.Content.ReadAsStringAsync();
                }
            }
            try
            {
                APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(strResponse);
                return apiResponse;
            }
            catch
            {
                return null;
            }            
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _httpClient.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
