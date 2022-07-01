namespace Phase2Section5._9.Errors
{
    public class MyErrorResponse
    {
        public string Type { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public MyErrorResponse(Exception ex, string env)
        {
            Message = ex.Message;
            if (env != "Production")
            {
                StackTrace = ex.ToString();
                Type = ex.GetType().Name;
            }
        }
    }
}
