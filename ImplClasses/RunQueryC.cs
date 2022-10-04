using GenerateReceipt.Interfaces;

namespace GenerateReceipt.ImplClasses
{
    public class RunQueryC : IRunQuery<string>
    {
        public string Run()
        {
            return "Injection Completed";
        }

    }
}
