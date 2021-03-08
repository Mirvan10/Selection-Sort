using System;

namespace ConsoleApp1
{
    class Program
    {
        public void SelectionSort(int[] data)
        {
            int i, j, min;
            for (i = 0; i < data.Length; i++)
            {
                min = i;
                for (j = 0; j < data.Length; j++)
                {
                    if (data[j] > data[min])
                    {
                        min = j;
                        Swap(ref data[i], ref data[min]);
                    }
                }
            }
        }

        private void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
