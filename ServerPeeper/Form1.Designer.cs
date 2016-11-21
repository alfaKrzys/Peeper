namespace ServerPeeper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_preview = new System.Windows.Forms.GroupBox();
            this.cb_stop = new System.Windows.Forms.CheckBox();
            this.cb_preview = new System.Windows.Forms.CheckBox();
            this.lb_devices = new System.Windows.Forms.ListBox();
            this.gb_streaming = new System.Windows.Forms.GroupBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.l_ip = new System.Windows.Forms.Label();
            this.b_stream = new System.Windows.Forms.Button();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.l_port = new System.Windows.Forms.Label();
            this.pb_preview = new System.Windows.Forms.PictureBox();
            this.l_instrukcja = new System.Windows.Forms.Label();
            this.gb_preview.SuspendLayout();
            this.gb_streaming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_preview
            // 
            this.gb_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_preview.Controls.Add(this.cb_stop);
            this.gb_preview.Controls.Add(this.cb_preview);
            this.gb_preview.Controls.Add(this.lb_devices);
            this.gb_preview.Location = new System.Drawing.Point(340, 13);
            this.gb_preview.Name = "gb_preview";
            this.gb_preview.Size = new System.Drawing.Size(232, 200);
            this.gb_preview.TabIndex = 1;
            this.gb_preview.TabStop = false;
            this.gb_preview.Text = "Preview Panel";
            // 
            // cb_stop
            // 
            this.cb_stop.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_stop.AutoSize = true;
            this.cb_stop.Image = global::ServerPeeper.Properties.Resources.button_stop_blue;
            this.cb_stop.Location = new System.Drawing.Point(112, 140);
            this.cb_stop.Name = "cb_stop";
            this.cb_stop.Size = new System.Drawing.Size(54, 54);
            this.cb_stop.TabIndex = 3;
            this.cb_stop.Text = " ";
            this.cb_stop.UseVisualStyleBackColor = true;
            this.cb_stop.CheckedChanged += new System.EventHandler(this.cb_stop_CheckedChanged);
            // 
            // cb_preview
            // 
            this.cb_preview.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_preview.AutoSize = true;
            this.cb_preview.Image = global::ServerPeeper.Properties.Resources.button_play_blue;
            this.cb_preview.Location = new System.Drawing.Point(172, 140);
            this.cb_preview.Name = "cb_preview";
            this.cb_preview.Size = new System.Drawing.Size(54, 54);
            this.cb_preview.TabIndex = 2;
            this.cb_preview.Text = " ";
            this.cb_preview.UseVisualStyleBackColor = true;
            this.cb_preview.CheckedChanged += new System.EventHandler(this.cb_preview_CheckedChanged);
            // 
            // lb_devices
            // 
            this.lb_devices.FormattingEnabled = true;
            this.lb_devices.Location = new System.Drawing.Point(7, 20);
            this.lb_devices.Name = "lb_devices";
            this.lb_devices.Size = new System.Drawing.Size(219, 69);
            this.lb_devices.TabIndex = 1;
            // 
            // gb_streaming
            // 
            this.gb_streaming.Controls.Add(this.tb_ip);
            this.gb_streaming.Controls.Add(this.l_ip);
            this.gb_streaming.Controls.Add(this.b_stream);
            this.gb_streaming.Controls.Add(this.nud_port);
            this.gb_streaming.Controls.Add(this.l_port);
            this.gb_streaming.Location = new System.Drawing.Point(340, 220);
            this.gb_streaming.Name = "gb_streaming";
            this.gb_streaming.Size = new System.Drawing.Size(232, 122);
            this.gb_streaming.TabIndex = 3;
            this.gb_streaming.TabStop = false;
            this.gb_streaming.Text = "Streaming Panel";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(42, 22);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(100, 20);
            this.tb_ip.TabIndex = 4;
            this.tb_ip.Text = "224.0.1.9";
            // 
            // l_ip
            // 
            this.l_ip.AutoSize = true;
            this.l_ip.Location = new System.Drawing.Point(6, 25);
            this.l_ip.Name = "l_ip";
            this.l_ip.Size = new System.Drawing.Size(20, 13);
            this.l_ip.TabIndex = 3;
            this.l_ip.Text = "IP:";
            // 
            // b_stream
            // 
            this.b_stream.Location = new System.Drawing.Point(151, 93);
            this.b_stream.Name = "b_stream";
            this.b_stream.Size = new System.Drawing.Size(75, 23);
            this.b_stream.TabIndex = 2;
            this.b_stream.Text = "Streaming";
            this.b_stream.UseVisualStyleBackColor = true;
            this.b_stream.Click += new System.EventHandler(this.b_stream_Click);
            // 
            // nud_port
            // 
            this.nud_port.Location = new System.Drawing.Point(41, 46);
            this.nud_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nud_port.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nud_port.Name = "nud_port";
            this.nud_port.Size = new System.Drawing.Size(101, 20);
            this.nud_port.TabIndex = 1;
            this.nud_port.Value = new decimal(new int[] {
            5555,
            0,
            0,
            0});
            // 
            // l_port
            // 
            this.l_port.AutoSize = true;
            this.l_port.Location = new System.Drawing.Point(6, 48);
            this.l_port.Name = "l_port";
            this.l_port.Size = new System.Drawing.Size(29, 13);
            this.l_port.TabIndex = 0;
            this.l_port.Text = "Port:";
            // 
            // pb_preview
            // 
            this.pb_preview.Location = new System.Drawing.Point(13, 13);
            this.pb_preview.Name = "pb_preview";
            this.pb_preview.Size = new System.Drawing.Size(320, 200);
            this.pb_preview.TabIndex = 4;
            this.pb_preview.TabStop = false;
            // 
            // l_instrukcja
            // 
            this.l_instrukcja.AutoSize = true;
            this.l_instrukcja.Location = new System.Drawing.Point(12, 220);
            this.l_instrukcja.Name = "l_instrukcja";
            this.l_instrukcja.Size = new System.Drawing.Size(310, 78);
            this.l_instrukcja.TabIndex = 5;
            this.l_instrukcja.Text = resources.GetString("l_instrukcja.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.l_instrukcja);
            this.Controls.Add(this.pb_preview);
            this.Controls.Add(this.gb_streaming);
            this.Controls.Add(this.gb_preview);
            this.Name = "Form1";
            this.Text = "Peeper";
            this.gb_preview.ResumeLayout(false);
            this.gb_preview.PerformLayout();
            this.gb_streaming.ResumeLayout(false);
            this.gb_streaming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_preview;
        private System.Windows.Forms.ListBox lb_devices;
        private System.Windows.Forms.CheckBox cb_preview;
        private System.Windows.Forms.CheckBox cb_stop;
        private System.Windows.Forms.GroupBox gb_streaming;
        private System.Windows.Forms.Button b_stream;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.Label l_port;
        private System.Windows.Forms.PictureBox pb_preview;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label l_ip;
        private System.Windows.Forms.Label l_instrukcja;
    }
}

