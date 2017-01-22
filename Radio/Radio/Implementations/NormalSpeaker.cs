using System;
using Radio.Interfaces;

namespace Radio.Implementations
{
    public class NormalSpeaker : ISpeaker
    {
        public void Start()
        {
            Console.WriteLine("Normal Speaker Playing");
        }
    }
}