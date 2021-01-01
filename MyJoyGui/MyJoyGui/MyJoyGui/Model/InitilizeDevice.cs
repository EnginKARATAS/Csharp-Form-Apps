using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJoyGui.Model
{
    public class InitilizeDevice
    {
        //nuget:sharp.dx direct input

        DirectInput directInput = new DirectInput();
        Guid joystickGuid = Guid.Empty;
        public Joystick joystick;

        bool startup = false;

        public void Setup()
        {
            // Initialize DirectInput
            // Find a Joystick Guid

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;


            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick,
                        DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No joystick/Gamepad found.");
                Console.ReadKey();
                Environment.Exit(1);
            }


            // Instantiate joystick


            Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);

            joystick = new Joystick(directInput, joystickGuid);
            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                Console.WriteLine("Effect available {0}", effectInfo.Name);

            // Set BufferSize in order to use buffered data. BufferSize = arabellek boyutu, bufferd = korumak
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick , Acquire = elde etmek
            joystick.Acquire();


            startup = true;

        }

        public void Start()
        {
            if (startup == true)
            {

            }
            else
            {
                MessageBox.Show("Firstly Initilize Component!!", "Drone Cant be Initalized");
            }

        }
    }
}
