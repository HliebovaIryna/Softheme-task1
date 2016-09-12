using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs_in = new FileStream(@"D:\in.txt", FileMode.Open);
            byte[] input = new byte[fs_in.Length];
            fs_in.Read(input, 0, input.Length);
            fs_in.Close();
            int length = input.Length;
            int count_One = 0;
            int j = 0;
            int[] One = new int[length];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '1')
                    count_One++;
                else
                {
                    One[j] = count_One;
                    count_One = 0;
                    j++;
                }
            }
            int max = One[0];
            for (int i = 0; i < j; i++)
            {
                if (One[i] > max)
                    max = One[i];
            }
            StreamWriter fs_out = new StreamWriter(@"D:\out.txt");
            fs_out.Write(max);
            fs_out.Close();

        }
    }
}
