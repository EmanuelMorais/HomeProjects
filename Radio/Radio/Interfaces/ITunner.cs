namespace Radio.Interfaces
{
    public interface ITunner
    {
        string Manufacter();
        int Frequency();
        bool SelfCheck();
        string SerialNumber();
    }
}
