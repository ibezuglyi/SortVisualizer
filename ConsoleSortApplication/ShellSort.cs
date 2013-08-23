using System;

namespace ConsoleSortApplication
{
    public class ShellSort : ISortable
    {
        IVisualizer visualizer;
        public ShellSort(IVisualizer visualizer)
        {
            if (visualizer == null)
                throw new ArgumentNullException("visualizer could not be null");
            this.visualizer = visualizer;
        }
        public void Sort(int[] array)
        {
            int i, j, increment, temp;
            visualizer.Visualize(array);
            increment = 3;
            while (increment > 0)
            {
                for (i = 0; i < array.Length; i++)
                {
                    j = i;
                    temp = array[i];
                    while ((j >= increment) && (array[j - increment] > temp))
                    {
                        array[j] = array[j - increment];
                        visualizer.Visualize(array, j, j - increment);
                        j = j - increment;
                    }
                    array[j] = temp;
                    visualizer.Visualize(array, j);
                }

                if (increment / 2 != 0)
                {
                    increment = increment / 2;
                }
                else if (increment == 1)
                {
                    increment = 0;
                }
                else
                {
                    increment = 1;
                }
            }
        }
    }
}
