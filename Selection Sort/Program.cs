using System;

namespace Selection_Sort
{
    class Program


    {

        static void SelectionSort(int[] data)
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

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static int[] GenerateData(int Storlek)
        {
            Random rnd = new Random();
            int[] data = new int[Storlek];

            for (int i = 0; i < data.Length; i++)
                data[i] = rnd.Next(data.Length);

            return data;
        }

        static void Main(string[] args)
        {
            int[] Storleks = new int[] { 10, 1000, 100000 };

            for (int i = 0; i < Storleks.Length; i++)
            {
                Console.WriteLine("Längden av Talet : " + Storleks[i]);
                int[] data = GenerateData(Storleks[i]);

                Console.WriteLine("Talen är sorterade");
                DateTime startTid = DateTime.Now;
                SelectionSort(data);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Soteringstiden : {0:0.00} ms .\n", deltaTid.TotalMilliseconds);

            }
        }
    }
}      



