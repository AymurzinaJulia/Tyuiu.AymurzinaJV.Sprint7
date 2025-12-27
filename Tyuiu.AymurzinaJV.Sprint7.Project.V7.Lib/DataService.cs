using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Tyuiu.AymurzinaAJV.Sprint7.Project.V7.Lib
{
    public class Apartment_AJV
    {
        public int Entrance { get; set; }                 // номер подъезда
        public int ApartmentNumber { get; set; }          // номер квартиры
        public double TotalArea { get; set; }             // общая площадь
        public double LivingArea { get; set; }            // жилая площадь
        public int RoomsCount { get; set; }               // количество комнат
        public string OwnerSurname { get; set; }          // фамилия жильца
        public DateTime RegistrationDate { get; set; }    // дата прописки
        public int FamilyMembersCount { get; set; }       // членов семьи
        public int ChildrenCount { get; set; }            // количество детей
        public bool HasDebt { get; set; }                  // задолженность
        public string Note { get; set; }                   // примечание
    }
    public class ApartmentRepository_AJV
    {
        // ===== ЧТЕНИЕ CSV =====
        public List<Apartment_AJV> LoadFromCsv(string filePath)
        {
            var result = new List<Apartment_AJV>();
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(';');

                result.Add(new Apartment_AJV
                {
                    Entrance = int.Parse(parts[0]),
                    ApartmentNumber = int.Parse(parts[1]),
                    TotalArea = double.Parse(parts[2], CultureInfo.InvariantCulture),
                    LivingArea = double.Parse(parts[3], CultureInfo.InvariantCulture),
                    RoomsCount = int.Parse(parts[4]),
                    OwnerSurname = parts[5],
                    RegistrationDate = DateTime.Parse(parts[6]),
                    FamilyMembersCount = int.Parse(parts[7]),
                    ChildrenCount = int.Parse(parts[8]),
                    HasDebt = bool.Parse(parts[9]),
                    Note = parts.Length > 10 ? parts[10] : string.Empty
                });
            }

            return result;
        }

        // ===== ЗАПИСЬ CSV =====
        public void SaveToCsv(string filePath, List<Apartment_AJV> data)
        {
            var lines = new List<string>
            {
                "Entrance;Apartment;TotalArea;LivingArea;Rooms;OwnerSurname;RegistrationDate;FamilyCount;ChildrenCount;HasDebt;Note"
            };

            foreach (var a in data)
            {
                lines.Add(
                    $"{a.Entrance};{a.ApartmentNumber};{a.TotalArea.ToString(CultureInfo.InvariantCulture)};" +
                    $"{a.LivingArea.ToString(CultureInfo.InvariantCulture)};{a.RoomsCount};{a.OwnerSurname};" +
                    $"{a.RegistrationDate:yyyy-MM-dd};{a.FamilyMembersCount};{a.ChildrenCount};{a.HasDebt};{a.Note}"
                );
            }

            File.WriteAllLines(filePath, lines);
        }

        // ===== ПОИСК ПО ФАМИЛИИ =====
        public List<Apartment_AJV> SearchBySurname(List<Apartment_AJV> data, string surname)
        {
            return data
                .Where(a => a.OwnerSurname
                .ToLower()
                .Contains(surname.ToLower()))
                .ToList();
        }

        // ===== ФИЛЬТР ПО ЗАДОЛЖЕННОСТИ =====
        public List<Apartment_AJV> FilterByDebt(List<Apartment_AJV> data, bool hasDebt)
        {
            return data
                .Where(a => a.HasDebt == hasDebt)
                .ToList();
        }

        // ===== СОРТИРОВКА ПО ПЛОЩАДИ =====
        public List<Apartment_AJV> SortByTotalArea(List<Apartment_AJV> data, bool ascending)
        {
            return ascending
                ? data.OrderBy(a => a.TotalArea).ToList()
                : data.OrderByDescending(a => a.TotalArea).ToList();
        }
    }

    public class ApartmentStatisticsService_AJV
    {
        public int GetApartmentsCount(List<Apartment_AJV> data)
        {
            return data.Count;
        }

        public double GetAverageTotalArea(List<Apartment_AJV> data)
        {
            return data.Any() ? data.Average(a => a.TotalArea) : 0;
        }

        public double GetMinTotalArea(List<Apartment_AJV> data)
        {
            return data.Any() ? data.Min(a => a.TotalArea) : 0;
        }

        public double GetMaxTotalArea(List<Apartment_AJV> data)
        {
            return data.Any() ? data.Max(a => a.TotalArea) : 0;
        }

        public int GetApartmentsWithDebtCount(List<Apartment_AJV> data)
        {
            return data.Count(a => a.HasDebt);
        }
    }
}
