using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.NoteStatistics
{
    class Program
    {
        static string[] indexNote = { "C", "C#", "D", "D#", "E", "F", "F#",
                                    "G", "G#", "A", "A#", "B" };
        static double[] noteHz = { 261.63, 277.18, 293.66, 311.13,
                                   329.63, 349.23, 369.99, 392.00,
                                   415.30, 440.00, 466.16, 493.88 };

        static void Main(string[] args)
        {
            double[] readLine = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            List<string> listNotes = new List<string>();
            FromNoteHzToIndex(readLine, listNotes);

            List<string> listNaturals = new List<string>();
            for (int cnt1 = 0; cnt1 < listNotes.Count; cnt1++)
            {
                if (!listNotes[cnt1].Contains('#'))
                {
                    listNaturals.Add(listNotes[cnt1]);
                }
            }

            List<string> listSharps = new List<string>();
            for (int cnt1 = 0; cnt1 < listNotes.Count; cnt1++)
            {
                if (listNotes[cnt1].Contains('#'))
                {
                    listSharps.Add(listNotes[cnt1]);
                }
            }
            double sumNaturals = TotalSumIndex(listNaturals);
            double sumSharps = TotalSumIndex(listSharps);
            
            Console.Write("Notes: ");
            Console.WriteLine(String.Join(" ", listNotes));
            Console.Write("Naturals: ");
            Console.WriteLine(String.Join(", ", listNaturals));
            Console.Write("Sharps: ");
            Console.WriteLine(String.Join(", ", listSharps));
            Console.WriteLine($"Naturals sum: {sumNaturals:0.##}");
            Console.WriteLine($"Sharps sum: {sumSharps:0.##}");

        }

        public static void FromNoteHzToIndex(double[] readLine, List<string> currentList)
        {
            for (int cnt1 = 0; cnt1 < readLine.Length; cnt1++)
            {
                for (int cnt2 = 0; cnt2 < noteHz.Length; cnt2++)
                {
                    if (readLine[cnt1] == noteHz[cnt2])
                    {
                        currentList.Add(indexNote[cnt2]);
                    }
                }
            }
        }

        private static double TotalSumIndex(List<string> currentList)
        {
            double result = 0.0;
            for (int cnt1 = 0; cnt1 < currentList.Count; cnt1++)
            {
                for (int cnt2 = 0; cnt2 < indexNote.Length; cnt2++)
                {
                    if (currentList[cnt1] == indexNote[cnt2])
                    {
                        result += noteHz[cnt2];
                    }
                }
            }
            return result;
        }
    }
}
