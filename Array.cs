using System;

namespace ConsoleApp5
{
    public class Array : IMath, ISort
    {
        private int[] data;

        public Array(int[] arr)
        {
            data = arr;
        }

        /*1 завдання*/

        public int Max()
        {
            int max = data[0];
            for (int i = 1; i < data.Length; i++)
                if (data[i] > max)
                    max = data[i];

            return max;
        }

        public int Min()
        {
            int min = data[0];
            for (int i = 1; i < data.Length; i++)
                if (data[i] < min)
                    min = data[i];

            return min;
        }

        public float Avg()
        {
            int sum = 0;
            for (int i = 0; i < data.Length; i++)
                sum += data[i];

            return (float)sum / data.Length;
        }

        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < data.Length; i++)
                if (data[i] == valueToSearch)
                    return true;

            return false;
        }

        public override string ToString()
        {
            return string.Join(" ", data);
        }

        /*2 завдання*/

        public void SortAsc()
        {
            System.Array.Sort(data);
        }

        public void SortDesc()
        {
            System.Array.Sort(data);
            System.Array.Reverse(data);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                SortAsc();
            else
                SortDesc();
        }
    }
}
