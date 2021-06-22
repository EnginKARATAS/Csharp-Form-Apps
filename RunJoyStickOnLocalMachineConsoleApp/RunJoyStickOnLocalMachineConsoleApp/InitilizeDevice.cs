using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Text;

namespace RunJoyStickOnLocalMachineConsoleApp
{
    public class InitilizeDevice
    {
        //nuget:sharp.dx direct input


        public void Initalize()
        {
            // Initialize DirectInput
            DirectInput directInput = new DirectInput();
            // Find a Joystick Guid
            var joystickGuid = Guid.Empty;

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

            // Instantiate the joystick
            var joystick = new Joystick(directInput, joystickGuid);


            Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);

            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                Console.WriteLine("Effect available {0}", effectInfo.Name);

            // Set BufferSize in order to use buffered data. BufferSize = arabellek boyutu, bufferd = korumak
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick , Acquire = elde etmek
             joystick.Acquire();


            // Poll events from joystick
            while (true)//forever
            {
                joystick.Poll();  //retrives data from poll object. //anket objesinden datayı geri çeker. //retrive: geri çekmek
                var datas = joystick.GetBufferedData();//her bir hareketin datası

                foreach (var state in datas)

                    Console.WriteLine(state + " --> " + state.Value + " --> " + state.Offset);

            }

        }
    }
}
