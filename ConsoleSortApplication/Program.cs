using System;
using System.Collections.Generic;

namespace ConsoleSortApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new List<int>() { 1, 1, 4, 1, 5, 2, 1, 4, 1, 1, 2, 01, 01, 09, 09, 12, 14, 10, 08, 03, 19, 07, 16, 15, 13, 09, 16, 15, 19, 02, 07, 09, 04, 02, 16, 10, 01, 05, 13, 13, 12, 19, 08, 06, 17, 01, 12, 04, 15, 16, 14, 01, 19, 01, 01, 02, 00, 16, 14, 18, 12, 08, 10, 09, 02, 02, 01, 13, 11, 14,
            1, 1, 4, 1, 5, 2, 1, 4, 1, 1, 2, 01, 01, 09, 09, 12, 14, 10, 08, 03, 19, 07, 16, 15, 13, 09, 16,13, 09, 16, 15, 19, 02, 07, 09, 04, 02, 16, 10, 01, 05, 13, 13, 12, 19, 08, 06, 17, 01, 12, 04, 15, 16, 14, 01, 19, 01, 01, 02, 00, 16, 14, 18, 12, 08, 10, 09, 02, 02, 01, 13, 11, 14,
            1, 1, 4, 1, 5, 2, 1, 4, 1, 1, 2, 01, 01, 09, 09, 12, 14, 10, 08, 03, 19, 07, 16, 15, 13, 09, 16, 15, 19, 02, 07, 09, 04, 02, 16, 10, 01, 05, 13, 13, 12,21, 08, 06, 17, 01, 12, 04, 15, 16, 14, 01, 19, 01, 01, 02, 00, 16, 14, 18, 12, 08, 10, 09, 02, 02, 01, 13, 11, 14,13, 13};

            var visualizer = new ConsoleVisualizer();

            var coctailSorter = new CoctailSort(visualizer);
            var shellSorter = new ShellSort(visualizer);

            coctailSorter.Sort(A.ToArray());
            Console.ReadLine();

            shellSorter.Sort(A.ToArray());
            Console.ReadLine();
        }
    }
}
