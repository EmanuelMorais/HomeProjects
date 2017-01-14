namespace Radio
{
    public interface IBattery
    {
        bool SelfCheck();
        int ChargeRemaining();
        string Manufacter();
        string SerialNumeber();
    }
}