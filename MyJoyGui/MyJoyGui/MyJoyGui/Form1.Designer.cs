namespace MyJoyGui
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
            this.initalize_gamepad = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.connectLora = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarLx = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarLy = new System.Windows.Forms.TrackBar();
            this.trackBarRx = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarRy = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // initalize_gamepad
            // 
            this.initalize_gamepad.Location = new System.Drawing.Point(12, 19);
            this.initalize_gamepad.Name = "initalize_gamepad";
            this.initalize_gamepad.Size = new System.Drawing.Size(152, 57);
            this.initalize_gamepad.TabIndex = 2;
            this.initalize_gamepad.Text = "initalize gamepad";
            this.initalize_gamepad.UseVisualStyleBackColor = true;
            this.initalize_gamepad.Click += new System.EventHandler(this.initalize_gamepad_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(170, 19);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(152, 57);
            this.start.TabIndex = 5;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // connectLora
            // 
            this.connectLora.Location = new System.Drawing.Point(12, 252);
            this.connectLora.Name = "connectLora";
            this.connectLora.Size = new System.Drawing.Size(152, 57);
            this.connectLora.TabIndex = 7;
            this.connectLora.Text = "Connect To LORA";
            this.connectLora.UseVisualStyleBackColor = true;
            this.connectLora.Click += new System.EventHandler(this.connectLora_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(12, 85);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(152, 57);
            this.stop.TabIndex = 8;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Location = new System.Drawing.Point(328, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(953, 571);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarLx
            // 
            this.trackBarLx.Location = new System.Drawing.Point(479, 73);
            this.trackBarLx.Maximum = 65536;
            this.trackBarLx.Name = "trackBarLx";
            this.trackBarLx.Size = new System.Drawing.Size(302, 69);
            this.trackBarLx.TabIndex = 11;
            this.trackBarLx.Value = 4554;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(530, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Left Controller ";
            // 
            // trackBarLy
            // 
            this.trackBarLy.Cursor = System.Windows.Forms.Cursors.No;
            this.trackBarLy.Location = new System.Drawing.Point(404, 73);
            this.trackBarLy.Maximum = 0;
            this.trackBarLy.Minimum = -65536;
            this.trackBarLy.Name = "trackBarLy";
            this.trackBarLy.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarLy.Size = new System.Drawing.Size(69, 302);
            this.trackBarLy.SmallChange = 0;
            this.trackBarLy.TabIndex = 14;
            // 
            // trackBarRx
            // 
            this.trackBarRx.Location = new System.Drawing.Point(894, 73);
            this.trackBarRx.Maximum = 65536;
            this.trackBarRx.Name = "trackBarRx";
            this.trackBarRx.Size = new System.Drawing.Size(302, 69);
            this.trackBarRx.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(934, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Right Controller";
            // 
            // trackBarRy
            // 
            this.trackBarRy.Cursor = System.Windows.Forms.Cursors.No;
            this.trackBarRy.Location = new System.Drawing.Point(819, 73);
            this.trackBarRy.Maximum = 0;
            this.trackBarRy.Minimum = -65536;
            this.trackBarRy.Name = "trackBarRy";
            this.trackBarRy.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarRy.Size = new System.Drawing.Size(69, 302);
            this.trackBarRy.TabIndex = 17;
            this.trackBarRy.Value = -65500;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(894, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 227);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox3.Location = new System.Drawing.Point(479, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(302, 227);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1293, 595);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trackBarRy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarRx);
            this.Controls.Add(this.trackBarLy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarLx);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.connectLora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.initalize_gamepad);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button initalize_gamepad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connectLora;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarLx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarLy;
        private System.Windows.Forms.TrackBar trackBarRx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarRy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}

