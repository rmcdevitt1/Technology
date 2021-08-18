using System;
namespace Technology
{
    public class Laptop : Computer
    {
        //TODO: For a child class: add at least 1 additional field and 1 additional method.
        public double ScreenSize { get; set; }
        public string OperatingSystem { get; set; }
        public readonly string Brand = "Apple";

        public Laptop(int storageInGB, int memoryInMB, string processor, double screenSize, string operatingSystem) : base(storageInGB, memoryInMB, processor)
        {
            ScreenSize = screenSize;
            OperatingSystem = operatingSystem;
        }

        public string OSStatus()
        {
            if (OperatingSystem != "BigSur")
            {
                return "Operating System is up to date.";
            } else
            {
                return "Laptop OS not up to date. Please update your Laptop to the latest Operating System.";
            }
        }
    }
}
