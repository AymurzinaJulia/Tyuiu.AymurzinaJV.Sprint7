using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AymurzinaJV.Sprint7.Project.V7;

namespace Tyuiu.AymurzinaJV.Sprint7.Tests
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFileExists()
        {
            
            string path = @"C:\Temp\ApartmentsData.csv";

            bool exists = DataService.CheckFileExists(path);

            Assert.IsFalse(exists); 
        }
    }
}
