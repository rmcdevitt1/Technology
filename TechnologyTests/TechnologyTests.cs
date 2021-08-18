using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    {
        //TODO: Try to add three MSTests tests per class.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        Computer computer;
        int baseMemoryInMB = 512;
        int baseStorageInGB = 500;
        Laptop laptop;
        double screenSize = 17.2; // inches
        string operatingSystem = "BigSur";
        SmartPhone phone;



        [TestInitialize]
        public void InitializeTests()
        {
            computer = new Computer(baseStorageInGB, baseMemoryInMB, "processor1");
            laptop = new Laptop(baseStorageInGB, baseMemoryInMB, "processor2", screenSize, operatingSystem);
            phone = new SmartPhone(baseStorageInGB, baseMemoryInMB, "processor3", "Verizon", false);
        }


        // 3 Computer Class Tests
        [TestMethod]
        public void TestComputerConstructor()
        {
            Assert.AreEqual(baseStorageInGB, computer.StorageInGB);
            Assert.AreEqual(baseMemoryInMB, computer.MemoryInMB);
        }


        [TestMethod]
        public void TestMemoryUpgrade()
        {
            computer.UpgradeMemory(512);
            Assert.AreEqual(baseMemoryInMB + 512, computer.MemoryInMB);
        }


        [TestMethod]
        public void TestStorageUpgrade()
        {
            computer.UpgradeStorage(1500);
            Assert.AreEqual(baseStorageInGB + 1500, computer.StorageInGB);
        }


        // 3 Laptop Class Tests
        [TestMethod]
        public void TestLaptopConstructor()
        {
            Assert.AreEqual(baseMemoryInMB, laptop.MemoryInMB);
            Assert.AreEqual(baseStorageInGB, laptop.StorageInGB);
            Assert.AreEqual(screenSize, laptop.ScreenSize, 0.001);
        }


        [TestMethod]
        public void TestLaptopUpgradeMemory()
        {
            laptop.UpgradeMemory(512);
            Assert.AreEqual(baseMemoryInMB + 512, laptop.MemoryInMB);
        }


        [TestMethod]
        public void TestLaptopUpgradeStorage()
        {
            laptop.UpgradeStorage(512);
            Assert.AreEqual(baseStorageInGB + 512, laptop.StorageInGB);
        }


        // 3 SmartPhone Class Tests
        [TestMethod]
        public void TestSmartPhoneConstructor()
        {
            Assert.AreEqual("Verizon", phone.Carrier);
            Assert.AreEqual(false, phone.ServiceActivated);
        }


        [TestMethod]
        public void TestActivateSmartPhone()
        {
            phone.ActivateService();
            Assert.AreEqual(true, phone.GetServiceStatus());
        }

        [TestMethod]
        public void TestDeactivateSmartPhone()
        {
            phone.DeactivateService();
            Assert.AreEqual(false, phone.GetServiceStatus());
        }






    }
}
