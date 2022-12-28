namespace colorPicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox1;
            this.textBox_ChangeRed = new System.Windows.Forms.TextBox();
            this.trackBar_Blue = new System.Windows.Forms.TrackBar();
            this.trackBar_Green = new System.Windows.Forms.TrackBar();
            this.trackBar_Red = new System.Windows.Forms.TrackBar();
            this.textBoxBlueValue = new System.Windows.Forms.TextBox();
            this.textBoxGreenValue = new System.Windows.Forms.TextBox();
            this.textBoxRedValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPickedColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRGBValues = new System.Windows.Forms.Label();
            this.lbSmallScreen = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKValue = new System.Windows.Forms.TextBox();
            this.textBoxYValue = new System.Windows.Forms.TextBox();
            this.textBoxMValue = new System.Windows.Forms.TextBox();
            this.textBoxCValue = new System.Windows.Forms.TextBox();
            this.trackBar_K = new System.Windows.Forms.TrackBar();
            this.trackBar_Y = new System.Windows.Forms.TrackBar();
            this.trackBar_M = new System.Windows.Forms.TrackBar();
            this.trackBar_C = new System.Windows.Forms.TrackBar();
            this.lbCMYKValues = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_K)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_C)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.textBox_ChangeRed);
            groupBox1.Controls.Add(this.trackBar_Blue);
            groupBox1.Controls.Add(this.trackBar_Green);
            groupBox1.Controls.Add(this.trackBar_Red);
            groupBox1.Controls.Add(this.textBoxBlueValue);
            groupBox1.Controls.Add(this.textBoxGreenValue);
            groupBox1.Controls.Add(this.textBoxRedValue);
            groupBox1.Controls.Add(this.label4);
            groupBox1.Controls.Add(this.label3);
            groupBox1.Controls.Add(this.label2);
            groupBox1.Location = new System.Drawing.Point(12, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(854, 220);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Picked Color RGB";
            // 
            // textBox_ChangeRed
            // 
            this.textBox_ChangeRed.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_ChangeRed.Location = new System.Drawing.Point(493, 42);
            this.textBox_ChangeRed.Name = "textBox_ChangeRed";
            this.textBox_ChangeRed.Size = new System.Drawing.Size(102, 31);
            this.textBox_ChangeRed.TabIndex = 14;
            this.textBox_ChangeRed.TextChanged += new System.EventHandler(this.textBox_ChangeRed_TextChanged);
            // 
            // trackBar_Blue
            // 
            this.trackBar_Blue.Location = new System.Drawing.Point(158, 147);
            this.trackBar_Blue.Maximum = 255;
            this.trackBar_Blue.Name = "trackBar_Blue";
            this.trackBar_Blue.Size = new System.Drawing.Size(329, 69);
            this.trackBar_Blue.TabIndex = 13;
            this.trackBar_Blue.Scroll += new System.EventHandler(this.trackBar_Blue_Scroll);
            // 
            // trackBar_Green
            // 
            this.trackBar_Green.Location = new System.Drawing.Point(158, 93);
            this.trackBar_Green.Maximum = 255;
            this.trackBar_Green.Name = "trackBar_Green";
            this.trackBar_Green.Size = new System.Drawing.Size(329, 69);
            this.trackBar_Green.TabIndex = 12;
            this.trackBar_Green.Scroll += new System.EventHandler(this.trackBar_Green_Scroll);
            // 
            // trackBar_Red
            // 
            this.trackBar_Red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Red.Location = new System.Drawing.Point(158, 42);
            this.trackBar_Red.Maximum = 255;
            this.trackBar_Red.Name = "trackBar_Red";
            this.trackBar_Red.Size = new System.Drawing.Size(329, 69);
            this.trackBar_Red.TabIndex = 0;
            this.trackBar_Red.Scroll += new System.EventHandler(this.trackBar_Red_Scroll);
            // 
            // textBoxBlueValue
            // 
            this.textBoxBlueValue.Location = new System.Drawing.Point(86, 141);
            this.textBoxBlueValue.Name = "textBoxBlueValue";
            this.textBoxBlueValue.ReadOnly = true;
            this.textBoxBlueValue.Size = new System.Drawing.Size(71, 31);
            this.textBoxBlueValue.TabIndex = 10;
            // 
            // textBoxGreenValue
            // 
            this.textBoxGreenValue.Location = new System.Drawing.Point(86, 90);
            this.textBoxGreenValue.Name = "textBoxGreenValue";
            this.textBoxGreenValue.ReadOnly = true;
            this.textBoxGreenValue.Size = new System.Drawing.Size(71, 31);
            this.textBoxGreenValue.TabIndex = 9;
            // 
            // textBoxRedValue
            // 
            this.textBoxRedValue.Location = new System.Drawing.Point(86, 42);
            this.textBoxRedValue.Name = "textBoxRedValue";
            this.textBoxRedValue.ReadOnly = true;
            this.textBoxRedValue.Size = new System.Drawing.Size(77, 31);
            this.textBoxRedValue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Red";
            // 
            // panelPickedColor
            // 
            this.panelPickedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPickedColor.Location = new System.Drawing.Point(579, 152);
            this.panelPickedColor.Name = "panelPickedColor";
            this.panelPickedColor.Size = new System.Drawing.Size(148, 136);
            this.panelPickedColor.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Picker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::colorPicker.Properties.Resources.rgbSpectrum;
            this.pictureBox1.Location = new System.Drawing.Point(320, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // lbRGBValues
            // 
            this.lbRGBValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRGBValues.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRGBValues.Location = new System.Drawing.Point(41, 65);
            this.lbRGBValues.Name = "lbRGBValues";
            this.lbRGBValues.Size = new System.Drawing.Size(226, 45);
            this.lbRGBValues.TabIndex = 2;
            // 
            // lbSmallScreen
            // 
            this.lbSmallScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSmallScreen.Location = new System.Drawing.Point(579, 65);
            this.lbSmallScreen.Name = "lbSmallScreen";
            this.lbSmallScreen.Size = new System.Drawing.Size(148, 40);
            this.lbSmallScreen.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxKValue);
            this.groupBox2.Controls.Add(this.textBoxYValue);
            this.groupBox2.Controls.Add(this.textBoxMValue);
            this.groupBox2.Controls.Add(this.textBoxCValue);
            this.groupBox2.Controls.Add(this.trackBar_K);
            this.groupBox2.Controls.Add(this.trackBar_Y);
            this.groupBox2.Controls.Add(this.trackBar_M);
            this.groupBox2.Controls.Add(this.trackBar_C);
            this.groupBox2.Location = new System.Drawing.Point(12, 550);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 263);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picked Color CMYK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Yellow";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Magenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cyan";
            // 
            // textBoxKValue
            // 
            this.textBoxKValue.Location = new System.Drawing.Point(86, 194);
            this.textBoxKValue.Name = "textBoxKValue";
            this.textBoxKValue.ReadOnly = true;
            this.textBoxKValue.Size = new System.Drawing.Size(66, 31);
            this.textBoxKValue.TabIndex = 20;
            // 
            // textBoxYValue
            // 
            this.textBoxYValue.Location = new System.Drawing.Point(86, 139);
            this.textBoxYValue.Name = "textBoxYValue";
            this.textBoxYValue.ReadOnly = true;
            this.textBoxYValue.Size = new System.Drawing.Size(67, 31);
            this.textBoxYValue.TabIndex = 19;
            // 
            // textBoxMValue
            // 
            this.textBoxMValue.Location = new System.Drawing.Point(86, 85);
            this.textBoxMValue.Name = "textBoxMValue";
            this.textBoxMValue.ReadOnly = true;
            this.textBoxMValue.Size = new System.Drawing.Size(66, 31);
            this.textBoxMValue.TabIndex = 18;
            // 
            // textBoxCValue
            // 
            this.textBoxCValue.Location = new System.Drawing.Point(86, 30);
            this.textBoxCValue.Name = "textBoxCValue";
            this.textBoxCValue.ReadOnly = true;
            this.textBoxCValue.Size = new System.Drawing.Size(67, 31);
            this.textBoxCValue.TabIndex = 17;
            // 
            // trackBar_K
            // 
            this.trackBar_K.Location = new System.Drawing.Point(158, 194);
            this.trackBar_K.Maximum = 100;
            this.trackBar_K.Name = "trackBar_K";
            this.trackBar_K.Size = new System.Drawing.Size(329, 69);
            this.trackBar_K.TabIndex = 0;
            this.trackBar_K.Scroll += new System.EventHandler(this.trackBar_K_Scroll);
            // 
            // trackBar_Y
            // 
            this.trackBar_Y.Location = new System.Drawing.Point(158, 139);
            this.trackBar_Y.Maximum = 100;
            this.trackBar_Y.Name = "trackBar_Y";
            this.trackBar_Y.Size = new System.Drawing.Size(329, 69);
            this.trackBar_Y.TabIndex = 16;
            this.trackBar_Y.Scroll += new System.EventHandler(this.trackBar_Y_Scroll);
            // 
            // trackBar_M
            // 
            this.trackBar_M.Location = new System.Drawing.Point(158, 85);
            this.trackBar_M.Maximum = 100;
            this.trackBar_M.Name = "trackBar_M";
            this.trackBar_M.Size = new System.Drawing.Size(329, 69);
            this.trackBar_M.TabIndex = 15;
            this.trackBar_M.Scroll += new System.EventHandler(this.trackBar_M_Scroll);
            // 
            // trackBar_C
            // 
            this.trackBar_C.Location = new System.Drawing.Point(158, 30);
            this.trackBar_C.Maximum = 100;
            this.trackBar_C.Name = "trackBar_C";
            this.trackBar_C.Size = new System.Drawing.Size(329, 69);
            this.trackBar_C.TabIndex = 14;
            this.trackBar_C.Scroll += new System.EventHandler(this.trackBar_C_Scroll);
            // 
            // lbCMYKValues
            // 
            this.lbCMYKValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCMYKValues.Location = new System.Drawing.Point(41, 152);
            this.lbCMYKValues.Name = "lbCMYKValues";
            this.lbCMYKValues.Size = new System.Drawing.Size(226, 45);
            this.lbCMYKValues.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 844);
            this.Controls.Add(this.lbCMYKValues);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.lbSmallScreen);
            this.Controls.Add(this.panelPickedColor);
            this.Controls.Add(this.lbRGBValues);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Color Picker";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_K)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_C)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label lbRGBValues;
        private Label lbSmallScreen;
        private Panel panelPickedColor;
        private TextBox textBoxBlueValue;
        private TextBox textBoxGreenValue;
        private TextBox textBoxRedValue;
        private Label label4;
        private Label label3;
        private Label label2;
        private TrackBar trackBar_Blue;
        private TrackBar trackBar_Green;
        private TrackBar trackBar_Red;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox2;
        private TrackBar trackBar_K;
        private TrackBar trackBar_Y;
        private TrackBar trackBar_M;
        private TrackBar trackBar_C;
        private TextBox textBoxCValue;
        private TextBox textBoxKValue;
        private TextBox textBoxYValue;
        private TextBox textBoxMValue;
        private Label lbCMYKValues;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox_ChangeRed;
    }
}