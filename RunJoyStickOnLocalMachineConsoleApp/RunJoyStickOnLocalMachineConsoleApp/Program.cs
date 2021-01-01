using SharpDX.DirectInput;
using System;


namespace RunJoyStickOnLocalMachineConsoleApp
{
    class Program
    {
        static void Main()
        {
            InitilizeDevice device = new InitilizeDevice();
            device.Initalize();

            //yarın bir gün xbox 360 yerine drone control pad gelirse ne yapacağız?
            //Projeyi en baştan drone control pad için mi yazacağız? Hayır
            //bu yüzden Çokbiçimlilik (Polymorphism)den faydalanacağız.
            //istediğimiz cihazın instanslarını ayarlayıp valuelerini belirleyip kullanmaya başlamalıyız
            //Peki o halde nasıl bir mantıkla bunu yazmalı?




        }
    }
}
