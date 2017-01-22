using System;
using Radio.Implementations;
using Radio.Interfaces;

namespace Radio
{
    public class Radio : IRadio
    {
        public IBattery Battery { get; set; }
        public ITunner Tuner { get; set; }
        public ISpeaker Speaker { get; set; }
        public string Name { get; set; }
        public Dial Dial { get; set; }

        public Radio(IBattery radioBattery, ITunner radioTunner, ISpeaker speaker, string radioName, Dial dial)
        {
            this.Battery = radioBattery;
            this.Tuner = radioTunner;
            this.Speaker = speaker;
            this.Name = radioName;
            this.Dial = dial;
        }

        public string RadioName()
        {
            return Name;
        }

        public void Start()
        {
            Console.WriteLine(Name+" sings: song number one");           
        }
    }
}