using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SwitchBot.API;
using SwitchBot.Devices;
using Newtonsoft.Json;

namespace SwitchBotTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Test code to check API
            SwitchBotAPI api = new SwitchBotAPI("your token here");
            var result = api.CheckStatusAsync().Result;
            Console.WriteLine(result);

            DeviceList dl = result.Body as DeviceList;
            if (dl == null)
                return;

            var tvDev = dl.InfraredRemoteList.Where(ir => ir.RemoteType.ToUpper() == "TV").First();
            SonyTV tv = new SonyTV(tvDev);

            tv.TurnOnAsync().Wait();
            tv.SetChannelAsync(7).Wait();
            tv.ShowChannelListAsync().Wait();

            var lightDev = dl.InfraredRemoteList.Where(ir => ir.DeviceName == "Living Room Light").First();
            Light light = new Light(lightDev);
            light.TurnOffAsync().Wait();
            light.TurnOnAsync().Wait();

            var acDev = dl.InfraredRemoteList.Where(ir => ir.DeviceName == "Living Room Air Conditioner").First();
            AirConditioner ac = new AirConditioner(acDev, 20, ACModes.Heat, FanSpeeds.Auto, true);
            ac.TemperatureUpAsync().Wait();


            api.Dispose();
        }
    }
}
