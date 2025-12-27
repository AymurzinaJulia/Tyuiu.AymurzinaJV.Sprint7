using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tyuiu.AymurzinaAJV.Sprint7.Project.V7.Lib;
using Tyuiu.AymurzinaJV.Sprint7.Project.V7;

namespace Tyuiu.AymurzinaJV.Sprint7.Project.Tests
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestStatisticsOnSampleData()
        {
            // Создаём тестовые квартиры
            var apartments = new List<Apartment_AJV>
            {
                new Apartment_AJV { TotalArea = 50, UsefulArea = 40, FamilyCount = 3 },
                new Apartment_AJV { TotalArea = 70, UsefulArea = 60, FamilyCount = 4 },
                new Apartment_AJV { TotalArea = 90, UsefulArea = 80, FamilyCount = 2 },
            };

            // Вычисляем статистику через DataService
            var stats = DataService.CalculateStatistics(apartments);

            // Проверяем, что статистика верная
            Assert.AreEqual(3, stats.Count); // всего квартир 3
            Assert.AreEqual(70, stats.AverageTotalArea); // средняя площадь (50+70+90)/3
            Assert.AreEqual(90, stats.MaxTotalArea);     // максимальная площадь
            Assert.AreEqual(50, stats.MinTotalArea);     // минимальная площадь
            Assert.AreEqual(3, stats.AverageFamilyCount); // среднее кол-во жильцов (3+4+2)/3
        }
    }
}

