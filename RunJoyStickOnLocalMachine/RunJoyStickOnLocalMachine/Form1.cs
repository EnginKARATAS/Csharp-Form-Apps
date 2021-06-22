using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Management;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;

namespace RunJoyStickOnLocalMachine
{
    public partial class Form1 : Form
    {
        private Joystick joystick;
        private bool[] joystickButtons;
        public Form1()
        {
            InitializeComponent();
            joystick = new Joystick(this.Handle);
            connectToJoystick(joystick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------------
         private void connectToJoystick(Joystick joystick)
        {
            while (true)
            {
                string sticks = joystick.FindJoysticks();
                if (sticks != null)
                {
                    if (joystick.AcquireJoystick(sticks))
                    {
                        enableTimer();
                        break;
                    }
                }
            }
        }

        private void enableTimer()
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new ThreadStart(delegate()
                {
                    joystickTimer.Enabled = true;
                }));
            }
            else
                joystickTimer.Enabled = true;
        }

        private void joystickTimer_Tick_1(object sender, EventArgs e)
        {
            try
            {
                joystick.UpdateStatus();
                joystickButtons = joystick.buttons;

                if (joystick.Xaxis == 0)
                    output.Text+="Left\n";

                if (joystick.Xaxis == 65535)
                    output.Text+="Right\n";

                if (joystick.Yaxis == 0)
                    output.Text+="Up\n";
                
                if (joystick.Yaxis == 65535)
                    output.Text+="Down\n";

                for (int i = 0; i < joystickButtons.Length; i++)
                {
                    if(joystickButtons[i] == true)
                        output.Text+="Button " + i + " Pressed\n";
                }
            }
            catch
            {
                joystickTimer.Enabled = false;
                connectToJoystick(joystick);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

    }
}
