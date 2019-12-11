namespace GoodCodeBadCode.CH03.DependencyInjection
{
    public class Worker
    {
        private readonly ILogger _logger;

        public Worker(ILogger logger)
        {
            _logger = logger;
            _logger.OutputMessage("This constructor has been injected with a logger!");
        }

        public void DoSomeWork(ILogger logger)
        {
            logger.OutputMessage("This methods has been injected with a logger!");
        }

        public void DependencyInject()
        {
            var logger = new TextFileLogger();
            var di = new Worker(logger);
            di.DoSomeWork(logger);
        }
    }
}
