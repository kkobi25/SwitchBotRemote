using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwitchBot.API;
using SwitchBot.Devices;
using System.Configuration;

namespace SwitchBotRemote
{
    public partial class SwitchBotRemote : Form
    {
        private string Token;

        private SwitchBotAPI API;
        private DeviceList Devices;
        
        private SonyTV LivingRoomTV;
        private SonySpeaker LivingRoomSpeaker;
        private Light LivingRoomLight;
        private AirConditioner LivingRoomAC;

        private delegate void UpdateStatusDelegate(bool isConnected);
        private delegate void UpdateStatusDelegate2(APIResponse response);
        private delegate void EnableAllControlsDelegate(Control cont, bool toEnable);
        public SwitchBotRemote()
        {
            InitializeComponent();
            EnableAllControls(this, false);
            UpdateStatus(false);
            LoadDevicesAsync().ConfigureAwait(false);
            switch (Properties.Settings.Default.ACMode_app)
            {
                case (int)ACModes.Cool:
                    rb_ACCool.Checked = true;
                    break;
                case (int)ACModes.Dry:
                    rb_ACDry.Checked = true;
                    break;
                case (int)ACModes.Fan:
                    rb_ACFan.Checked = true;
                    break;
                case (int)ACModes.Heat:
                    rb_ACHeat.Checked = true;
                    break;
            }
            switch (Properties.Settings.Default.ACSpeed_app)
            {
                case (int)FanSpeeds.Auto:
                    rb_ACSpeed_Auto.Checked = true;
                    break;
                case (int)FanSpeeds.Low:
                    rb_ACSpeed_Low.Checked = true;
                    break;
                case (int)FanSpeeds.Medium:
                    rb_ACSpeed_Mid.Checked = true;
                    break;
                case (int)FanSpeeds.High:
                    rb_ACSpeed_High.Checked = true;
                    break;
            }
            nud_temperatureSet.Value = Properties.Settings.Default.ACTemperature_app;
            rb_ACON.Checked = Properties.Settings.Default.IsACON_app;
            rb_ACOff.Checked = !Properties.Settings.Default.IsACON_app;
            this.MaximizeBox = false;
        }

        private void UpdateStatus(bool isConnected)
        {
            tb_status.Text = isConnected ? "接続完了！" : "SwitchBotに接続中...";
            tb_status.BackColor = isConnected ? System.Drawing.Color.LightGreen : System.Drawing.Color.LightCoral;
            tb_status.Enabled = false;
        }

        private void UpdateStatus(APIResponse response)
        {
            if (response.StatusCode == (int)StatusCode.Success)
            {
                tb_status.Text = "コマンド実行完了！";
                tb_status.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                tb_status.Text = "コマンド実行失敗";
                tb_status.BackColor = System.Drawing.Color.LightCoral;
            }
        }

        private void EnableAllControls(Control cont, bool toEnable)
        {
            foreach(Control control in cont.Controls)
            {
                EnableAllControls(control, toEnable);
            }
            cont.Enabled = toEnable;
        }
        private async Task LoadDevicesAsync()
        {
            Token = ConfigurationManager.AppSettings.Get("Token");
            API = new SwitchBotAPI(Token);
            var result = await API.CheckStatusAsync().ConfigureAwait(false);

            Devices = result.Body as DeviceList;
            if (Devices == null)
                return;

            string tvName = ConfigurationManager.AppSettings.Get("TVName");
            var tvDev = Devices.InfraredRemoteList.Where(ir => ir.DeviceName == tvName)?.FirstOrDefault();
            LivingRoomTV = (tvDev != null) ? new SonyTV(tvDev) : null;

            string lightName = ConfigurationManager.AppSettings.Get("LightName");
            var lightDev = Devices.InfraredRemoteList.Where(ir => ir.DeviceName == lightName)?.FirstOrDefault();
            LivingRoomLight = (lightDev != null) ? new Light(lightDev) : null;

            string speakerName = ConfigurationManager.AppSettings.Get("SpeakerName");
            var speakerDev = Devices.InfraredRemoteList.Where(ir => ir.DeviceName == speakerName)?.FirstOrDefault();
            LivingRoomSpeaker = (speakerDev != null) ? new SonySpeaker(speakerDev) : null;

            string acName = ConfigurationManager.AppSettings.Get("ACName");
            var acDev = Devices.InfraredRemoteList.Where(ir => ir.DeviceName == acName)?.FirstOrDefault();
            LivingRoomAC = (acDev != null) ? new AirConditioner(acDev, 20, ACModes.Heat, FanSpeeds.Auto, true) : null;

            this.BeginInvoke(new EnableAllControlsDelegate(EnableAllControls), this, true);
            this.BeginInvoke(new UpdateStatusDelegate(UpdateStatus), true);

            if (LivingRoomTV == null)
                this.BeginInvoke(new EnableAllControlsDelegate(EnableAllControls), gb_TV, false);
            if (LivingRoomLight == null)
                this.BeginInvoke(new EnableAllControlsDelegate(EnableAllControls), gb_light, false);
            if (LivingRoomSpeaker == null)
                this.BeginInvoke(new EnableAllControlsDelegate(EnableAllControls), gb_speaker, false);
            if (LivingRoomAC == null)
                this.BeginInvoke(new EnableAllControlsDelegate(EnableAllControls), gb_AC, false);

            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.API?.Dispose();
            this.API = null;
        }

