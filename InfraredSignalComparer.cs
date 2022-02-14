using System;
using nanoFramework.Hardware.Esp32.Rmt;

namespace nanoFrameworkInfrared
{
    public class InfraredSignalComparer
    {
        private readonly double detectionError;

        public InfraredSignalComparer(double detectionError)
        {
            if (detectionError < 0 || detectionError > 1.0)
            {
                throw new ArgumentOutOfRangeException(nameof(detectionError),
                    "Comparison accuracy must be double value in range of (0,1)");
            }
            this.detectionError = detectionError;
        }
        public bool IsVerbose { get; set; }
        public bool Compare(RmtCommand[] response, ushort[] referenceValues)
        {
            bool exactMatch = true;
            if (response.Length * 2 != referenceValues.Length)
                return false;
            for (int i = 0; i < response.Length - 1; i++)
            {
                int onCode = response[i].Duration0;
                int offCode = response[i].Duration1;
                var expectedOnCode = referenceValues[i * 2];
                var expectedOffCode = referenceValues[i * 2 + 1];
                bool isOnCodeOk = false;
                bool isOffCodeOk = false;
                isOnCodeOk = Math.Abs(onCode - expectedOnCode) <= (onCode * detectionError);
                isOffCodeOk = Math.Abs(offCode - expectedOffCode) <= (offCode * detectionError);

                if (IsVerbose)
                {
                    var a = isOnCodeOk ? "Ok" : "Nok";
                    var b = isOffCodeOk ? "Ok" : "Nok";
                    Console.WriteLine($"OnCode: Heard :{onCode} Desired:{expectedOnCode} - {a}; OffCode: Heard :{offCode} Desired:{expectedOffCode} - {b}");
                }

                if (!isOffCodeOk || !isOnCodeOk)
                {
                    exactMatch = false;
                }
            }

            return exactMatch;
        }
    }

}