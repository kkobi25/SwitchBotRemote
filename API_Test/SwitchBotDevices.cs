using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwitchBot.API;

namespace SwitchBot.Devices
{

    public enum ACModes : int
    {
        Auto = 1,
        Cool = 2,
        Dry = 3,
        Fan = 4,
        Heat = 5
    }

    public enum FanSpeeds : int
    {
        Auto = 1,
        Low = 2,
        Medium = 3,
        High = 4
    }
    [JsonObject]
    public class Device
    {
        [JsonProperty("deviceId")]
        public string DeviceID { get; private set; }
        [JsonProperty("deviceName")]
        public string DeviceName { get; private set; }

        [JsonProperty("hubDeviceId")]
        public string HubDeviceId { get; private set; }

        protected SwitchBotAPI API = null;

        public Device()
        {

        }

        public Device(Device _device)
        {
            if (_device == null)
                return;

            this.DeviceID = _device.DeviceID;
            this.DeviceName = _device.DeviceName;
            this.HubDeviceId = _device.HubDeviceId;
            this.API = _device.API;
        }

        public void SetAPI(SwitchBotAPI _api)
        {
            if (_api != null)
                this.API = _api;
        }

        public virtual async Task<APIResponse> TurnOnAsync()
        {
            var response = await this.SendDefinedCommandAsync("turnOn");
            return response;
        }

        public virtual async Task<APIResponse> TurnOffAsync()
        {
            var response = await this.SendDefinedCommandAsync("turnOff");
            return response;
        }

        public async Task<APIResponse> SendDefinedCommandAsync(string command, string parameter = "default")
        {
            if (this.API == null)
                return null;
            var response = await this.API.SendControlCommandAsync(this, command, parameter);
            return response;
        }

        public async Task<APIResponse> SendCustomCommandAsync(string command, string parameter = "default", string commandType = "customize")
        {
            if (this.API == null)
                return null;

            var response = await this.API.SendControlCommandAsync(this, command, parameter, commandType);
            return response;
        }

        public override string ToString()
        {
            string msg = string.Format("DeviceID:{0},DeviceName:{1},HubDeviceID:{2}",
                this.DeviceID,
                this.DeviceName,
                this.HubDeviceId);
            return msg;
        }
    }

    [JsonObject]
    public class PhysicalDevice : Device
    {
        [JsonProperty("deviceType")]
        public string DeviceType { get; private set; }

        [JsonProperty("enableCloudService")]
        public bool EnableCloudService { get; private set; }

        // Properties for curtain devices are skipped.

        public PhysicalDevice()
        {

        }

        public PhysicalDevice(Device _device)
            : base(_device)
        {
            PhysicalDevice pd = _device as PhysicalDevice;
            if (pd != null)
            {
                this.DeviceType = pd.DeviceType;
                this.EnableCloudService = pd.EnableCloudService;
            }
        }
    }

    [JsonObject]
    public class InfraredRemoteDevice : Device
    {
        [JsonProperty("remoteType")]
        public string RemoteType { get; private set; }

        public InfraredRemoteDevice()
        {

        }

        public InfraredRemoteDevice(Device _device)
            : base(_device)
        {
            InfraredRemoteDevice ird = _device as InfraredRemoteDevice;
            if (ird != null)
            {
                this.RemoteType = ird.RemoteType;
            }
        }
    }

    public class SoundDevices : InfraredRemoteDevice
    {
        public SoundDevices()
        {

        }

        public SoundDevices(Device _device)
            : base(_device)
        {

        }

        public async Task<APIResponse> VolumeUpAsync()
        {
            var response = await this.SendDefinedCommandAsync("volumeAdd");
            return response;
        }

        public async Task<APIResponse> VolumeDownAsync()
        {
            var response = await this.SendDefinedCommandAsync("volumeSub");
            return response;
        }       
    }

    public class SonyTV : SoundDevices
    {
        public SonyTV()
        {

        }

        public SonyTV(Device _device)
            : base(_device)
        {

        }
        public async Task<APIResponse> SetChannelAsync(int channel)
        {
            if (channel > 0 && channel <= 12)
            {
                var response = await this.SendDefinedCommandAsync("SetChannel", channel.ToString());
                return response;
            }
            else
            {
                return null;
            }
        }

        public async Task<APIResponse> NextChannelAsync()
        {
            var response = await this.SendDefinedCommandAsync("channelAdd");
            return response;
        }

        public async Task<APIResponse> PreviousChannelAsync()
        {
            var response = await this.SendDefinedCommandAsync("channelSub");
            return response;
        }

        public async Task<APIResponse> BackAsync()
        {
            var response = await this.SendDefinedCommandAsync("back");
            return response;
        }

        //Custom buttons
        public async Task<APIResponse> ShowChannelListAsync()
        {
            var response = await this.SendCustomCommandAsync("番組表", "default", "customize");
            return response;
        }

        public async Task<APIResponse> ChangeToDigitalAsync()
        {
            var response = await this.SendCustomCommandAsync("デジタル", "default", "customize");
            return response;
        }

        public async Task<APIResponse> ChangeToBSAsync()
        {
            var response = await this.SendCustomCommandAsync("BS", "default", "customize");
            return response;
        }

        public async Task<APIResponse> ChangeToCSAsync()
        {
            var response = await this.SendCustomCommandAsync("CS", "default", "customize");
            return response;
        }

        public async Task<APIResponse> Show10KeyAsync()
        {
            var response = await this.SendCustomCommandAsync("10キー", "default", "customize");
            return response;
        }
    }

    public class SonySpeaker : SoundDevices
    {
        public SonySpeaker()
        {

        }

