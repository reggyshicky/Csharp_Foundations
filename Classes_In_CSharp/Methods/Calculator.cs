namespace Methods
{
    public class Calculator
    {
        
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum = sum + num;
            }
            return sum;
        }
    }
}