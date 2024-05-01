using Microsoft.Extensions.Logging;

namespace ToolboxH1
{
    public class Return
    {
        private readonly ILogger<Return> _logger;

        public Return(ILogger<Return> logger) {  _logger = logger; }

        public Return()
        {
        }

        public void Returner() 
        {
            int minReturn = KaldReturn();
            _logger.LogInformation($"Returning value: {KaldReturn}");
            Console.WriteLine(minReturn);

        }
        public int KaldReturn()
        {
            return 2;
        }
    }
}
