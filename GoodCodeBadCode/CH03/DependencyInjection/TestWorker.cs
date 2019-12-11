namespace GoodCodeBadCode.CH03.DependencyInjection
{
    public class TestWorker
    {
        public TestWorker()
        {
            DependencyInject();
        }

        private void DependencyInject()
        {
            var logger = new TextFileLogger();
            var di = new Worker(logger);
            di.DoSomeWork(logger);
        }
    }
}
