using System;

namespace ConsoleSortApplication
{
    public class ConsoleVisualizer : IVisualizer
    {
        const string sym = "O";

        public void Visualize(int[] array)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetBufferSize(array.Length, 25);
            for (int column = 0; column < array.Length; column++)
            {

                int value = array[column];
                int row = 20;

                while (row > value)
                {
                    Console.SetCursorPosition(column, row);
                    Console.Write(sym);
                    row--;

                }
            }
        }

        public void Visualize(int[] array, int column1)
        {
            int valuei = array[column1];
            for (int row = 20; row > 0; row--)
            {
                Console.SetCursorPosition(column1, row);
                if (row > valuei)
                    Console.Write(sym);
                else
                    Console.Write(" ");
            }
        }

        public void Visualize(int[] array, int column1, int column2)
        {
            Visualize(array, column1);
            Visualize(array, column2);
        }
    }
}
