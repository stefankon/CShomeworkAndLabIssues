using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10.DataOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());

            ulong minNumber = Math.Min(num1, num2);
            ulong maxNumber = Math.Max(num1, num2);

            ulong overflowValue = 0;
            string typeOfMinNum = String.Empty;

            if (minNumber <= byte.MaxValue)
            {
                overflowValue = byte.MaxValue;
                typeOfMinNum = "byte";
            }
            else if (minNumber <= ushort.MaxValue)
            {
                overflowValue = ushort.MaxValue;
                typeOfMinNum = "ushort";
            }
            else if (minNumber <= uint.MaxValue)
            {
                overflowValue = uint.MaxValue;
                typeOfMinNum = "uint";
            }
            else if (minNumber <= ulong.MaxValue)
                {
                overflowValue = ulong.MaxValue;
                typeOfMinNum = "ulong";
            }

            string typeOfMaxNum = String.Empty;
            if (maxNumber <= byte.MaxValue)
            {
                typeOfMaxNum = "byte";
            }
            else if (maxNumber <= ushort.MaxValue)
            {
                typeOfMaxNum = "ushort";
            }
            else if (maxNumber <= uint.MaxValue)
            {
                typeOfMaxNum = "uint";
            }
            else if (maxNumber <= ulong.MaxValue)
            {
                typeOfMaxNum = "ulong";
            }

            double overflowCount = ((double)maxNumber / overflowValue);

            Console.WriteLine("bigger type: {0}", typeOfMaxNum);
            Console.WriteLine("smaller type: {0}", typeOfMinNum);
            Console.WriteLine("{0} can overflow {1} {2} times", maxNumber, typeOfMinNum, Math.Round(overflowCount));
        }
    }
}
