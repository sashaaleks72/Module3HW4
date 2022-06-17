namespace Module3HW4
{
    public class Delegates
    {
        public Delegates(int val1, int val2)
        {
            DoSum += Sum;
            DoSum += Sum;
        }

        public event Func<int, int, int> DoSum;

        public int Sum(int value1, int value2) => value1 + value2;

        public void SumOfResults(Action<string> showMessage)
        {
            int sum = 0;

            try
            {
                foreach (var item in DoSum.GetInvocationList())
                {
                    sum += Convert.ToInt32(item.DynamicInvoke(2, 6));
                }

                showMessage($"The result: {sum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
