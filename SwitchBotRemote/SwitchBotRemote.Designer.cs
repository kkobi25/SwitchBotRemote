namespace SwitchBotRemote
{
    partial class SwitchBotRemote
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_channelUp = new System.Windows.Forms.Button();
            this.btn_channelDown = new System.Windows.Forms.Button();
            this.btn_TVPower = new System.Windows.Forms.Button();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.gb_TV = new System.Windows.Forms.GroupBox();
            this.btn_ChannelList = new System.Windows.Forms.Button();
            this.btn_10key = new System.Windows.Forms.Button();
            this.btn_cs = new System.Windows.Forms.Button();
            this.btn_bs = new System.Windows.Forms.Button();
            this.btn_digital = new System.Windows.Forms.Button();
            this.btn_channel12 = new System.Windows.Forms.Button();
            this.btn_channel11 = new System.Windows.Forms.Button();
            this.btn_channel10 = new System.Windows.Forms.Button();
            this.btn_channel9 = new System.Windows.Forms.Button();
            this.btn_channel8 = new System.Windows.Forms.Button();
            this.btn_channel7 = new System.Windows.Forms.Button();
            this.btn_channel6 = new System.Windows.Forms.Button();
            this.btn_channel5 = new System.Windows.Forms.Button();
            this.btn_channel4 = new System.Windows.Forms.Button();
            this.btn_channel3 = new System.Windows.Forms.Button();
            this.btn_channel2 = new System.Windows.Forms.Button();
            this.btn_channel1 = new System.Windows.Forms.Button();
            this.btn_volumeDown = new System.Windows.Forms.Button();
            this.btn_volumeUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_speaker = new System.Windows.Forms.GroupBox();
            this.btn_speakerBass = new System.Windows.Forms.Button();
            this.btn_speakerNews = new System.Windows.Forms.Button();
            this.btn_speakerCinema = new System.Windows.Forms.Button();
            this.btn_speakerVerticalS = new System.Windows.Forms.Button();
            this.btn_speakerAuto = new System.Windows.Forms.Button();
            this.btn_speakerInput = new System.Windows.Forms.Button();
            this.btn_speakerPower = new System.Windows.Forms.Button();
            this.btn_speakerVolumeDown = new System.Windows.Forms.Button();
            this.btn_speakerVolumeUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_light = new System.Windows.Forms.GroupBox();
            this.btn_lightNight = new System.Windows.Forms.Button();
            this.btn_lightEnergySaving = new System.Windows.Forms.Button();
            this.btn_lightBrightness = new System.Windows.Forms.Button();
            this.btn_lightOnOff = new System.Windows.Forms.Button();
            this.gb_AC = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_AC_power = new System.Windows.Forms.GroupBox();
            this.rb_ACON = new System.Windows.Forms.RadioButton();
            this.rb_ACOff = new System.Windows.Forms.RadioButton();
            this.btn_ACSend = new System.Windows.Forms.Button();
            this.gb_AC_speed = new System.Windows.Forms.GroupBox();
            this.rb_ACSpeed_Auto = new System.Windows.Forms.RadioButton();
            this.rb_ACSpeed_High = new System.Windows.Forms.RadioButton();
            this.rb_ACSpeed_Low = new System.Windows.Forms.RadioButton();
            this.rb_ACSpeed_Mid = new System.Windows.Forms.RadioButton();
            this.gb_AC_mode = new System.Windows.Forms.GroupBox();
            this.rb_ACFan = new System.Windows.Forms.RadioButton();
            this.rb_ACHeat = new System.Windows.Forms.RadioButton();
            this.rb_ACCool = new System.Windows.Forms.RadioButton();
            this.rb_ACDry = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_temperatureSet = new System.Windows.Forms.NumericUpDown();
            this.gb_TV.SuspendLayout();
            this.gb_speaker.SuspendLayout();
            this.gb_light.SuspendLayout();
            this.gb_AC.SuspendLayout();
            this.gb_AC_power.SuspendLayout();
            this.gb_AC_speed.SuspendLayout();
            this.gb_AC_mode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_temperatureSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_channelUp
            // 
            this.btn_channelUp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channelUp.Location = new System.Drawing.Point(229, 500);
            this.btn_channelUp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channelUp.Name = "btn_channelUp";
            this.btn_channelUp.Size = new System.Drawing.Size(53, 46);
            this.btn_channelUp.TabIndex = 21;
            this.btn_channelUp.Text = "🔺";
            this.btn_channelUp.UseVisualStyleBackColor = true;
            this.btn_channelUp.Click += new System.EventHandler(this.btn_ChannelUp_Click);
            // 
            // btn_channelDown
            // 
            this.btn_channelDown.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channelDown.Location = new System.Drawing.Point(229, 572);
            this.btn_channelDown.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channelDown.Name = "btn_channelDown";
            this.btn_channelDown.Size = new System.Drawing.Size(53, 46);
            this.btn_channelDown.TabIndex = 22;
            this.btn_channelDown.Text = "🔻";
            this.btn_channelDown.UseVisualStyleBackColor = true;
            this.btn_channelDown.Click += new System.EventHandler(this.btn_ChannelDown_Click);
            // 
            // btn_TVPower
            // 
            this.btn_TVPower.Location = new System.Drawing.Point(271, 16);
            this.btn_TVPower.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TVPower.Name = "btn_TVPower";
            this.btn_TVPower.Size = new System.Drawing.Size(100, 29);
            this.btn_TVPower.TabIndex = 0;
            this.btn_TVPower.Text = "電源";
            this.btn_TVPower.UseVisualStyleBackColor = true;
            this.btn_TVPower.Click += new System.EventHandler(this.btn_TVPower_Click);
            // 
            // tb_status
            // 
            this.tb_status.BackColor = System.Drawing.Color.LightCoral;
            this.tb_status.Enabled = false;
            this.tb_status.Location = new System.Drawing.Point(16, 15);
            this.tb_status.Margin = new System.Windows.Forms.Padding(4);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(200, 22);
            this.tb_status.TabIndex = 0;
            this.tb_status.Text = "SwitchBotに接続中...";
            // 
            // gb_TV
            // 
            this.gb_TV.Controls.Add(this.btn_ChannelList);
            this.gb_TV.Controls.Add(this.btn_10key);
            this.gb_TV.Controls.Add(this.btn_cs);
            this.gb_TV.Controls.Add(this.btn_bs);
            this.gb_TV.Controls.Add(this.btn_digital);
            this.gb_TV.Controls.Add(this.btn_channel12);
            this.gb_TV.Controls.Add(this.btn_channel11);
            this.gb_TV.Controls.Add(this.btn_channel10);
            this.gb_TV.Controls.Add(this.btn_channel9);
            this.gb_TV.Controls.Add(this.btn_channel8);
            this.gb_TV.Controls.Add(this.btn_channel7);
            this.gb_TV.Controls.Add(this.btn_channel6);
            this.gb_TV.Controls.Add(this.btn_channel5);
            this.gb_TV.Controls.Add(this.btn_channel4);
            this.gb_TV.Controls.Add(this.btn_channel3);
            this.gb_TV.Controls.Add(this.btn_channel2);
            this.gb_TV.Controls.Add(this.btn_channel1);
            this.gb_TV.Controls.Add(this.btn_volumeDown);
            this.gb_TV.Controls.Add(this.btn_volumeUp);
            this.gb_TV.Controls.Add(this.label2);
            this.gb_TV.Controls.Add(this.label1);
            this.gb_TV.Controls.Add(this.btn_channelUp);
            this.gb_TV.Controls.Add(this.btn_TVPower);
            this.gb_TV.Controls.Add(this.btn_channelDown);
            this.gb_TV.Location = new System.Drawing.Point(16, 55);
            this.gb_TV.Margin = new System.Windows.Forms.Padding(4);
            this.gb_TV.Name = "gb_TV";
            this.gb_TV.Padding = new System.Windows.Forms.Padding(4);
            this.gb_TV.Size = new System.Drawing.Size(379, 638);
            this.gb_TV.TabIndex = 1;
            this.gb_TV.TabStop = false;
            this.gb_TV.Text = "Sony TV";
            // 
            // btn_ChannelList
            // 
            this.btn_ChannelList.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_ChannelList.Location = new System.Drawing.Point(120, 402);
            this.btn_ChannelList.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChannelList.Name = "btn_ChannelList";
            this.btn_ChannelList.Size = new System.Drawing.Size(131, 38);
            this.btn_ChannelList.TabIndex = 16;
            this.btn_ChannelList.Text = "番組表";
            this.btn_ChannelList.UseVisualStyleBackColor = true;
            this.btn_ChannelList.Click += new System.EventHandler(this.btn_ChannelList_Click);
            // 
            // btn_10key
            // 
            this.btn_10key.Location = new System.Drawing.Point(300, 545);
            this.btn_10key.Margin = new System.Windows.Forms.Padding(4);
            this.btn_10key.Name = "btn_10key";
            this.btn_10key.Size = new System.Drawing.Size(71, 29);
            this.btn_10key.TabIndex = 23;
            this.btn_10key.Text = "10キー";
            this.btn_10key.UseVisualStyleBackColor = true;
            this.btn_10key.Click += new System.EventHandler(this.btn_10key_Click);
            // 
            // btn_cs
            // 
            this.btn_cs.Location = new System.Drawing.Point(245, 61);
            this.btn_cs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cs.Name = "btn_cs";
            this.btn_cs.Size = new System.Drawing.Size(71, 29);
            this.btn_cs.TabIndex = 3;
            this.btn_cs.Text = "CS";
            this.btn_cs.UseVisualStyleBackColor = true;
            this.btn_cs.Click += new System.EventHandler(this.btn_cs_Click);
            // 
            // btn_bs
            // 
            this.btn_bs.Location = new System.Drawing.Point(144, 61);
            this.btn_bs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bs.Name = "btn_bs";
            this.btn_bs.Size = new System.Drawing.Size(71, 29);
            this.btn_bs.TabIndex = 2;
            this.btn_bs.Text = "BS";
            this.btn_bs.UseVisualStyleBackColor = true;
            this.btn_bs.Click += new System.EventHandler(this.btn_bs_Click);
            // 
            // btn_digital
            // 
            this.btn_digital.Location = new System.Drawing.Point(44, 61);
            this.btn_digital.Margin = new System.Windows.Forms.Padding(4);
            this.btn_digital.Name = "btn_digital";
            this.btn_digital.Size = new System.Drawing.Size(71, 29);
            this.btn_digital.TabIndex = 1;
            this.btn_digital.Text = "デジタル";
            this.btn_digital.UseVisualStyleBackColor = true;
            this.btn_digital.Click += new System.EventHandler(this.btn_digital_Click);
            // 
            // btn_channel12
            // 
            this.btn_channel12.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel12.Location = new System.Drawing.Point(254, 286);
            this.btn_channel12.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel12.Name = "btn_channel12";
            this.btn_channel12.Size = new System.Drawing.Size(53, 46);
            this.btn_channel12.TabIndex = 15;
            this.btn_channel12.Text = "12";
            this.btn_channel12.UseVisualStyleBackColor = true;
            this.btn_channel12.Click += new System.EventHandler(this.btn_channel12_Click);
            // 
            // btn_channel11
            // 
            this.btn_channel11.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel11.Location = new System.Drawing.Point(153, 286);
            this.btn_channel11.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel11.Name = "btn_channel11";
            this.btn_channel11.Size = new System.Drawing.Size(53, 46);
            this.btn_channel11.TabIndex = 14;
            this.btn_channel11.Text = "11";
            this.btn_channel11.UseVisualStyleBackColor = true;
            this.btn_channel11.Click += new System.EventHandler(this.btn_channel11_Click);
            // 
            // btn_channel10
            // 
            this.btn_channel10.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel10.Location = new System.Drawing.Point(52, 286);
            this.btn_channel10.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel10.Name = "btn_channel10";
            this.btn_channel10.Size = new System.Drawing.Size(53, 46);
            this.btn_channel10.TabIndex = 13;
            this.btn_channel10.Text = "10";
            this.btn_channel10.UseVisualStyleBackColor = true;
            this.btn_channel10.Click += new System.EventHandler(this.btn_channel10_Click);
            // 
            // btn_channel9
            // 
            this.btn_channel9.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel9.Location = new System.Drawing.Point(254, 228);
            this.btn_channel9.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel9.Name = "btn_channel9";
            this.btn_channel9.Size = new System.Drawing.Size(53, 46);
            this.btn_channel9.TabIndex = 12;
            this.btn_channel9.Text = "9";
            this.btn_channel9.UseVisualStyleBackColor = true;
            this.btn_channel9.Click += new System.EventHandler(this.btn_channel9_Click);
            // 
            // btn_channel8
            // 
            this.btn_channel8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel8.Location = new System.Drawing.Point(153, 228);
            this.btn_channel8.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel8.Name = "btn_channel8";
            this.btn_channel8.Size = new System.Drawing.Size(53, 46);
            this.btn_channel8.TabIndex = 11;
            this.btn_channel8.Text = "8";
            this.btn_channel8.UseVisualStyleBackColor = true;
            this.btn_channel8.Click += new System.EventHandler(this.btn_channel8_Click);
            // 
            // btn_channel7
            // 
            this.btn_channel7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel7.Location = new System.Drawing.Point(52, 228);
            this.btn_channel7.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel7.Name = "btn_channel7";
            this.btn_channel7.Size = new System.Drawing.Size(53, 46);
            this.btn_channel7.TabIndex = 10;
            this.btn_channel7.Text = "7";
            this.btn_channel7.UseVisualStyleBackColor = true;
            this.btn_channel7.Click += new System.EventHandler(this.btn_channel7_Click);
            // 
            // btn_channel6
            // 
            this.btn_channel6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel6.Location = new System.Drawing.Point(254, 170);
            this.btn_channel6.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel6.Name = "btn_channel6";
            this.btn_channel6.Size = new System.Drawing.Size(53, 46);
            this.btn_channel6.TabIndex = 9;
            this.btn_channel6.Text = "6";
            this.btn_channel6.UseVisualStyleBackColor = true;
            this.btn_channel6.Click += new System.EventHandler(this.btn_channel6_Click);
            // 
            // btn_channel5
            // 
            this.btn_channel5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel5.Location = new System.Drawing.Point(153, 170);
            this.btn_channel5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel5.Name = "btn_channel5";
            this.btn_channel5.Size = new System.Drawing.Size(53, 46);
            this.btn_channel5.TabIndex = 8;
            this.btn_channel5.Text = "5";
            this.btn_channel5.UseVisualStyleBackColor = true;
            this.btn_channel5.Click += new System.EventHandler(this.btn_channel5_Click);
            // 
            // btn_channel4
            // 
            this.btn_channel4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel4.Location = new System.Drawing.Point(52, 170);
            this.btn_channel4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel4.Name = "btn_channel4";
            this.btn_channel4.Size = new System.Drawing.Size(53, 46);
            this.btn_channel4.TabIndex = 7;
            this.btn_channel4.Text = "4";
            this.btn_channel4.UseVisualStyleBackColor = true;
            this.btn_channel4.Click += new System.EventHandler(this.btn_channel4_Click);
            // 
            // btn_channel3
            // 
            this.btn_channel3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel3.Location = new System.Drawing.Point(254, 112);
            this.btn_channel3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel3.Name = "btn_channel3";
            this.btn_channel3.Size = new System.Drawing.Size(53, 46);
            this.btn_channel3.TabIndex = 6;
            this.btn_channel3.Text = "3";
            this.btn_channel3.UseVisualStyleBackColor = true;
            this.btn_channel3.Click += new System.EventHandler(this.btn_channel3_Click);
            // 
            // btn_channel2
            // 
            this.btn_channel2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel2.Location = new System.Drawing.Point(153, 112);
            this.btn_channel2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel2.Name = "btn_channel2";
            this.btn_channel2.Size = new System.Drawing.Size(53, 46);
            this.btn_channel2.TabIndex = 5;
            this.btn_channel2.Text = "2";
            this.btn_channel2.UseVisualStyleBackColor = true;
            this.btn_channel2.Click += new System.EventHandler(this.btn_channel2_Click);
            // 
            // btn_channel1
            // 
            this.btn_channel1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_channel1.Location = new System.Drawing.Point(52, 112);
            this.btn_channel1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_channel1.Name = "btn_channel1";
            this.btn_channel1.Size = new System.Drawing.Size(53, 46);
            this.btn_channel1.TabIndex = 4;
            this.btn_channel1.Text = "1";
            this.btn_channel1.UseVisualStyleBackColor = true;
            this.btn_channel1.Click += new System.EventHandler(this.btn_channel1_Click);
            // 
            // btn_volumeDown
            // 
            this.btn_volumeDown.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_volumeDown.Location = new System.Drawing.Point(81, 572);
            this.btn_volumeDown.Margin = new System.Windows.Forms.Padding(4);
            this.btn_volumeDown.Name = "btn_volumeDown";
            this.btn_volumeDown.Size = new System.Drawing.Size(53, 46);
            this.btn_volumeDown.TabIndex = 19;
            this.btn_volumeDown.Text = "🔻";
            this.btn_volumeDown.UseVisualStyleBackColor = true;
            this.btn_volumeDown.Click += new System.EventHandler(this.btn_volumeDown_Click);
            // 
            // btn_volumeUp
            // 
            this.btn_volumeUp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_volumeUp.Location = new System.Drawing.Point(81, 500);
            this.btn_volumeUp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_volumeUp.Name = "btn_volumeUp";
            this.btn_volumeUp.Size = new System.Drawing.Size(53, 46);
            this.btn_volumeUp.TabIndex = 18;
            this.btn_volumeUp.Text = "🔺";
            this.btn_volumeUp.UseVisualStyleBackColor = true;
            this.btn_volumeUp.Click += new System.EventHandler(this.btn_volumeUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(81, 461);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "音量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(211, 461);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "チャンネル";
            // 
            // gb_speaker
            // 
            this.gb_speaker.Controls.Add(this.btn_speakerBass);
            this.gb_speaker.Controls.Add(this.btn_speakerNews);
            this.gb_speaker.Controls.Add(this.btn_speakerCinema);
            this.gb_speaker.Controls.Add(this.btn_speakerVerticalS);
            this.gb_speaker.Controls.Add(this.btn_speakerAuto);
            this.gb_speaker.Controls.Add(this.btn_speakerInput);
            this.gb_speaker.Controls.Add(this.btn_speakerPower);
            this.gb_speaker.Controls.Add(this.btn_speakerVolumeDown);
            this.gb_speaker.Controls.Add(this.btn_speakerVolumeUp);
            this.gb_speaker.Controls.Add(this.label3);
            this.gb_speaker.Location = new System.Drawing.Point(431, 55);
            this.gb_speaker.Margin = new System.Windows.Forms.Padding(4);
            this.gb_speaker.Name = "gb_speaker";
            this.gb_speaker.Padding = new System.Windows.Forms.Padding(4);
            this.gb_speaker.Size = new System.Drawing.Size(620, 212);
            this.gb_speaker.TabIndex = 2;
            this.gb_speaker.TabStop = false;
            this.gb_speaker.Text = "Sony Speaker";
            // 
            // btn_speakerBass
            // 
            this.btn_speakerBass.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_speakerBass.Location = new System.Drawing.Point(109, 112);
            this.btn_speakerBass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_speakerBass.Name = "btn_speakerBass";
            this.btn_speakerBass.Size = new System.Drawing.Size(68, 38);
            this.btn_speakerBass.TabIndex = 5;
            this.btn_speakerBass.Text = "低音";
            this.btn_speakerBass.UseVisualStyleBackColor = true;
            this.btn_speakerBass.Click += new System.EventHandler(this.btn_speakerBass_Click);
            // 
            // btn_speakerNews
            // 
            this.btn_speakerNews.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_speakerNews.Location = new System.Drawing.Point(404, 146);
            this.btn_speakerNews.Margin = new System.Windows.Forms.Padding(4);
            this.btn_speakerNews.Name = "btn_speakerNews";
            this.btn_speakerNews.Size = new System.Drawing.Size(131, 38);
            this.btn_speakerNews.TabIndex = 9;
            this.btn_speakerNews.Text = "ニュース";
            this.btn_speakerNews.UseVisualStyleBackColor = true;
            this.btn_speakerNews.Click += new System.EventHandler(this.btn_speakerNews_Click);
            // 
            // btn_speakerCinema
            // 
            this.btn_speakerCinema.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_speakerCinema.Location = new System.Drawing.Point(404, 78);
            this.btn_speakerCinema.Margin = new System.Windows.Forms.Padding(4);
            this.btn_speakerCinema.Name = "btn_speakerCinema";
            this.btn_speakerCinema.Size = new System.Drawing.Size(131, 38);
            this.btn_speakerCinema.TabIndex = 8;
            this.btn_speakerCinema.Text = "シネマ";
            this.btn_speakerCinema.UseVisualStyleBackColor = true;
            this.btn_speakerCinema.Click += new System.EventHandler(this.btn_speakerCinema_Click);
            // 
            // btn_speakerVerticalS
            // 
            this.btn_speakerVerticalS.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_speakerVerticalS.Location = new System.Drawing.Point(212, 146);
            this.btn_speakerVerticalS.Margin = new System.Windows.Forms.Padding(4);
            this.btn_speakerVerticalS.Name = "btn_speakerVerticalS";
            this.btn_speakerVerticalS.Size = new System.Drawing.Size(131, 38);
            this.btn_speakerVerticalS.TabIndex = 7;
            this.btn_speakerVerticalS.Text = "Vertical S.";
            this.btn_speakerVerticalS.UseVisualStyleBackColor = true;
            this.btn_speakerVerticalS.Click += new System.EventHandler(this.btn_speakerVerticalS_Click);
            // 
            // btn_speakerAuto
            // 
            this.btn_speakerAuto.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_speakerAuto.Location = new System.Drawing.Point(212, 74);
            this.btn_speakerAuto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_speakerAuto.Name = "btn_speakerAuto";
            this.btn_speakerAuto.Size = new System.Drawing.Size(131, 38);
            this.btn_speakerAuto.TabIndex = 6;
            this.btn_speakerAuto.Text = "オートサウンド";
            this.btn_speakerAuto.UseVisualStyleBackColor = true;
            this.btn_speakerAuto.Click += new System.EventHandler(this.btn_speakerAuto_Click);
            // 
            // btn_speakerInput
            // 
            this.btn_speakerInput.Location = new System.Drawing.Point(376, 22);
            this.btn_speakerInput.Margin = new System.Windows.Forms.Padding(4);
            this.btn_speakerInput.Name = "btn_speakerInput";
            this.btn_speakerInput.Size = new System.Drawing.Size(100, 29);
            this.btn_speakerInput.TabIndex = 1;
            this.btn_speakerInput.Text = "入力切替";
            this.btn_speakerInput.UseVisualStyleBackColor = true;
            this.btn_speakerInput.Click += new System.EventHandler(this.btn_speakerInput_Click);
            // 
            // btn_speakerPower
            // 
            this.btn_speakerPower.Location = new System.Drawing.Point(501, 22);
            this.btn_speakerPower.Margin = new System.Windows.Forms.Padding(4);
            this.btn_speakerPower.Name = "btn_speakerPower";
            this.btn_speakerPower.Size = new System.Drawing.Size(100, 29);
            this.btn_speakerPower.TabIndex = 0;
            this.btn_speakerPower.Text = "電源";
            this.btn_speakerPower.UseVisualStyleBackColor = true;
            this.btn_speakerPower.Click += new System.EventHandler(this.btn_speakerPower_Click);
            // 
            // btn_speakerVolumeDown
            // 
            this.btn_speakerVolumeDown.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_speakerVolumeDown.Location = new System.Drawing.Point(21, 141);
            this.btn_speakerVolumeDown.Margin = new System.Windows.Forms.Padding(4);
            this.btn_speakerVolumeDown.Name = "btn_speakerVolumeDown";
            this.btn_speakerVolumeDown.Size = new System.Drawing.Size(53, 46);
            this.btn_speakerVolumeDown.TabIndex = 4;
            this.btn_speakerVolumeDown.Text = "🔻";
            this.btn_speakerVolumeDown.UseVisualStyleBackColor = true;
            this.btn_speakerVolumeDown.Click += new System.EventHandler(this.btn_speakerVolumeDown_Click);
            // 
            // btn_speakerVolumeUp
            // 
            this.btn_speakerVolumeUp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_speakerVolumeUp.Location = new System.Drawing.Point(21, 69);
            this.btn_speakerVolumeUp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_speakerVolumeUp.Name = "btn_speakerVolumeUp";
            this.btn_speakerVolumeUp.Size = new System.Drawing.Size(53, 46);
            this.btn_speakerVolumeUp.TabIndex = 3;
            this.btn_speakerVolumeUp.Text = "🔺";
            this.btn_speakerVolumeUp.UseVisualStyleBackColor = true;
            this.btn_speakerVolumeUp.Click += new System.EventHandler(this.btn_speakerVolumeUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "音量";
            // 
            // gb_light
            // 
            this.gb_light.Controls.Add(this.btn_lightNight);
            this.gb_light.Controls.Add(this.btn_lightEnergySaving);
            this.gb_light.Controls.Add(this.btn_lightBrightness);
            this.gb_light.Controls.Add(this.btn_lightOnOff);
            this.gb_light.Location = new System.Drawing.Point(431, 288);
            this.gb_light.Margin = new System.Windows.Forms.Padding(4);
            this.gb_light.Name = "gb_light";
            this.gb_light.Padding = new System.Windows.Forms.Padding(4);
            this.gb_light.Size = new System.Drawing.Size(197, 405);
            this.gb_light.TabIndex = 3;
            this.gb_light.TabStop = false;
            this.gb_light.Text = "Lighting";
            // 
            // btn_lightNight
            // 
            this.btn_lightNight.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_lightNight.Location = new System.Drawing.Point(25, 346);
            this.btn_lightNight.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lightNight.Name = "btn_lightNight";
            this.btn_lightNight.Size = new System.Drawing.Size(131, 38);
            this.btn_lightNight.TabIndex = 3;
            this.btn_lightNight.Text = "常夜灯";
            this.btn_lightNight.UseVisualStyleBackColor = true;
            this.btn_lightNight.Click += new System.EventHandler(this.btn_lightNight_Click);
            // 
            // btn_lightEnergySaving
            // 
            this.btn_lightEnergySaving.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_lightEnergySaving.Location = new System.Drawing.Point(25, 286);
            this.btn_lightEnergySaving.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lightEnergySaving.Name = "btn_lightEnergySaving";
            this.btn_lightEnergySaving.Size = new System.Drawing.Size(131, 38);
            this.btn_lightEnergySaving.TabIndex = 2;
            this.btn_lightEnergySaving.Text = "省エネ";
            this.btn_lightEnergySaving.UseVisualStyleBackColor = true;
            this.btn_lightEnergySaving.Click += new System.EventHandler(this.btn_lightEnergySaving_Click);
            // 
            // btn_lightBrightness
            // 
            this.btn_lightBrightness.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_lightBrightness.Location = new System.Drawing.Point(25, 225);
            this.btn_lightBrightness.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lightBrightness.Name = "btn_lightBrightness";
            this.btn_lightBrightness.Size = new System.Drawing.Size(131, 38);
            this.btn_lightBrightness.TabIndex = 1;
            this.btn_lightBrightness.Text = "明るさ変更";
            this.btn_lightBrightness.UseVisualStyleBackColor = true;
            this.btn_lightBrightness.Click += new System.EventHandler(this.btn_lightBrightness_Click);
            // 
            // btn_lightOnOff
            // 
            this.btn_lightOnOff.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_lightOnOff.Location = new System.Drawing.Point(25, 39);
            this.btn_lightOnOff.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lightOnOff.Name = "btn_lightOnOff";
            this.btn_lightOnOff.Size = new System.Drawing.Size(131, 38);
            this.btn_lightOnOff.TabIndex = 0;
            this.btn_lightOnOff.Text = "ON / OFF";
            this.btn_lightOnOff.UseVisualStyleBackColor = true;
            this.btn_lightOnOff.Click += new System.EventHandler(this.btn_lightOnOff_Click);
            // 
            // gb_AC
            // 
            this.gb_AC.Controls.Add(this.label5);
            this.gb_AC.Controls.Add(this.gb_AC_power);
            this.gb_AC.Controls.Add(this.btn_ACSend);
            this.gb_AC.Controls.Add(this.gb_AC_speed);
            this.gb_AC.Controls.Add(this.gb_AC_mode);
            this.gb_AC.Controls.Add(this.label4);
            this.gb_AC.Controls.Add(this.nud_temperatureSet);
            this.gb_AC.Location = new System.Drawing.Point(643, 288);
            this.gb_AC.Margin = new System.Windows.Forms.Padding(4);
            this.gb_AC.Name = "gb_AC";
            this.gb_AC.Padding = new System.Windows.Forms.Padding(4);
            this.gb_AC.Size = new System.Drawing.Size(408, 405);
            this.gb_AC.TabIndex = 4;
            this.gb_AC.TabStop = false;
            this.gb_AC.Text = "Air Conditioner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(216, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "℃";
            // 
            // gb_AC_power
            // 
            this.gb_AC_power.Controls.Add(this.rb_ACON);
            this.gb_AC_power.Controls.Add(this.rb_ACOff);
            this.gb_AC_power.Location = new System.Drawing.Point(8, 22);
            this.gb_AC_power.Margin = new System.Windows.Forms.Padding(4);
            this.gb_AC_power.Name = "gb_AC_power";
            this.gb_AC_power.Padding = new System.Windows.Forms.Padding(4);
            this.gb_AC_power.Size = new System.Drawing.Size(392, 75);
            this.gb_AC_power.TabIndex = 0;
            this.gb_AC_power.TabStop = false;
            this.gb_AC_power.Text = "電　源";
            // 
            // rb_ACON
            // 
            this.rb_ACON.AutoSize = true;
            this.rb_ACON.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_ACON.Location = new System.Drawing.Point(12, 29);
            this.rb_ACON.Margin = new System.Windows.Forms.Padding(4);
            this.rb_ACON.Name = "rb_ACON";
            this.rb_ACON.Size = new System.Drawing.Size(55, 28);
            this.rb_ACON.TabIndex = 0;
            this.rb_ACON.TabStop = true;
            this.rb_ACON.Text = "入";
            this.rb_ACON.UseVisualStyleBackColor = true;
            // 
            // rb_ACOff
            // 
            this.rb_ACOff.AutoSize = true;
            this.rb_ACOff.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_ACOff.Location = new System.Drawing.Point(108, 29);
            this.rb_ACOff.Margin = new System.Windows.Forms.Padding(4);
            this.rb_ACOff.Name = "rb_ACOff";
            this.rb_ACOff.Size = new System.Drawing.Size(55, 28);
            this.rb_ACOff.TabIndex = 1;
            this.rb_ACOff.TabStop = true;
            this.rb_ACOff.Text = "切";
            this.rb_ACOff.UseVisualStyleBackColor = true;
            // 
            // btn_ACSend
            // 
            this.btn_ACSend.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_ACSend.Location = new System.Drawing.Point(40, 346);
            this.btn_ACSend.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ACSend.Name = "btn_ACSend";
            this.btn_ACSend.Size = new System.Drawing.Size(317, 38);
            this.btn_ACSend.TabIndex = 6;
            this.btn_ACSend.Text = "送　　信";
            this.btn_ACSend.UseVisualStyleBackColor = true;
            this.btn_ACSend.Click += new System.EventHandler(this.btn_ACSend_Click);
            // 
            // gb_AC_speed
            // 
            this.gb_AC_speed.Controls.Add(this.rb_ACSpeed_Auto);
            this.gb_AC_speed.Controls.Add(this.rb_ACSpeed_High);
            this.gb_AC_speed.Controls.Add(this.rb_ACSpeed_Low);
            this.gb_AC_speed.Controls.Add(this.rb_ACSpeed_Mid);
            this.gb_AC_speed.Location = new System.Drawing.Point(8, 188);
            this.gb_AC_speed.Margin = new System.Windows.Forms.Padding(4);
            this.gb_AC_speed.Name = "gb_AC_speed";
            this.gb_AC_speed.Padding = new System.Windows.Forms.Padding(4);
            this.gb_AC_speed.Size = new System.Drawing.Size(392, 75);
            this.gb_AC_speed.TabIndex = 2;
            this.gb_AC_speed.TabStop = false;
            this.gb_AC_speed.Text = "風量";
            // 
            // rb_ACSpeed_Auto
            // 
            this.rb_ACSpeed_Auto.AutoSize = true;
            this.rb_ACSpeed_Auto.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_ACSpeed_Auto.Location = new System.Drawing.Point(300, 30);
            this.rb_ACSpeed_Auto.Margin = new System.Windows.Forms.Padding(4);
            this.rb_ACSpeed_Auto.Name = "rb_ACSpeed_Auto";
            this.rb_ACSpeed_Auto.Size = new System.Drawing.Size(79, 28);
            this.rb_ACSpeed_Auto.TabIndex = 3;
            this.rb_ACSpeed_Auto.TabStop = true;
            this.rb_ACSpeed_Auto.Text = "自動";
            this.rb_ACSpeed_Auto.UseVisualStyleBackColor = true;
            // 
            // rb_ACSpeed_High
            // 
            this.rb_ACSpeed_High.AutoSize = true;
            this.rb_ACSpeed_High.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_ACSpeed_High.Location = new System.Drawing.Point(204, 30);
            this.rb_ACSpeed_High.Margin = new System.Windows.Forms.Padding(4);
            this.rb_ACSpeed_High.Name = "rb_ACSpeed_High";
            this.rb_ACSpeed_High.Size = new System.Drawing.Size(55, 28);
            this.rb_ACSpeed_High.TabIndex = 2;
            this.rb_ACSpeed_High.TabStop = true;
            this.rb_ACSpeed_High.Text = "高";
            this.rb_ACSpeed_High.UseVisualStyleBackColor = true;
            // 
            // rb_ACSpeed_Low
            // 
            this.rb_ACSpeed_Low.AutoSize = true;
            this.rb_ACSpeed_Low.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_ACSpeed_Low.Location = new System.Drawing.Point(12, 29);
            this.rb_ACSpeed_Low.Margin = new System.Windows.Forms.Padding(4);
            this.rb_ACSpeed_Low.Name = "rb_ACSpeed_Low";
            this.rb_ACSpeed_Low.Size = new System.Drawing.Size(55, 28);
            this.rb_ACSpeed_Low.TabIndex = 0;
            this.rb_ACSpeed_Low.TabStop = true;
            this.rb_ACSpeed_Low.Text = "低";
            this.rb_ACSpeed_Low.UseVisualStyleBackColor = true;
            // 
            // rb_ACSpeed_Mid
            // 
            this.rb_ACSpeed_Mid.AutoSize = true;
            this.rb_ACSpeed_Mid.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_ACSpeed_Mid.Location = new System.Drawing.Point(108, 29);
            this.rb_ACSpeed_Mid.Margin = new System.Windows.Forms.Padding(4);
            this.rb_ACSpeed_Mid.Name = "rb_ACSpeed_Mid";
            this.rb_ACSpeed_Mid.Size = new System.Drawing.Size(55, 28);
            this.rb_ACSpeed_Mid.TabIndex = 1;
            this.rb_ACSpeed_Mid.TabStop = true;
            this.rb_ACSpeed_Mid.Text = "中";
            this.rb_ACSpeed_Mid.UseVisualStyleBackColor = true;
            // 
            // gb_AC_mode
            // 
            this.gb_AC_mode.Controls.Add(this.rb_ACFan);
            this.gb_AC_mode.Controls.Add(this.rb_ACHeat);
            this.gb_AC_mode.Controls.Add(this.rb_ACCool);
            this.gb_AC_mode.Controls.Add(this.rb_ACDry);
            this.gb_AC_mode.Location = new System.Drawing.Point(8, 106);
            this.gb_AC_mode.Margin = new System.Windows.Forms.Padding(4);
            this.gb_AC_mode.Name = "gb_AC_mode";
            this.gb_AC_mode.Padding = new System.Windows.Forms.Padding(4);
            this.gb_AC_mode.Size = new System.Drawing.Size(392, 75);
            this.gb_AC_mode.TabIndex = 1;
            this.gb_AC_mode.TabStop = false;
            this.gb_AC_mode.Text = "運転モード";
            // 
            // rb_ACFan
            // 
            this.rb_ACFan.AutoSize = true;
            this.rb_ACFan.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_ACFan.Location = new System.Drawing.Point(204, 29);
            this.rb_ACFan.Margin = new System.Windows.Forms.Padding(4);
            this.rb_ACFan.Name = "rb_ACFan";
            this.rb_ACFan.Size = new System.Drawing.Size(79, 28);
            this.rb_ACFan.TabIndex = 2;
            this.rb_ACFan.TabStop = true;
            this.rb_ACFan.Text = "送風";
            this.rb_ACFan.UseVisualStyleBackColor = true;
            // 
            // rb_ACHeat
            // 
            this.rb_ACHeat.AutoSize = true;
            this.rb_ACHeat.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_ACHeat.Location = new System.Drawing.Point(300, 29);
            this.rb_ACHeat.Margin = new System.Windows.Forms.Padding(4);
            this.rb_ACHeat.Name = "rb_ACHeat";
            this.rb_ACHeat.Size = new System.Drawing.Size(79, 28);
            this.rb_ACHeat.TabIndex = 3;
            this.rb_ACHeat.TabStop = true;
            this.rb_ACHeat.Text = "暖房";
            this.rb_ACHeat.UseVisualStyleBackColor = true;
            // 
            // rb_ACCool
            // 
            this.rb_ACCool.AutoSize = true;
            this.rb_ACCool.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_ACCool.Location = new System.Drawing.Point(12, 29);
            this.rb_ACCool.Margin = new System.Windows.Forms.Padding(4);
            this.rb_ACCool.Name = "rb_ACCool";
            this.rb_ACCool.Size = new System.Drawing.Size(79, 28);
            this.rb_ACCool.TabIndex = 0;
            this.rb_ACCool.TabStop = true;
            this.rb_ACCool.Text = "冷房";
            this.rb_ACCool.UseVisualStyleBackColor = true;
            // 
            // rb_ACDry
            // 
            this.rb_ACDry.AutoSize = true;
            this.rb_ACDry.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_ACDry.Location = new System.Drawing.Point(108, 29);
            this.rb_ACDry.Margin = new System.Windows.Forms.Padding(4);
            this.rb_ACDry.Name = "rb_ACDry";
            this.rb_ACDry.Size = new System.Drawing.Size(79, 28);
            this.rb_ACDry.TabIndex = 1;
            this.rb_ACDry.TabStop = true;
            this.rb_ACDry.Text = "除湿";
            this.rb_ACDry.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(15, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "温度設定";
            // 
            // nud_temperatureSet
            // 
            this.nud_temperatureSet.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nud_temperatureSet.Location = new System.Drawing.Point(152, 274);
            this.nud_temperatureSet.Margin = new System.Windows.Forms.Padding(4);
            this.nud_temperatureSet.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nud_temperatureSet.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nud_temperatureSet.Name = "nud_temperatureSet";
            this.nud_temperatureSet.Size = new System.Drawing.Size(61, 31);
            this.nud_temperatureSet.TabIndex = 4;
            this.nud_temperatureSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_temperatureSet.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // SwitchBotRemote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 700);
            this.Controls.Add(this.gb_AC);
            this.Controls.Add(this.gb_light);
            this.Controls.Add(this.gb_speaker);
            this.Controls.Add(this.gb_TV);
            this.Controls.Add(this.tb_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SwitchBotRemote";
            this.Text = "リビング用リモコン";
            this.gb_TV.ResumeLayout(false);
            this.gb_TV.PerformLayout();
            this.gb_speaker.ResumeLayout(false);
            this.gb_speaker.PerformLayout();
            this.gb_light.ResumeLayout(false);
            this.gb_AC.ResumeLayout(false);
            this.gb_AC.PerformLayout();
            this.gb_AC_power.ResumeLayout(false);
            this.gb_AC_power.PerformLayout();
            this.gb_AC_speed.ResumeLayout(false);
            this.gb_AC_speed.PerformLayout();
            this.gb_AC_mode.ResumeLayout(false);
            this.gb_AC_mode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_temperatureSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_channelUp;
        private System.Windows.Forms.Button btn_channelDown;
        private System.Windows.Forms.Button btn_TVPower;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.GroupBox gb_TV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_volumeDown;
        private System.Windows.Forms.Button btn_volumeUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_channel12;
        private System.Windows.Forms.Button btn_channel11;
        private System.Windows.Forms.Button btn_channel10;
        private System.Windows.Forms.Button btn_channel9;
        private System.Windows.Forms.Button btn_channel8;
        private System.Windows.Forms.Button btn_channel7;
        private System.Windows.Forms.Button btn_channel6;
        private System.Windows.Forms.Button btn_channel5;
        private System.Windows.Forms.Button btn_channel4;
        private System.Windows.Forms.Button btn_channel3;
        private System.Windows.Forms.Button btn_channel2;
        private System.Windows.Forms.Button btn_channel1;
        private System.Windows.Forms.Button btn_cs;
        private System.Windows.Forms.Button btn_bs;
        private System.Windows.Forms.Button btn_digital;
        private System.Windows.Forms.GroupBox gb_speaker;
        private System.Windows.Forms.Button btn_speakerBass;
        private System.Windows.Forms.Button btn_speakerNews;
        private System.Windows.Forms.Button btn_speakerCinema;
        private System.Windows.Forms.Button btn_speakerVerticalS;
        private System.Windows.Forms.Button btn_speakerAuto;
        private System.Windows.Forms.Button btn_speakerInput;
        private System.Windows.Forms.Button btn_speakerPower;
        private System.Windows.Forms.Button btn_speakerVolumeDown;
        private System.Windows.Forms.Button btn_speakerVolumeUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_10key;
        private System.Windows.Forms.GroupBox gb_light;
        private System.Windows.Forms.Button btn_lightEnergySaving;
        private System.Windows.Forms.Button btn_lightBrightness;
        private System.Windows.Forms.Button btn_lightOnOff;
        private System.Windows.Forms.Button btn_lightNight;
        private System.Windows.Forms.GroupBox gb_AC;
        private System.Windows.Forms.RadioButton rb_ACDry;
        private System.Windows.Forms.RadioButton rb_ACCool;
        private System.Windows.Forms.RadioButton rb_ACHeat;
        private System.Windows.Forms.GroupBox gb_AC_speed;
        private System.Windows.Forms.RadioButton rb_ACSpeed_Auto;
        private System.Windows.Forms.RadioButton rb_ACSpeed_High;
        private System.Windows.Forms.RadioButton rb_ACSpeed_Low;
        private System.Windows.Forms.RadioButton rb_ACSpeed_Mid;
        private System.Windows.Forms.GroupBox gb_AC_mode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_temperatureSet;
        private System.Windows.Forms.Button btn_ACSend;
        private System.Windows.Forms.GroupBox gb_AC_power;
        private System.Windows.Forms.RadioButton rb_ACON;
        private System.Windows.Forms.RadioButton rb_ACOff;
        private System.Windows.Forms.Button btn_ChannelList;
        private System.Windows.Forms.RadioButton rb_ACFan;
        private System.Windows.Forms.Label label5;
    }
}

