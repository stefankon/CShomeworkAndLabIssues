using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            int minutes = 0;
            int seconds = 0;

            double bars = beats / 4.0;
            seconds = (int)(((double)beats / bpm) * 60);
            minutes = seconds / 60;
            seconds = seconds % 60;

            Console.WriteLine("{0} bars - {1}m {2}s", Math.Round(bars, 1), minutes, seconds);

        }
    }
}
