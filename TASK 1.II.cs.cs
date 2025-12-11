//2.You are working in a software company developing a Device Health Monitoring System for a smart factory.
//The project contains multiple modules, and the build system should decide which module will run based on configuration.
//Currently, the solution contains two classes, each with a Main() method:

//using System;

//namespace DeviceMonitor
//{
//    class TemperatureModule
//    {
//        public static void Main(string[] args)
//        {
//            //Your Code here
//        }
//    }

//    class VibrationModule
//    {
//        public static void Main()
//        {
//            //Your code here
//        }
//    }
//}

//Modify the above program so that:
//1.TemperatureModule.Main() becomes the startup entry point
//2.	VibrationModule.Main() is converted into a normal helper method
//3.	Show the corrected code




using System;

namespace DeviceHospitalMonitor
{
    class TemperatureModule
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temperature Module Started...");
            VibrationModule.ProcessVibration();
        }
    }
    class VibrationModule
    {
        public static void ProcessVibration()
        {
            Console.WriteLine("Vibration Module Processing...");
        }
    }
}
