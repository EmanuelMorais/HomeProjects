using Radio.Implementations;

namespace Radio.Interfaces
{
    public interface IRadio
    {
        IBattery Battery { get; set; }
        ITunner Tuner { get; set; }
        ISpeaker Speaker { get; set; }
        string Name { get; set; }
        Dial Dial { get; set; }
        string RadioName();
        void Start();
    }
}