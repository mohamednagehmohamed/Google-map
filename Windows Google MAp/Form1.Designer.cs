namespace Windows_Google_MAp
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
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.LAtitude = new System.Windows.Forms.Label();
            this.txtlong = new System.Windows.Forms.TextBox();
            this.txtlat = new System.Windows.Forms.TextBox();
            this.Longitude = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lbldistance = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblmove = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picmin = new System.Windows.Forms.PictureBox();
            this.picmax = new System.Windows.Forms.PictureBox();
            this.picexit = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexit)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(406, 719);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(406, 777);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(425, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "Show Map";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LAtitude
            // 
            this.LAtitude.AutoSize = true;
            this.LAtitude.ForeColor = System.Drawing.Color.DeepPink;
            this.LAtitude.Location = new System.Drawing.Point(428, 68);
            this.LAtitude.Name = "LAtitude";
            this.LAtitude.Size = new System.Drawing.Size(92, 25);
            this.LAtitude.TabIndex = 12;
            this.LAtitude.Text = "Latitude";
            // 
            // txtlong
            // 
            this.txtlong.Location = new System.Drawing.Point(546, 141);
            this.txtlong.Name = "txtlong";
            this.txtlong.Size = new System.Drawing.Size(175, 33);
            this.txtlong.TabIndex = 15;
            this.txtlong.MouseLeave += new System.EventHandler(this.txtlong_MouseLeave);
            this.txtlong.MouseHover += new System.EventHandler(this.txtlong_MouseHover);
            // 
            // txtlat
            // 
            this.txtlat.Location = new System.Drawing.Point(546, 68);
            this.txtlat.Name = "txtlat";
            this.txtlat.Size = new System.Drawing.Size(175, 33);
            this.txtlat.TabIndex = 13;
            this.txtlat.MouseLeave += new System.EventHandler(this.txtlat_MouseLeave);
            this.txtlat.MouseHover += new System.EventHandler(this.txtlat_MouseHover);
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.ForeColor = System.Drawing.Color.DeepPink;
            this.Longitude.Location = new System.Drawing.Point(428, 144);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(112, 25);
            this.Longitude.TabIndex = 14;
            this.Longitude.Text = "Longitude";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(606, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 46);
            this.button6.TabIndex = 24;
            this.button6.Text = "Remove Overlay";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(425, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 46);
            this.button5.TabIndex = 23;
            this.button5.Text = "Draw Polygon";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbldistance
            // 
            this.lbldistance.AutoSize = true;
            this.lbldistance.ForeColor = System.Drawing.Color.DeepPink;
            this.lbldistance.Location = new System.Drawing.Point(627, 314);
            this.lbldistance.Name = "lbldistance";
            this.lbldistance.Size = new System.Drawing.Size(143, 25);
            this.lbldistance.TabIndex = 22;
            this.lbldistance.Text = "Get Distance";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(425, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 46);
            this.button4.TabIndex = 21;
            this.button4.Text = "Get Route";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(425, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 46);
            this.button3.TabIndex = 20;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(606, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 46);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add Point";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.richTextBox1.Location = new System.Drawing.Point(425, 448);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(440, 268);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.richTextBox1.MouseHover += new System.EventHandler(this.richTextBox1_MouseHover);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.checkBox1.Location = new System.Drawing.Point(425, 414);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(240, 29);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Enable Mouse Clicks";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lblmove
            // 
            this.lblmove.AutoSize = true;
            this.lblmove.ForeColor = System.Drawing.Color.Yellow;
            this.lblmove.Location = new System.Drawing.Point(564, 9);
            this.lblmove.Name = "lblmove";
            this.lblmove.Size = new System.Drawing.Size(191, 25);
            this.lblmove.TabIndex = 27;
            this.lblmove.Text = "Google Map App";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picmin
            // 
            this.picmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picmin.Image = global::Windows_Google_MAp.Properties.Resources.download__7_;
            this.picmin.Location = new System.Drawing.Point(803, 104);
            this.picmin.Name = "picmin";
            this.picmin.Size = new System.Drawing.Size(47, 40);
            this.picmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmin.TabIndex = 29;
            this.picmin.TabStop = false;
            this.picmin.Tag = "pic";
            this.picmin.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // picmax
            // 
            this.picmax.BackColor = System.Drawing.Color.Teal;
            this.picmax.Image = global::Windows_Google_MAp.Properties.Resources.download__2_1;
            this.picmax.Location = new System.Drawing.Point(797, 51);
            this.picmax.Name = "picmax";
            this.picmax.Size = new System.Drawing.Size(59, 50);
            this.picmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmax.TabIndex = 28;
            this.picmax.TabStop = false;
            this.picmax.Tag = "pic";
            this.picmax.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // picexit
            // 
            this.picexit.Image = global::Windows_Google_MAp.Properties.Resources.download__2_;
            this.picexit.Location = new System.Drawing.Point(777, 0);
            this.picexit.Name = "picexit";
            this.picexit.Size = new System.Drawing.Size(100, 50);
            this.picexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picexit.TabIndex = 17;
            this.picexit.TabStop = false;
            this.picexit.Tag = "pic";
            this.picexit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkOrange;
            this.button7.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(606, 362);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 46);
            this.button7.TabIndex = 30;
            this.button7.Text = "Search Inside Polygon";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(877, 719);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.picmin);
            this.Controls.Add(this.picmax);
            this.Controls.Add(this.lblmove);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lbldistance);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picexit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LAtitude);
            this.Controls.Add(this.txtlong);
            this.Controls.Add(this.txtlat);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LAtitude;
        private System.Windows.Forms.TextBox txtlong;
        private System.Windows.Forms.TextBox txtlat;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.PictureBox picexit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbldistance;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblmove;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picmax;
        private System.Windows.Forms.PictureBox picmin;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer timer2;
    }
}

