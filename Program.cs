using MbientLab.Warble;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;

namespace NetCoreExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            MainAsync(args).Wait();
        }
        public static ulong getMac(string macAddress)
        {
            string hex = macAddress.Replace(":", "");
            return Convert.ToUInt64(hex, 16);
        }

        private static async Task MainAsync(string[] args)
        {
            // var type = Type.GetType(args[0]);
            // await (Task) type.GetMethod("RunAsync", BindingFlags.NonPublic | BindingFlags.Static)
            //     .Invoke(null, new object[] { args.TakeLast(args.Length - 1).ToArray() });

            await ScanConnect.RunAsync(args);

        }
    }
}