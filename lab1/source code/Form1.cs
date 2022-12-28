namespace colorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap) pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            lbSmallScreen.BackColor = clr;
            lbRGBValues.Text = " R: " + clr.R.ToString() + " G: " + clr.G.ToString() + " B: " + clr.B.ToString();
            int k = (int)Math.Min(Math.Min(100.0d - (clr.R * 100.0d / 255.0d), 100.0d - (clr.G * 100.0d / 255.0d)), 100.0d - (clr.B * 100.0d / 255.0d));
            int c = (int)((100.0d - (clr.R * 100.0d / 255.0d) - k) * 100.0d / (100.0d - k));
            int m = (int)((100.0d - (clr.G * 100.0d / 255.0d) - k) * 100.0d / (100.0d - k));
            int y = (int)((100.0d - (clr.B * 100.0d / 255.0d) - k) * 100.0d / (100.0d - k));
            lbCMYKValues.Text = " C: " + c + " M: " + m + " Y: " + y + " K: " + k;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap) pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            textBoxRedValue.Text = clr.R.ToString();
            textBoxGreenValue.Text = clr.G.ToString();
            textBoxBlueValue.Text = clr.B.ToString();
            panelPickedColor.BackColor = clr;
            trackBar_Red.Value = clr.R;
            trackBar_Green.Value = clr.G;
            trackBar_Blue.Value = clr.B;
            trackBar_K.Value = (int)Math.Min(Math.Min(100.0d - (clr.R * 100.0d / 255.0d), 100.0d - (clr.G * 100.0d / 255.0d)), 100.0d - (clr.B * 100.0d / 255.0d));
            trackBar_C.Value = (int)((100.0d - (clr.R * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            trackBar_M.Value = (int)((100.0d - (clr.G * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            trackBar_Y.Value = (int)((100.0d - (clr.B * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            textBoxCValue.Text = trackBar_C.Value.ToString();
            textBoxMValue.Text = trackBar_M.Value.ToString();
            textBoxYValue.Text = trackBar_Y.Value.ToString();
            textBoxKValue.Text = trackBar_K.Value.ToString();
            lbCMYKValues.Text = " C: " + trackBar_C.Value.ToString() + " M: " + trackBar_M.Value.ToString() + " Y: " + trackBar_Y.Value.ToString() + " K: " + trackBar_K.Value.ToString();
        }

        private void trackBar_Red_Scroll(object sender, EventArgs e)
        {
            panelPickedColor.BackColor = Color.FromArgb(trackBar_Red.Value, trackBar_Green.Value, trackBar_Blue.Value);
            textBoxRedValue.Text = trackBar_Red.Value.ToString();
            textBoxGreenValue.Text = trackBar_Green.Value.ToString();
            textBoxBlueValue.Text = trackBar_Blue.Value.ToString();
            lbRGBValues.Text = " R: " + trackBar_Red.Value.ToString() + " G: " + trackBar_Green.Value.ToString() + " B: " + trackBar_Blue.Value.ToString();
            trackBar_K.Value = (int)Math.Min(Math.Min(100.0d - (trackBar_Red.Value * 100.0d / 255.0d), 100.0d - (trackBar_Green.Value * 100.0d / 255.0d)), 100.0d - (trackBar_Blue.Value * 100.0d / 255.0d));
            trackBar_C.Value = (int)((100.0d - (trackBar_Red.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            trackBar_M.Value = (int)((100.0d - (trackBar_Green.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            trackBar_Y.Value = (int)((100.0d - (trackBar_Blue.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            textBoxCValue.Text = trackBar_C.Value.ToString();
            textBoxMValue.Text = trackBar_M.Value.ToString();
            textBoxYValue.Text = trackBar_Y.Value.ToString();
            textBoxKValue.Text = trackBar_K.Value.ToString();
            lbCMYKValues.Text = " C: " + trackBar_C.Value.ToString() + " M: " + trackBar_M.Value.ToString() + " Y: " + trackBar_Y.Value.ToString() + " K: " + trackBar_K.Value.ToString();
        }

        private void trackBar_Green_Scroll(object sender, EventArgs e)
        {
            panelPickedColor.BackColor = Color.FromArgb(trackBar_Red.Value, trackBar_Green.Value, trackBar_Blue.Value);
            textBoxRedValue.Text = trackBar_Red.Value.ToString();
            textBoxGreenValue.Text = trackBar_Green.Value.ToString();
            textBoxBlueValue.Text = trackBar_Blue.Value.ToString();
            lbRGBValues.Text = " R: " + trackBar_Red.Value.ToString() + " G: " + trackBar_Green.Value.ToString() + " B: " + trackBar_Blue.Value.ToString();
            trackBar_K.Value = (int)Math.Min(Math.Min(100.0d - (trackBar_Red.Value * 100.0d / 255.0d), 100.0d - (trackBar_Green.Value * 100.0d / 255.0d)), 100.0d - (trackBar_Blue.Value * 100.0d / 255.0d));
            trackBar_C.Value = (int)((100.0d - (trackBar_Red.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            trackBar_M.Value = (int)((100.0d - (trackBar_Green.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            trackBar_Y.Value = (int)((100.0d - (trackBar_Blue.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            textBoxCValue.Text = trackBar_C.Value.ToString();
            textBoxMValue.Text = trackBar_M.Value.ToString();
            textBoxYValue.Text = trackBar_Y.Value.ToString();
            textBoxKValue.Text = trackBar_K.Value.ToString();
            lbCMYKValues.Text = " C: " + trackBar_C.Value.ToString() + " M: " + trackBar_M.Value.ToString() + " Y: " + trackBar_Y.Value.ToString() + " K: " + trackBar_K.Value.ToString();
        }

        private void trackBar_Blue_Scroll(object sender, EventArgs e)
        {
            panelPickedColor.BackColor = Color.FromArgb(trackBar_Red.Value, trackBar_Green.Value, trackBar_Blue.Value);
            textBoxRedValue.Text = trackBar_Red.Value.ToString();
            textBoxGreenValue.Text = trackBar_Green.Value.ToString();
            textBoxBlueValue.Text = trackBar_Blue.Value.ToString();
            lbRGBValues.Text = " R: " + trackBar_Red.Value.ToString() + " G: " + trackBar_Green.Value.ToString() + " B: " + trackBar_Blue.Value.ToString();
            trackBar_K.Value = (int)Math.Min(Math.Min(100.0d - (trackBar_Red.Value * 100.0d / 255.0d), 100.0d - (trackBar_Green.Value * 100.0d / 255.0d)), 100.0d - (trackBar_Blue.Value * 100.0d / 255.0d));
            trackBar_C.Value = (int)((100.0d - (trackBar_Red.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            trackBar_M.Value = (int)((100.0d - (trackBar_Green.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            trackBar_Y.Value = (int)((100.0d - (trackBar_Blue.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            textBoxCValue.Text = trackBar_C.Value.ToString();
            textBoxMValue.Text = trackBar_M.Value.ToString();
            textBoxYValue.Text = trackBar_Y.Value.ToString();
            textBoxKValue.Text = trackBar_K.Value.ToString();
            lbCMYKValues.Text = " C: " + trackBar_C.Value.ToString() + " M: " + trackBar_M.Value.ToString() + " Y: " + trackBar_Y.Value.ToString() + " K: " + trackBar_K.Value.ToString();
        }

        private void trackBar_C_Scroll(object sender, EventArgs e)
        {
            textBoxCValue.Text = trackBar_C.Value.ToString();
            textBoxMValue.Text = trackBar_M.Value.ToString();
            textBoxYValue.Text = trackBar_Y.Value.ToString();
            textBoxKValue.Text = trackBar_K.Value.ToString();
            trackBar_Red.Value = (int)((1.0d - (trackBar_C.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            trackBar_Green.Value = (int)((1.0d - (trackBar_M.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            trackBar_Blue.Value = (int)((1.0d - (trackBar_Y.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            textBoxRedValue.Text = trackBar_Red.Value.ToString();
            textBoxGreenValue.Text = trackBar_Green.Value.ToString();
            textBoxBlueValue.Text = trackBar_Blue.Value.ToString();
            panelPickedColor.BackColor = Color.FromArgb(trackBar_Red.Value, trackBar_Green.Value, trackBar_Blue.Value);
            lbRGBValues.Text = " R: " + trackBar_Red.Value.ToString() + " G: " + trackBar_Green.Value.ToString() + " B: " + trackBar_Blue.Value.ToString();
            lbCMYKValues.Text = " C: " + trackBar_C.Value.ToString() + " M: " + trackBar_M.Value.ToString() + " Y: " + trackBar_Y.Value.ToString() + " K: " + trackBar_K.Value.ToString();
        }

        private void trackBar_M_Scroll(object sender, EventArgs e)
        {
            textBoxCValue.Text = trackBar_C.Value.ToString();
            textBoxMValue.Text = trackBar_M.Value.ToString();
            textBoxYValue.Text = trackBar_Y.Value.ToString();
            textBoxKValue.Text = trackBar_K.Value.ToString();
            trackBar_Red.Value = (int)((1.0d - (trackBar_C.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            trackBar_Green.Value = (int)((1.0d - (trackBar_M.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            trackBar_Blue.Value = (int)((1.0d - (trackBar_Y.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            textBoxRedValue.Text = trackBar_Red.Value.ToString();
            textBoxGreenValue.Text = trackBar_Green.Value.ToString();
            textBoxBlueValue.Text = trackBar_Blue.Value.ToString();
            panelPickedColor.BackColor = Color.FromArgb(trackBar_Red.Value, trackBar_Green.Value, trackBar_Blue.Value);
            lbRGBValues.Text = " R: " + trackBar_Red.Value.ToString() + " G: " + trackBar_Green.Value.ToString() + " B: " + trackBar_Blue.Value.ToString();
            lbCMYKValues.Text = " C: " + trackBar_C.Value.ToString() + " M: " + trackBar_M.Value.ToString() + " Y: " + trackBar_Y.Value.ToString() + " K: " + trackBar_K.Value.ToString();
        }

        private void trackBar_Y_Scroll(object sender, EventArgs e)
        {
            textBoxCValue.Text = trackBar_C.Value.ToString();
            textBoxMValue.Text = trackBar_M.Value.ToString();
            textBoxYValue.Text = trackBar_Y.Value.ToString();
            textBoxKValue.Text = trackBar_K.Value.ToString();
            trackBar_Red.Value = (int)((1.0d - (trackBar_C.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            trackBar_Green.Value = (int)((1.0d - (trackBar_M.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            trackBar_Blue.Value = (int)((1.0d - (trackBar_Y.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            textBoxRedValue.Text = trackBar_Red.Value.ToString();
            textBoxGreenValue.Text = trackBar_Green.Value.ToString();
            textBoxBlueValue.Text = trackBar_Blue.Value.ToString();
            panelPickedColor.BackColor = Color.FromArgb(trackBar_Red.Value, trackBar_Green.Value, trackBar_Blue.Value);
            lbRGBValues.Text = " R: " + trackBar_Red.Value.ToString() + " G: " + trackBar_Green.Value.ToString() + " B: " + trackBar_Blue.Value.ToString();
            lbCMYKValues.Text = " C: " + trackBar_C.Value.ToString() + " M: " + trackBar_M.Value.ToString() + " Y: " + trackBar_Y.Value.ToString() + " K: " + trackBar_K.Value.ToString();
        }

        private void trackBar_K_Scroll(object sender, EventArgs e)
        {
            textBoxCValue.Text = trackBar_C.Value.ToString();
            textBoxMValue.Text = trackBar_M.Value.ToString();
            textBoxYValue.Text = trackBar_Y.Value.ToString();
            textBoxKValue.Text = trackBar_K.Value.ToString();
            trackBar_Red.Value = (int)((1.0d - (trackBar_C.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            trackBar_Green.Value = (int)((1.0d - (trackBar_M.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            trackBar_Blue.Value = (int)((1.0d - (trackBar_Y.Value / 100.0d)) * (1.0d - (trackBar_K.Value / 100.0d)) * 255.0d);
            textBoxRedValue.Text = trackBar_Red.Value.ToString();
            textBoxGreenValue.Text = trackBar_Green.Value.ToString();
            textBoxBlueValue.Text = trackBar_Blue.Value.ToString();
            panelPickedColor.BackColor = Color.FromArgb(trackBar_Red.Value, trackBar_Green.Value, trackBar_Blue.Value);
            lbRGBValues.Text = " R: " + trackBar_Red.Value.ToString() + " G: " + trackBar_Green.Value.ToString() + " B: " + trackBar_Blue.Value.ToString();
            lbCMYKValues.Text = " C: " + trackBar_C.Value.ToString() + " M: " + trackBar_M.Value.ToString() + " Y: " + trackBar_Y.Value.ToString() + " K: " + trackBar_K.Value.ToString();
        }

        private void textBox_ChangeRed_TextChanged(object sender, EventArgs e)
        {
            trackBar_Red.Value = byte.Parse(textBox_ChangeRed.Text);
            textBoxRedValue.Text = textBox_ChangeRed.Text;
            panelPickedColor.BackColor = Color.FromArgb(trackBar_Red.Value, trackBar_Green.Value, trackBar_Blue.Value);
            lbRGBValues.Text = " R: " + trackBar_Red.Value.ToString() + " G: " + trackBar_Green.Value.ToString() + " B: " + trackBar_Blue.Value.ToString();
            trackBar_K.Value = (int)Math.Min(Math.Min(100.0d - (trackBar_Red.Value * 100.0d / 255.0d), 100.0d - (trackBar_Green.Value * 100.0d / 255.0d)), 100.0d - (trackBar_Blue.Value * 100.0d / 255.0d));
            trackBar_C.Value = (int)((100.0d - (trackBar_Red.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            trackBar_M.Value = (int)((100.0d - (trackBar_Green.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            trackBar_Y.Value = (int)((100.0d - (trackBar_Blue.Value * 100.0d / 255.0d) - trackBar_K.Value) * 100.0d / (100.0d - trackBar_K.Value));
            textBoxCValue.Text = trackBar_C.Value.ToString();
            textBoxMValue.Text = trackBar_M.Value.ToString();
            textBoxYValue.Text = trackBar_Y.Value.ToString();
            textBoxKValue.Text = trackBar_K.Value.ToString();
            lbCMYKValues.Text = " C: " + trackBar_C.Value.ToString() + " M: " + trackBar_M.Value.ToString() + " Y: " + trackBar_Y.Value.ToString() + " K: " + trackBar_K.Value.ToString();
        }
    }
}