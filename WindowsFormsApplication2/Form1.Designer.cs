namespace WindowsFormsApplication2
{
    partial class IPhelpForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPhelpForm));
            this.IPv4address = new System.Windows.Forms.Label();
            this.IPv6address = new System.Windows.Forms.Label();
            this.IPv4addressheadline = new System.Windows.Forms.Label();
            this.IPv6addressheadline = new System.Windows.Forms.Label();
            this.machinelabel = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appversion = new System.Windows.Forms.Label();
            this.systemuptime = new System.Windows.Forms.Label();
            this.ticktimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IPv4address
            // 
            this.IPv4address.AutoSize = true;
            this.IPv4address.BackColor = System.Drawing.Color.Transparent;
            this.IPv4address.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IPv4address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPv4address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.IPv4address.Location = new System.Drawing.Point(0, 20);
            this.IPv4address.Margin = new System.Windows.Forms.Padding(0);
            this.IPv4address.Name = "IPv4address";
            this.IPv4address.Size = new System.Drawing.Size(218, 31);
            this.IPv4address.TabIndex = 0;
            this.IPv4address.Text = "255.255.255.255";
            // 
            // IPv6address
            // 
            this.IPv6address.AutoSize = true;
            this.IPv6address.BackColor = System.Drawing.Color.Transparent;
            this.IPv6address.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPv6address.ForeColor = System.Drawing.Color.White;
            this.IPv6address.Location = new System.Drawing.Point(0, 85);
            this.IPv6address.Margin = new System.Windows.Forms.Padding(0);
            this.IPv6address.Name = "IPv6address";
            this.IPv6address.Size = new System.Drawing.Size(252, 15);
            this.IPv6address.TabIndex = 1;
            this.IPv6address.Text = "0000:0000:0000:0000:0000:0000:0000:0000";
            // 
            // IPv4addressheadline
            // 
            this.IPv4addressheadline.AutoSize = true;
            this.IPv4addressheadline.BackColor = System.Drawing.Color.Transparent;
            this.IPv4addressheadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPv4addressheadline.ForeColor = System.Drawing.Color.DarkGray;
            this.IPv4addressheadline.Location = new System.Drawing.Point(0, 0);
            this.IPv4addressheadline.Margin = new System.Windows.Forms.Padding(0);
            this.IPv4addressheadline.Name = "IPv4addressheadline";
            this.IPv4addressheadline.Size = new System.Drawing.Size(56, 17);
            this.IPv4addressheadline.TabIndex = 2;
            this.IPv4addressheadline.Text = "Primary";
            // 
            // IPv6addressheadline
            // 
            this.IPv6addressheadline.AutoSize = true;
            this.IPv6addressheadline.BackColor = System.Drawing.Color.Transparent;
            this.IPv6addressheadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPv6addressheadline.ForeColor = System.Drawing.Color.DarkGray;
            this.IPv6addressheadline.Location = new System.Drawing.Point(0, 65);
            this.IPv6addressheadline.Margin = new System.Windows.Forms.Padding(0);
            this.IPv6addressheadline.Name = "IPv6addressheadline";
            this.IPv6addressheadline.Size = new System.Drawing.Size(65, 17);
            this.IPv6addressheadline.TabIndex = 3;
            this.IPv6addressheadline.Text = "Alternate";
            // 
            // machinelabel
            // 
            this.machinelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.machinelabel.AutoSize = true;
            this.machinelabel.BackColor = System.Drawing.Color.Transparent;
            this.machinelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machinelabel.ForeColor = System.Drawing.Color.White;
            this.machinelabel.Location = new System.Drawing.Point(284, 20);
            this.machinelabel.Margin = new System.Windows.Forms.Padding(0);
            this.machinelabel.Name = "machinelabel";
            this.machinelabel.Size = new System.Drawing.Size(87, 45);
            this.machinelabel.TabIndex = 5;
            this.machinelabel.Text = "Machinename\r\nManifacture\r\nType";
            // 
            // closebutton
            // 
            this.closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.closebutton.BackColor = System.Drawing.Color.LightGray;
            this.closebutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.closebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.Location = new System.Drawing.Point(283, 88);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(89, 39);
            this.closebutton.TabIndex = 6;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.userlabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.closebutton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.IPv6address, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.IPv6addressheadline, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IPv4addressheadline, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IPv4address, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.machinelabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 130);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // userlabel
            // 
            this.userlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.ForeColor = System.Drawing.Color.White;
            this.userlabel.Location = new System.Drawing.Point(287, 0);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(82, 20);
            this.userlabel.TabIndex = 10;
            this.userlabel.Text = "user \\ domain";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // appversion
            // 
            this.appversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appversion.AutoSize = true;
            this.appversion.ForeColor = System.Drawing.Color.Silver;
            this.appversion.Location = new System.Drawing.Point(303, 20);
            this.appversion.Name = "appversion";
            this.appversion.Size = new System.Drawing.Size(54, 17);
            this.appversion.TabIndex = 10;
            this.appversion.Text = "version";
            // 
            // systemuptime
            // 
            this.systemuptime.AutoSize = true;
            this.systemuptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemuptime.ForeColor = System.Drawing.Color.Silver;
            this.systemuptime.Location = new System.Drawing.Point(20, 65);
            this.systemuptime.Name = "systemuptime";
            this.systemuptime.Size = new System.Drawing.Size(65, 15);
            this.systemuptime.TabIndex = 11;
            this.systemuptime.Text = "Since boot";
            // 
            // ticktimer
            // 
            this.ticktimer.Enabled = true;
            this.ticktimer.Tick += new System.EventHandler(this.ticktimer_Tick);
            // 
            // IPhelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(451, 259);
            this.ControlBox = false;
            this.Controls.Add(this.systemuptime);
            this.Controls.Add(this.appversion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPhelpForm";
            this.Opacity = 0.8D;
            this.Padding = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danisco IPhelp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPv4address;
        private System.Windows.Forms.Label IPv6address;
        private System.Windows.Forms.Label IPv4addressheadline;
        private System.Windows.Forms.Label IPv6addressheadline;
        private System.Windows.Forms.Label machinelabel;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label appversion;
        private System.Windows.Forms.Label systemuptime;
        private System.Windows.Forms.Timer ticktimer;
    }
}

