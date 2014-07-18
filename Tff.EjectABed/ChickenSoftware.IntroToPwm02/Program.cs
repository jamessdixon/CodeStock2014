using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace ChickenSoftware.IntroToPwm02
{
    //Set scope to 2V, 5 ms
    //Hook probe to I/O 5
    public class Program
    {
        public static void Main()
        {
            uint period = 20;
            uint duration = 5;

            //NOTE, Do not use Cpu.PWMChannel
            PWM servo = new PWM(PWMChannels.PWM_PIN_D5, period, duration, PWM.ScaleFactor.Milliseconds, false);
            servo.Start();

            Thread.Sleep(Timeout.Infinite);
        }

    }
}
