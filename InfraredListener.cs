using System;
using System.Threading;
using nanoFramework.Hardware.Esp32.Rmt;

namespace nanoFrameworkInfrared
{
    public class InfraredListener
    {
        private ReceiverChannel _rxChannel;
        private Thread t;
        public InfraredListener(int pin)
        {
            _rxChannel = new ReceiverChannel(pin);
            _rxChannel.ClockDivider = 80; // 1us clock ( 80Mhz / 80 ) = 1Mhz
            _rxChannel.EnableFilter(true, 100); // filter out 100Us / noise 
            _rxChannel.SetIdleThresold(40000); // 40ms based on 1us clock
            _rxChannel.ReceiveTimeout = new TimeSpan(0, 0, 0, 0, 60);

            _rxChannel.Start(true);
        }

        public delegate void SignalEventHandler(object sender, RmtCommand[] signal);

        /// <summary>
        /// The raised event
        /// </summary>
        public event SignalEventHandler? SignalEvent;
        public void Start()
        {
            t = new Thread(Run);
            t.Start();
        }

        public void Stop()
        {
            t.Abort();
            _rxChannel.Stop();
        }
        
        private void Run()
        {
            while (true)
            {
                var response = _rxChannel.GetAllItems();
                if (response != null)
                {
                    SignalEvent?.Invoke(this, response);
                }
                Thread.Sleep(60);
            }
        }
    }
}