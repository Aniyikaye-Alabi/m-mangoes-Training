using GenerateReceipt.Interfaces;

namespace GenerateReceipt.Models
{
    public class RunQueryC : IRunQuery<string>
    {
        public string Run()
        {
            return "Injection Completed";
        }

    }
}