        private async void btn_ChannelUp_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.NextChannelAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_ChannelDown_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;
            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.PreviousChannelAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_TVPower_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.TurnOnAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_volumeUp_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.VolumeUpAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_volumeDown_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.VolumeDownAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel1_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(1);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel2_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(2);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel3_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(3);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel4_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(4);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel5_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(5);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel6_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(6);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel7_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(7);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel8_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(8);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel9_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(9);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel10_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(10);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel11_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(11);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_channel12_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.SetChannelAsync(12);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_digital_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.ChangeToDigitalAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_bs_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.ChangeToBSAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_cs_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.ChangeToCSAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_10key_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.Show10KeyAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_ChannelList_Click(object sender, EventArgs e)
        {
            if (LivingRoomTV == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomTV.ShowChannelListAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_speakerVolumeUp_Click(object sender, EventArgs e)
        {
            if (LivingRoomSpeaker == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomSpeaker.VolumeUpAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_speakerVolumeDown_Click(object sender, EventArgs e)
        {
            if (LivingRoomSpeaker == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomSpeaker.VolumeDownAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_speakerBass_Click(object sender, EventArgs e)
        {
            if (LivingRoomSpeaker == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomSpeaker.BassAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_speakerAuto_Click(object sender, EventArgs e)
        {
            if (LivingRoomSpeaker == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomSpeaker.AutoSoundAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_speakerVerticalS_Click(object sender, EventArgs e)
        {
            if (LivingRoomSpeaker == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomSpeaker.VerticalSoundToggleAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_speakerCinema_Click(object sender, EventArgs e)
        {
            if (LivingRoomSpeaker == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomSpeaker.CinemaAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_speakerNews_Click(object sender, EventArgs e)
        {
            if (LivingRoomSpeaker == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomSpeaker.NewsAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_speakerInput_Click(object sender, EventArgs e)
        {
            if (LivingRoomSpeaker == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomSpeaker.ChangeInputAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_speakerPower_Click(object sender, EventArgs e)
        {
            if (LivingRoomSpeaker == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomSpeaker.TurnOnAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_lightOnOff_Click(object sender, EventArgs e)
        {
            if (LivingRoomLight == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomLight.TurnOnAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_lightBrightness_Click(object sender, EventArgs e)
        {
            if (LivingRoomLight == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomLight.BrightnessUpAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_lightEnergySaving_Click(object sender, EventArgs e)
        {
            if (LivingRoomLight == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomLight.EnergySavingModeAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_lightNight_Click(object sender, EventArgs e)
        {
            if (LivingRoomLight == null)
                return;

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomLight.TurnNightLightOnAsync().ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
        }

        private async void btn_ACSend_Click(object sender, EventArgs e)
        {
            ACModes mode = ACModes.Cool;
            FanSpeeds speed = FanSpeeds.Auto;
            if (rb_ACCool.Checked)
            {
                mode = ACModes.Cool;
            }
            else if (rb_ACDry.Checked)
            {
                mode = ACModes.Dry;
            }
            else if (rb_ACFan.Checked)
            {
                mode = ACModes.Fan;
            }
            else if (rb_ACHeat.Checked)
            {
                mode = ACModes.Heat;
            }

            if (rb_ACSpeed_Auto.Checked)
            {
                speed = FanSpeeds.Auto;
            }
            else if (rb_ACSpeed_Low.Checked)
            {
                speed = FanSpeeds.Low;
            }
            else if (rb_ACSpeed_Mid.Checked)
            {
                speed = FanSpeeds.Medium;
            }
            else if (rb_ACSpeed_High.Checked)
            {
                speed = FanSpeeds.High;
            }

            tb_status.Text = "コマンド送信中...";
            var res = await LivingRoomAC
                .SetAllAsync((int)nud_temperatureSet.Value, mode, speed, rb_ACON.Checked)
                .ConfigureAwait(false);
            this.BeginInvoke(new UpdateStatusDelegate2(UpdateStatus), res);
            Properties.Settings.Default.IsACON_app = rb_ACON.Checked;
            Properties.Settings.Default.ACMode_app = (int)mode;
            Properties.Settings.Default.ACSpeed_app = (int)speed;
            Properties.Settings.Default.ACTemperature_app = (int)nud_temperatureSet.Value;
            Properties.Settings.Default.Save();
        }
    }
}
