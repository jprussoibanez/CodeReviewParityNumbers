using ParityNumbers.ConsoleApp.Exceptions;
using ParityNumbers.ConsoleApp.Models;
using ParityNumbers.ConsoleApp.Resources;

namespace ParityNumbers.ConsoleApp.Extensions
{
    public static class IntExtensions
    {
        public static Parity GetParity(this int number)
        {
            return (number % 2 == 0) ? Parity.Even : Parity.Odd;
        }

        public static string GetParityText(this int number)
        {
            switch (number.GetParity())
            {
                case Parity.Even:
                    return Labels.IsEven;
                case Parity.Odd:
                    return Labels.IsOdd;
                default:
                    throw new ParityException(ErrorMessages.UnknownParityValue);
            }
        }
    }
}
