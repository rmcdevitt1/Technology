using System;
namespace Technology
{
    public class SmartPhone : Computer
    {
        //TODO: For a child class: add at least 1 additional field and 1 additional method.
        public string Carrier { get; set; }
        public readonly string Brand = "Apple";

        public SmartPhone(int storageInGB, int memoryInMB, string processor, string carrier) : base(storageInGB, memoryInMB, processor)
        {
            Carrier = carrier;
        }
    }
}