        public SonySpeaker(Device _device)
            : base(_device)
        {

        }

        public async Task<APIResponse> ChangeInputAsync()
        {
            var response = await this.SendCustomCommandAsync("入力切替", "default", "customize");
            return response;
        }

        public async Task<APIResponse> VerticalSoundToggleAsync()
        {
            var response = await this.SendCustomCommandAsync("VERTICAL S.", "default", "customize");
            return response;
        }

        public async Task<APIResponse> CinemaAsync()
        {
            var response = await this.SendCustomCommandAsync("シネマ", "default", "customize");
            return response;
        }

        public async Task<APIResponse> AutoSoundAsync()
        {
            var response = await this.SendCustomCommandAsync("オートサウンド", "default", "customize");
            return response;
        }

        public async Task<APIResponse> BassAsync()
        {
            var response = await this.SendCustomCommandAsync("低音", "default", "customize");
            return response;
        }

        public async Task<APIResponse> NewsAsync()
        {
            var response = await this.SendCustomCommandAsync("ニュース", "default", "customize");
            return response;
        }
    }

    public class Light : InfraredRemoteDevice
    {
        public Light()
        {

        }

        public Light(Device _device)
            : base(_device)
        {

        }

        public async Task<APIResponse> BrightnessUpAsync()
        {
            var response = await this.SendDefinedCommandAsync("brightnessUp");
            return response;
        }

        public async Task<APIResponse> BrightnessDownAsync()
        {
            var response = await this.SendDefinedCommandAsync("brightnessDown");
            return response;
        }

        public async Task<APIResponse> TurnNightLightOnAsync()
        {
            var response = await this.SendCustomCommandAsync("常夜灯", "default", "customize");
            return response;
        }

        public async Task<APIResponse> EnergySavingModeAsync()
        {
            var response = await this.SendCustomCommandAsync("省エネ", "default", "customize");
            return response;
        }
    }

    public class AirConditioner : InfraredRemoteDevice
    {
        public int Temperature { get; private set; }
        public ACModes Mode { get; private set; }
        public FanSpeeds FanSpeed { get; private set; }
        public bool IsOn { get; private set; }
        public AirConditioner()
        {

        }

        public AirConditioner(Device _device)
            : base(_device)
        {
            // Set default states
            this.Temperature = 20;
            this.Mode = ACModes.Cool;
            this.FanSpeed = FanSpeeds.Auto;
            this.IsOn = false;
        }

        public AirConditioner(Device _device, int temperature, ACModes mode, FanSpeeds speed, bool isOn)
            : base(_device)
        {
            this.Temperature = temperature;
            this.Mode = mode;
            this.FanSpeed = speed;
            this.IsOn = isOn;
        }

        public async Task<APIResponse> SetAllAsync(int temperature, ACModes mode, FanSpeeds speed, bool turnOn)
        {
            string parameter = string.Format("{0},{1:d},{2:d},{3}",
                temperature,
                mode,
                speed,
                (turnOn) ? "on" : "off");
            var response = await this.SendDefinedCommandAsync("setAll", parameter);

            if (response.StatusCode == (int)StatusCode.Success)
            {
                this.Temperature = temperature;
                this.Mode = mode;
                this.FanSpeed = speed;
                this.IsOn = turnOn;
            }
            return response;
        }

        public async Task<APIResponse> TemperatureUpAsync()
        {
            string parameter = string.Format("{0},{1:d},{2:d},{3}",
                (this.Temperature < 32) ? this.Temperature + 1 : 32,
                this.Mode,
                this.FanSpeed,
                (this.IsOn) ? "on" : "off");

            var response = await this.SendDefinedCommandAsync("setAll", parameter);

            if (response.StatusCode == (int)StatusCode.Success && this.Temperature < 32)
            {
                this.Temperature++;
            }
            return response;
        }

        public async Task<APIResponse> TemperatureDownAsync()
        {
            string parameter = string.Format("{0},{1:d},{2:d},{3}",
                (this.Temperature > 18) ? this.Temperature - 1 : 18,
                this, Mode,
                this, FanSpeed,
                (this.IsOn) ? "on" : "off");

            var response = await this.SendDefinedCommandAsync("setAll", parameter);

            if (response.StatusCode == (int)StatusCode.Success && this.Temperature > 18)
            {
                this.Temperature--;
            }
            return response;
        }

        public override async Task<APIResponse> TurnOnAsync()
        {
            var response = await SetAllAsync(this.Temperature, this.Mode, this.FanSpeed, true);
            return response;
        }

        public override async Task<APIResponse> TurnOffAsync()
        {
            var response = await SetAllAsync(this.Temperature, this.Mode, this.FanSpeed, false);
            return response;
        }
    }
    
    [JsonObject]
    public class DeviceList
    {
        [JsonProperty("deviceList")]
        public List<PhysicalDevice> PhysicalDeviceList { get; private set; } // a list of physical devices

        [JsonProperty("infraredRemoteList")]
        public List<InfraredRemoteDevice> InfraredRemoteList { get; private set; }// a list of virtual infrared remote devices

        public DeviceList()
        {
            this.PhysicalDeviceList = new List<PhysicalDevice>();
            this.InfraredRemoteList = new List<InfraredRemoteDevice>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PhysicalDeviceList{");
            foreach(var dev in this.PhysicalDeviceList)
            {
                sb.AppendLine(dev.ToString());
            }
            sb.Append("}");
            sb.AppendLine("InfraredRemoteList{");
            foreach(var dev in this.InfraredRemoteList)
            {
                sb.AppendLine(dev.ToString());
            }
            sb.Append("}");
            return sb.ToString();
        }
    }
}
