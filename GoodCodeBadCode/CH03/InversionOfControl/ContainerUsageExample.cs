using GoodCodeBadCode.CH03.DependencyInjection;

namespace GoodCodeBadCode.CH03.InversionOfControl
{
    public class ContainerUsageExample
    {
        public ContainerUsageExample()
        {
            InversionOfControl();
        }

        private void InversionOfControl()
        {
            Container container = new Container();
            container.Configuration["message"] = "Hello World!";
            container.Register<ILogger>(delegate
            {
                return new TextFileLogger();
            });
            container.Register<Worker>(delegate
            {
                return new Worker(container.Create<ILogger>());
            });
        }
    }
}
