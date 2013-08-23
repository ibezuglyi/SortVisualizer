using System;

namespace ConsoleSortApplication
{
    public class CoctailSort : ISortable
    {
        IVisualizer visualizer;

        public CoctailSort(IVisualizer visualizer)
        {
            if (visualizer == null)
                throw new ArgumentNullException("visualizer could not be null");
            this.visualizer = visualizer;
        }
        public void Sort(int[] array)
        {
            if (visualizer == null)
                throw new ArgumentNullException("visualizer could not be null");

            visualizer.Visualize(array);
            bool swapped;
            int left = 0;
            int right = array.Length - 2;
            do
            {
                swapped = false;
                for (int i = left; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                        visualizer.Visualize(array, i, i + 1);
                    }
                }
                if (!swapped)
                {
                    break;
                }
                swapped = false;
                for (int i = right; i >= 0; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                        visualizer.Visualize(array, i, i + 1);
                    }
                }
                left++;
                right--;
            } while (swapped);
        }
    }
}
