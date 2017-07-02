using ParityNumbers.ConsoleApp.Extensions;
using ParityNumbers.ConsoleApp.Resources;
using System;

namespace ParityNumbers.ConsoleApp
{
    /// <summary>
    /// Calculate parity numbers sequence console application
    /// </summary>
    public class ParityNumberSequence
    {
        private const int DefaultSequenceCount = 25;

        /// <summary>
        /// Main execution to calculate the parity number sequence
        /// </summary>
        /// <param name="args">First argument should be the sequence count. If no arguments then default sequence count will be used</param>
        public static void Main(string[] args)
        {
            var sequenceCount = _GetSequenceCountFromArguments(args);
            for (int number = 0; number < sequenceCount; number++)
            {
                Console.WriteLine(string.Format("{0} {1}", number, number.GetParityText()));
            }

            Console.ReadKey();
        }

        private static int _GetSequenceCountFromArguments(string[] args)
        {
            var sequenceCount = DefaultSequenceCount;
            if (args.Length > 0)
            {
                if (!int.TryParse(args[0], out sequenceCount))
                {
                    throw new ArgumentException(ErrorMessages.FirstArgumentShouldBeSequenceNumber);
                }
            }

            return sequenceCount;
        }
    }
}