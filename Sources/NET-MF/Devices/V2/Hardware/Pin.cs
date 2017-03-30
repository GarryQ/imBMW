using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using GHI.Pins;

namespace imBMW.Devices.V2.Hardware
{
    public class Pin
    {
        /// <summary>
        /// A value indicating that no GPIO pin is specified.
        /// </summary>
        public const Cpu.Pin GPIO_NONE = Cpu.Pin.GPIO_NONE;

        /// <summary>
        /// LED1. Near microSD socket on imBMW V2 main board.
        /// </summary>
        public static Cpu.Pin LED = G80.Gpio.PA8;

        /// <summary>
        /// Interrupt port for TH3122 SEN/STA (busy) output.
        /// </summary>
        public static Cpu.Pin TH3122SENSTA = G80.Gpio.PC2;

        /// <summary>
        /// Digital I/O.
        /// COM4 RX.
        /// </summary>
        public static Cpu.Pin Di0 = G80.Gpio.PA1;

        /// <summary>
        /// Digital I/O.
        /// COM4 TX.
        /// </summary>
        public static Cpu.Pin Di1 = G80.Gpio.PA0;

        /// <summary>
        /// Digital I/O.
        /// I2C SDA.
        /// </summary>
        public static Cpu.Pin Di2 = G80.Gpio.PB7;

        /// <summary>
        /// Digital I/O.
        /// I2C SCL.
        /// </summary>
        public static Cpu.Pin Di3 = G80.Gpio.PB6;

        /// <summary>
        /// Digital I/O.
        /// COM2 RTS.
        /// </summary>
        public static Cpu.Pin Di4 = G80.Gpio.PD3;

        /// <summary>
        /// Digital I/O.
        /// COM2 CTS.
        /// </summary>
        public static Cpu.Pin Di5 = G80.Gpio.PD4;

        /// <summary>
        /// Digital I/O.
        /// CAN1 RX.
        /// </summary>
        public static Cpu.Pin Di6 = G80.Gpio.PD0;

        /// <summary>
        /// Digital I/O.
        /// CAN1 TX.
        /// </summary>
        public static Cpu.Pin Di7 = G80.Gpio.PD1;

        /// <summary>
        /// Digital I/O.
        /// COM1 RX.
        /// </summary>
        public static Cpu.Pin Di8 = G80.Gpio.PA10;

        /// <summary>
        /// Digital I/O.
        /// COM1 TX.
        /// </summary>
        public static Cpu.Pin Di9 = G80.Gpio.PA9;

        /// <summary>
        /// Digital I/O.
        /// NONE!!. On the main board.
        /// </summary>
        public static Cpu.Pin Di10 = G80.Gpio.PB10;

        /// <summary>
        /// Digital I/O.
        /// MOSI
        /// </summary>
        public static Cpu.Pin Di11 = G80.Gpio.PB5;

        /// <summary>
        /// Digital I/O.
        /// MISO.
        /// </summary>
        public static Cpu.Pin Di12 = G80.Gpio.PB4;

        /// <summary>
        /// Digital I/O.
        /// SCK.
        /// </summary>
        public static Cpu.Pin Di13 = G80.Gpio.PB3;

        
        /// <summary>
        /// Digital I/O.
        /// Analog in A0.
        /// NONE!!. On the main board.
        /// </summary>
        public static Cpu.Pin Di14 = G80.Gpio.PB1;


        /// <summary>
        /// Digital I/O.
        /// Analog in/out A1.
        /// NONE!!. On the main board.
        /// </summary>
        public static Cpu.Pin Di15 = G80.Gpio.PB0;

        /// <summary>
        /// Digital I/O.
        /// Analog in A2. LED on shield.
        /// </summary>
        public static Cpu.Pin Di16 = G80.Gpio.PA7;

        /// <summary>
        /// Digital I/O.
        /// Analog in/out A3.
        /// </summary>
        public static Cpu.Pin Di17 = G80.Gpio.PA6;

        /// <summary>
        /// Digital I/O.
        /// Analog in A4.
        /// </summary>
        public static Cpu.Pin Di18 = G80.Gpio.PA3;

        /// <summary>
        /// Digital I/O.
        /// Analog in A5.
        /// </summary>
        public static Cpu.Pin Di19 = G80.Gpio.PA2;

        /// <summary>
        /// Digital I/O.
        /// On the main board.
        /// </summary>
        public static Cpu.Pin Di20 = G80.Gpio.PA4;

        /// <summary>
        /// Digital I/O.
        /// On the main board.
        /// </summary>
        public static Cpu.Pin Di21 = G80.Gpio.PA5;
    }
}
