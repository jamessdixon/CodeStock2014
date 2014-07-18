using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace ChickenSoftware.IntroToPWM04
{
    //Orange = Signal (yellow wire from prior)
    //Brown (-) = Ground (black wire from prior)
    //Red (+) = 5V
    public class Program
    {
        private static PWM _servo = null;
        private const uint SERVO_UP = 1250;
        private const uint SERVO_DOWN = 1750;
        private const uint SERVO_NEUTRAL = 1500;
        public static void Main()
        {
            InputPort button = new InputPort(Pins.ONBOARD_BTN, false, Port.ResistorMode.Disabled);
            SetUpServo();

            while (true)
            {
                if (button.Read())
                {
                    TestServoFullRange();
                }
            }
        }

        private static void SetUpServo()
        {
            uint period = 20000;
            uint duration = SERVO_NEUTRAL;

            _servo = new PWM(PWMChannels.PWM_PIN_D5, period, duration, PWM.ScaleFactor.Microseconds, false);
            _servo.Start();
        }

        private static void TestServoFullRange()
        {
            _servo.Duration = SERVO_UP;
            Thread.Sleep(2000);
            _servo.Duration = SERVO_DOWN;
            Thread.Sleep(2000);
            _servo.Duration = SERVO_NEUTRAL;
        }

    }
}
