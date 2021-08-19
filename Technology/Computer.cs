using System;
namespace Technology
{
    public class Computer : AbstractEntity
    {
        // TODO : Add 3 fields, 2 methods, one constructor
        public int StorageInGB { get; set; }
        public int MemoryInMB { get; set; }
        public string Processor { get; set; }
        private int objectId;

        public Computer(int storageInGB, int memoryInMB, string processor)
        {
            StorageInGB = storageInGB;
            MemoryInMB = memoryInMB;
            Processor = processor;
        }

        public void UpgradeMemory(int memoryInMB)
        {
            MemoryInMB += memoryInMB;
        }

        public void UpgradeStorage(int storageInGB)
        {
            StorageInGB += storageInGB;
        }


        public override int GetObjectId()
        {
            AbstractEntity.objectIDnumber += 1;
            return AbstractEntity.objectIDnumber;
        }
    }
}
