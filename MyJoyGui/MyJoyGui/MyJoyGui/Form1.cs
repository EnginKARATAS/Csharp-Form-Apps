using MyJoyGui.Model;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJoyGui
{
    public partial class Form1 : Form
    {

        InitilizeDevice MyDevice = new InitilizeDevice();
        public bool stop_bool = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void initalize_gamepad_Click(object sender, EventArgs e)
        {
            MyDevice.Setup();

        }

        private void start_Click(object sender, EventArgs e)
        {
            stop_bool = false;

            //MyDevice.Start();

            // Poll events from joystick

            new Thread(() =>
            {
                while (!stop_bool)//forever
                {
                    MyDevice.joystick.Poll();  //retrives data from poll object. //anket objesinden datayı geri çeker. //retrive: geri çekmek
                    JoystickUpdate[] datas = MyDevice.joystick.GetBufferedData();//her bir hareketin datası

                    foreach (var state in datas)
                    {
                        Console.WriteLine(state + " --> " + state.Value + " --> " + state.Offset);
                        
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (state.Offset.ToString() == "X")
                            {
                                trackBarLx.Value = state.Value;
                            }
                            else if (state.Offset.ToString() == "Y")
                            {
                                trackBarLy.Value = state.Value * -1;
                            }
                            else if (state.Offset.ToString() == "RotationX")
                            {
                                trackBarRx.Value = state.Value;
                            }
                            else if (state.Offset.ToString() == "RotationY")
                            {
                                trackBarRy.Value = state.Value*-1;
                            }
                        });
                    }
                    Thread.Sleep(1000);
                }
            }).Start();



        }

        private void stop_Click(object sender, EventArgs e)
        {
            stop_bool = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }

        private void connectLora_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
