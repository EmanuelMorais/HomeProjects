using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Radio.Implementations;
using Radio.Interfaces;

namespace Radio
{
    public class Program
    {
        private static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            Container.RegisterElements(container);

            var battery = container.Resolve<IBattery>();
            var dial = container.Resolve<Dial>();
            var tuner = container.Resolve<ITunner>();
            var speaker = container.Resolve<ISpeaker>("Cheap");
            var casing = container.Resolve< ICasing>();

            var radio = container.Resolve<IRadio>(
                new ParameterOverride("radioBattery", battery),
                new ParameterOverride("radioTunner", tuner),
                new ParameterOverride("speaker", speaker),
                new ParameterOverride("radioName", "RadioCenas"),
                new ParameterOverride("dial",dial));

            Console.WriteLine(casing.TypeOfMaterial());
            //dial.TypeOfDial = "newDial";
            radio.Start();
            Console.WriteLine(battery.SerialNumeber());
            //Console.WriteLine(dial.DialType());
            Console.WriteLine(radio.Name + " on frequency " + radio.Tuner.Frequency());
            radio.Speaker.Start();
            Console.WriteLine(radio.Dial.TypeOfDial);
        }
    }
}