
//Console.WriteLine("Hello, World!");
//Ex-Stop Watch
//Viết chương trình đo thời gian thực thi của thuật toán sắp xếp chọn (selection sort) cho 100,000 số.

using System;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Tạo đối tượng StopWatch
            StopWatch stopWatch = new StopWatch();

            //Mảng chứa 100000 số 
            int[] num = new int[100000];
            Random rand = new Random();

            //Khởi tạo mảng với các số ngẫu nhiên
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rand.Next(1, 100000);
            }

            //Sắp xếp mảng và đo thời gian thực thi
            stopWatch.Start();
            SelectionSort(num);
            stopWatch.Stop();

            //In ra thời gian thực thi
            Console.WriteLine("Thoi gian thuc thi: " + stopWatch.GetElapsedTime() + "ms");
        }

        static void SelectionSort(int[] num)
        {
            int n= num.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i+1; j < n; j++)
                {
                    if (num[j] < num[min])
                    {
                        min = j;
                    }
                }
                int temp = num[min];
                num[min] = num[i];
                num[i] = temp;
            }
        }
    }
}

