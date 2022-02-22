using System;

namespace Module3HW4
{
    public class Program
    {
        public Program()
        {
            ListOfResults = new List<int>();
        }

        public event Func<int, int, int> DoSum;

        public List<int> ListOfResults { get; set; }

        public int Sum(int value1, int value2) => value1 + value2;

        public void SumOfResults()
        {
            int sum = 0;

            foreach (var item in DoSum.GetInvocationList())
            {
                int value = Convert.ToInt32(item.DynamicInvoke(2, 6));
                ListOfResults.Add(value);
            }

            foreach (var item in ListOfResults)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }

        private static void Main()
        {
            Program program = new Program();

            program.DoSum += program.Sum;
            program.DoSum += program.Sum;

            program.SumOfResults();
        }
    }
}