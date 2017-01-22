using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Radio.Interfaces;

namespace Radio.Implementations
{
    public static class ContainerResolver
    {
        public static IUnityContainer Container { get; set; } = new UnityContainer();

        public static void RegisterContainer()
        {
            Implementations.Container.RegisterElements(Container);

        }

        public static void Resolver()
        {
            
            var battery = Container.Resolve<IBattery>();
            var dial = Container.Resolve<Dial>();
            var tuner = Container.Resolve<ITunner>();
            var speaker = Container.Resolve<ISpeaker>("Cheap");
            var casing = Container.Resolve<ICasing>();

            var radio = Container.Resolve<IRadio>(
                new ParameterOverride("radioBattery", battery),
                new ParameterOverride("radioTunner", tuner),
                new ParameterOverride("speaker", speaker),
                new ParameterOverride("radioName", "RadioCenas"),
                new ParameterOverride("dial", dial));
        }

    }
}
