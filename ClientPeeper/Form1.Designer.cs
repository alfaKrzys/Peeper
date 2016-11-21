namespace ClientPeeper
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
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.l_ip = new System.Windows.Forms.Label();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.l_port = new System.Windows.Forms.Label();
            this.b_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_picture
            // 
            this.pb_picture.Location = new System.Drawing.Point(13, 13);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(322, 200);
            this.pb_picture.TabIndex = 0;
            this.pb_picture.TabStop = false;
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(36, 223);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(100, 20);
            this.tb_ip.TabIndex = 6;
            this.tb_ip.Text = "224.0.1.9";
            // 
            // l_ip
            // 
            this.l_ip.AutoSize = true;
            this.l_ip.Location = new System.Drawing.Point(10, 226);
            this.l_ip.Name = "l_ip";
            this.l_ip.Size = new System.Drawing.Size(20, 13);
            this.l_ip.TabIndex = 5;
            this.l_ip.Text = "IP:";
            // 
            // nud_port
            // 
            this.nud_port.Location = new System.Drawing.Point(177, 224);
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
            this.nud_port.TabIndex = 8;
            this.nud_port.Value = new decimal(new int[] {
            5555,
            0,
            0,
            0});
            // 
            // l_port
            // 
            this.l_port.AutoSize = true;
            this.l_port.Location = new System.Drawing.Point(142, 226);
            this.l_port.Name = "l_port";
            this.l_port.Size = new System.Drawing.Size(29, 13);
            this.l_port.TabIndex = 7;
            this.l_port.Text = "Port:";
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(285, 220);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(50, 23);
            this.b_start.TabIndex = 9;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 251);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.nud_port);
            this.Controls.Add(this.l_port);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.l_ip);
            this.Controls.Add(this.pb_picture);
            this.Name = "Form1";
            this.Text = "Pepper Client";
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label l_ip;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.Label l_port;
        private System.Windows.Forms.Button b_start;
    }
}

