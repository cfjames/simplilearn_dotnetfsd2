namespace Phase4Section1
{
    public class Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(string x, string y)
        {
            if (!int.TryParse(x, out int a) ||
               !int.TryParse(y, out int b))
            {
                throw new InvalidOperationException("One or both of the inputs was not an integer.");
            }

            return Add(a, b);
        }
    }
}