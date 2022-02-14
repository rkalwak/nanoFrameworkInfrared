using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using nanoFramework.Hardware.Esp32.Rmt;

namespace nanoFrameworkInfrared
{
    public class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework infrared!");
            var infraredSignalComparer = new InfraredSignalComparer(detectionError: 0.3);
            infraredSignalComparer.IsVerbose = false;
            var signalDecoder = new DevKitInfraredSignalDecoder(infraredSignalComparer);
            InfraredListener listener = new InfraredListener(33);
            listener.SignalEvent += (sender, signal) =>
            {
                DisplayCurrentReadCommand(signal);
                Button b = signalDecoder.Decode(signal);
                Console.WriteLine($"Pressed button: {b.ToString()}");
            };
            listener.Start();
         
            Thread.Sleep(Timeout.Infinite);

            // Browse our samples repository: https://github.com/nanoframework/samples
            // Check our documentation online: https://docs.nanoframework.net/
            // Join our lively Discord community: https://discord.gg/gCyBu8T
        }

        private static void DisplayCurrentReadCommand(RmtCommand[] response)
        {
            Console.WriteLine($"Length:{response.Length.ToString()}");
            StringBuilder sb = new StringBuilder();
            foreach (var rmtCommand in response)
            {
                sb.Append(rmtCommand.Duration0);
                sb.Append(",");
                sb.Append(rmtCommand.Duration1);
                sb.Append(",");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
