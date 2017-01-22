using Microsoft.Practices.Unity;
using Radio.Interfaces;

namespace Radio.Implementations
{
    public class Container
    {
        public static void RegisterElements(IUnityContainer container)
        {
            var dial = new Dial("Linear");
            //container.RegisterInstance(dial);

            var batteryType = typeof(IBattery);
            var tunerType = typeof(ITunner);
            var speaker = typeof(ISpeaker);
            
            container.RegisterType<Dial>(new InjectionConstructor("Digital dial"));
            //container.RegisterType<IBattery, Battery>();
            //container.RegisterType<ITunner, Tunner>();
            container.RegisterType<ISpeaker, NormalSpeaker>("Normal");
            container.RegisterType<ISpeaker, CheapSpeaker>("Cheap");
            container.RegisterType<IRadio, Radio>(new InjectionConstructor(batteryType, tunerType, speaker,typeof(string),dial));
            container.RegisterTypes(AllClasses.FromLoadedAssemblies(),WithMappings.FromMatchingInterface,WithName.Default,WithLifetime.ContainerControlled);
            container.RegisterType<ICasing,Casing>(new InjectionConstructor("plastic"));
        }

    }


}
