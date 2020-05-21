using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("exam 1 result: " + number1(new [] { 1, 2, 0, 3, 5, 10}));

            //Console.WriteLine("exam 2 result: " + number2(6));

            Console.WriteLine("exam 3 result: " + string.Join(", ", number3(0).ToArray()));
        }

        public static List<int> number3(int len)
        {
            List<int> output;
            if (len <= 0) return null;

            output = new List<int>();
            for (int i = 0; i < Convert.ToInt32(Math.Floor(Convert.ToDouble(len/2))); i++)
            {
                int num = rand();
                while (output.Contains(num)) num = rand();
                output.Add(num);
                output.Add(-num);
            }
            if (len % 2 == 0 || len == 1) output.Add(0);

            return output;
        }

        public static int rand()
        {
            return Convert.ToInt32(new Random(Guid.NewGuid().GetHashCode()).NextDouble() * 100);
        }

        public static int number1(int [] arr)
        {
            int output;
            if (arr == null) return 0;

            output = arr[0];
            foreach(int x in arr)
            {
                output = (x < output) ? x : output;
            }

            return output;
        }


        public static string number2(int len)
        {
            List<string> output;
            if (len < 0) return "invalid lenght";

            output = new List<string>();
            for(int i = 1; i<= len; i++)
            {
                output.Add((i % 2 == 0) ? "-" : "+");
            }

            return string.Join("", output.ToArray());
        }
    }
}
