using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace ChickenSoftware.IntroToPwm01
{
    public class Program
    {
        //Set scope to 2V, 100 ms
        //Hook probe to I/O 5
        public static void Main()
        {
            OutputPort port = new OutputPort(Pins.GPIO_PIN_D5, false);
            OutputPort led = new OutputPort(Pins.ONBOARD_LED, false);
            while (true)
            {
                port.Write(true);
                led.Write(true);
                Thread.Sleep(250);
                port.Write(false);
                led.Write(false);
                Thread.Sleep(250);
            }
        }

    }
}
