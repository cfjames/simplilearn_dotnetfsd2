namespace Phase4Section1
{
    public class Calculator : ICalculator
    {

        private IDBDAO _dBDAO;

        public Calculator()
        { 
            _dBDAO = new DBDAO();
        }

        public Calculator(IDBDAO dBDAO)
        {
            _dBDAO = dBDAO;
        }

        public int Add(int x, int y)
        {
            _dBDAO.GetData();
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

        public int Subtract(int x, int y)
        {
            if (x < 0 || y < 0)
                throw new ArgumentOutOfRangeException("x"); 
            return x - y;
        }
    }

    public interface IDBDAO
    {
        string GetData();
    }

    public class DBDAO : IDBDAO
    {
        public string GetData()
        {
            return "Got Data from Database";
        }
    }
}