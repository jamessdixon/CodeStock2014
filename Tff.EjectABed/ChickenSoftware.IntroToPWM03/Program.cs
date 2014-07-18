using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace ChickenSoftware.IntroToPWM03
{
    public class Program
    {
        //Use Black Netduino
        //Yellow = Signal
        //Black (-) = Ground
        //Red (+) = 5V
        public static void Main()
        {
            //period is the PWM pulse length.  Usually 20MS for RC equipment
            uint period = 20000;
            //duration is the PWM width.  Usually 1-2MS for RC equipment
            uint duration = 1500;

            //NOTE, Do not use Cpu.PWMChannel
            PWM servo = new PWM(PWMChannels.PWM_PIN_D5, period, duration, PWM.ScaleFactor.Microseconds, false);
            servo.Start();
            Thread.Sleep(2000);

            InputPort button = new InputPort(Pins.ONBOARD_BTN, false, Port.ResistorMode.Disabled);
            while (true)
            {
                if (button.Read())
                {
                    servo.Duration = 500;
                    Thread.Sleep(2000);
                    servo.Duration = 1500;
                }
            }
        }

    }
}
