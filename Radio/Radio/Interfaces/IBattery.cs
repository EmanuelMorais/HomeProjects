namespace Radio.Interfaces
{
    public interface IBattery
    {
        bool SelfCheck();
        int ChargeRemaining();
        string Manufacter();
        string SerialNumeber();
    }
}