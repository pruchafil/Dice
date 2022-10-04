using System.Threading.Tasks;

namespace Dice
{
    class ConsoleQuickNumericWriter
    {
        /// <summary>
        /// Minimum including
        /// <summary>
        public uint Minimum { get; }
        /// <summary>
        /// Maximum including
        /// </summary>
        public uint Maximum { private init; get; }

        public int SpeedMS { get; private set; }

        public int DecreaseSpeedMS { get; }

        public int MaxSpeed { get; }

        public ConsoleQuickNumericWriter(uint minimum, uint maximum, int speedMS, int decreaseSpeedMS, int maxSpeed)
        {
            Minimum = minimum;
            Maximum = maximum;
            SpeedMS = speedMS;
            DecreaseSpeedMS = decreaseSpeedMS;
            MaxSpeed = maxSpeed;
        }

        public async Task<uint> ConsoleWriteLoop()
        {
            while (true)

            for (uint i = Minimum; i <= Maximum; ++i)
            {
                System.Console.WriteLine(i);

                await Task.Delay(SpeedMS);

                System.Console.Clear();

                SpeedMS += DecreaseSpeedMS;

                if (SpeedMS >= MaxSpeed)
                    return i;
            }

            throw new System.Exception("can't happen");
        }
    }
}
