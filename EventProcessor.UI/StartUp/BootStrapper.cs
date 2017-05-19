using Autofac;
using EventProcessor.UI.ViewModels;

namespace EventProcessor.UI.StartUp
{
    public class BootStrapper
    {
        public IContainer BootStrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EventTypeViewModel>().As<IEventTypeViewModel>();

            return builder.Build();
        }
    }
}
