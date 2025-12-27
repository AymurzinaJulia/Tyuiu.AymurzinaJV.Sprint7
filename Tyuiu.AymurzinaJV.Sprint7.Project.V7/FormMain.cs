using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.AymurzinaJV.Sprint6.Task7.V28;

namespace Tyuiu.AymurzinaJV.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        private List<Apartment_AJV> apartments = new List<Apartment_AJV>();

        public FormMain()
        {
            InitializeComponent();
            dataGridView_AJV.RowHeadersVisible = false;
            comboBoxFilter_AJV.SelectedIndex = 0;
            comboBoxDebt_AJV.SelectedIndex = 0;
            RefreshGrid();
        }


        private void RefreshGrid(IEnumerable<Apartment_AJV>? source = null)
        {
            dataGridView_AJV.DataSource = null;
            dataGridView_AJV.DataSource = source?.ToList() ?? apartments.ToList();


            if (dataGridView_AJV.Columns.Count == 0) return;

            dataGridView_AJV.Columns[nameof(Apartment_AJV.EntranceNumber)].HeaderText = "№ подъезда";
            dataGridView_AJV.Columns[nameof(Apartment_AJV.ApartmentNumber)].HeaderText = "№ квартиры";
            dataGridView_AJV.Columns[nameof(Apartment_AJV.OwnerSurname)].HeaderText = "Фамилия";
            dataGridView_AJV.Columns[nameof(Apartment_AJV.OwnerName)].HeaderText = "Имя";
            dataGridView_AJV.Columns[nameof(Apartment_AJV.TotalArea)].HeaderText = "Общая площадь";
            dataGridView_AJV.Columns[nameof(Apartment_AJV.UsefulArea)].HeaderText = "Полезная площадь";
            dataGridView_AJV.Columns[nameof(Apartment_AJV.RoomsCount)].HeaderText = "Комнат";
            dataGridView_AJV.Columns[nameof(Apartment_AJV.FamilyCount)].HeaderText = "Жильцов";
            dataGridView_AJV.Columns[nameof(Apartment_AJV.ChildrenCount)].HeaderText = "Детей";
            dataGridView_AJV.Columns[nameof(Apartment_AJV.HasDebt)].HeaderText = "Задолженность";



            foreach (DataGridViewColumn col in dataGridView_AJV.Columns)
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            UpdateChart();
        }

        private void buttonAdd_AJV_Click(object sender, EventArgs e)
        {
            try
            {
                Apartment_AJV apartment = new Apartment_AJV
                {
                    EntranceNumber = int.Parse(textBoxEntranceNumber_AJV.Text),
                    ApartmentNumber = int.Parse(textBoxApartmentNumber_AJV.Text),
                    OwnerSurname = textBoxSurname_AJV.Text,
                    OwnerName = textBoxName_AJV.Text,
                    TotalArea = double.Parse(textBoxArea_AJV.Text),
                    UsefulArea = double.Parse(textBoxUsefulArea_AJV.Text),
                    RoomsCount = int.Parse(textBoxRoomsCount_AJV.Text),
                    FamilyCount = int.Parse(textBoxFamilyCount_AJV.Text),
                    ChildrenCount = int.Parse(textBoxChildrenCount_AJV.Text),
                    HasDebt = comboBoxDebt_AJV.SelectedItem?.ToString() ?? "Нет" 
                };

                apartments.Add(apartment);
                RefreshGrid();
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных!");
            }
        }

        private void buttonDelete_AJV_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDeleteApartmentNumber_AJV.Text, out int number))
            {
                apartments.RemoveAll(a => a.ApartmentNumber == number);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Введите корректный номер квартиры!");
            }
        }

        private void buttonSearch_AJV_Click(object sender, EventArgs e)
        {
            string surname = textBoxSearchSurname_AJV.Text.ToLower();
            var result = apartments
                .Where(a => a.OwnerSurname.ToLower().Contains(surname))
                .ToList();
            RefreshGrid(result);
        }

        private void comboBoxDebtFilter_AJV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter_AJV.SelectedIndex == -1) return;

            string filter = comboBoxFilter_AJV.SelectedItem?.ToString();
            var filtered = apartments.Where(a => a.HasDebt == filter).ToList();
            RefreshGrid(filtered);
        }


        private void buttonSort_AJV_Click(object sender, EventArgs e)
        {
            if (comboBoxSortField_AJV.SelectedIndex == -1 || comboBoxSortDirection_AJV.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите поле и направление сортировки");
                return;
            }

            string field = comboBoxSortField_AJV.SelectedItem.ToString();
            bool ascending = comboBoxSortDirection_AJV.SelectedItem.ToString() == "По возрастанию";

            IEnumerable<Apartment_AJV> sorted = apartments;

            switch (field)
            {
                case "Номер квартиры":
                    sorted = ascending ? apartments.OrderBy(a => a.ApartmentNumber) : apartments.OrderByDescending(a => a.ApartmentNumber);
                    break;
                case "Фамилия":
                    sorted = ascending ? apartments.OrderBy(a => a.OwnerSurname) : apartments.OrderByDescending(a => a.OwnerSurname);
                    break;
                case "Общая площадь":
                    sorted = ascending ? apartments.OrderBy(a => a.TotalArea) : apartments.OrderByDescending(a => a.TotalArea);
                    break;
                case "Количество комнат":
                    sorted = ascending ? apartments.OrderBy(a => a.RoomsCount) : apartments.OrderByDescending(a => a.RoomsCount);
                    break;
            }

            RefreshGrid(sorted);
        }

   
        private void buttonShowAll_AJV_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void buttonSave_AJV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using var sw = new System.IO.StreamWriter(sfd.FileName);
                foreach (var a in apartments)
                {
                    sw.WriteLine($"{a.EntranceNumber};{a.ApartmentNumber};{a.OwnerSurname};{a.OwnerName};" +
                                 $"{a.TotalArea};{a.UsefulArea};{a.RoomsCount};{a.FamilyCount};{a.ChildrenCount};{a.HasDebt}");
                }
                MessageBox.Show("Данные сохранены");
            }
        }

        private void buttonLoad_AJV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV file (*.csv)|*.csv"; 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                apartments.Clear();
                var lines = System.IO.File.ReadAllLines(ofd.FileName, System.Text.Encoding.UTF8); 

                foreach (var line in lines)
                {
                    var parts = line.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 10) 
                    {
                        apartments.Add(new Apartment_AJV
                        {
                            EntranceNumber = int.Parse(parts[0]),
                            ApartmentNumber = int.Parse(parts[1]),
                            OwnerSurname = parts[2],
                            OwnerName = parts[3],
                            TotalArea = double.Parse(parts[4].Replace('.', ',')),
                            UsefulArea = double.Parse(parts[5].Replace('.', ',')),
                            RoomsCount = int.Parse(parts[6]),
                            FamilyCount = int.Parse(parts[7]),
                            ChildrenCount = int.Parse(parts[8]),
                            HasDebt = parts[9].Trim() 
                        });
                    }
                }

                RefreshGrid();

            }
        }


        private void buttonAbout_AJV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonFilter_AJV_Click(object sender, EventArgs e)
        {
            if (comboBoxFilter_AJV.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите поле для фильтрации");
                return;
            }

            string field = comboBoxFilter_AJV.SelectedItem.ToString();
            string value = textBoxFilter_AJV.Text.Trim().ToLower();

            IEnumerable<Apartment_AJV> filtered = apartments;

            switch (field)
            {
                case "Имя":
                    filtered = apartments.Where(a => a.OwnerName.ToLower().Contains(value));
                    break;

                case "Фамилия":
                    filtered = apartments.Where(a => a.OwnerSurname.ToLower().Contains(value));
                    break;

                case "Номер квартиры":
                    if (!int.TryParse(value, out int flat))
                    {
                        MessageBox.Show("Введите номер квартиры");
                        return;
                    }
                    filtered = apartments.Where(a => a.ApartmentNumber == flat);
                    break;

                case "Номер подъезда":
                    if (!int.TryParse(value, out int entrance))
                    {
                        MessageBox.Show("Введите номер подъезда");
                        return;
                    }
                    filtered = apartments.Where(a => a.EntranceNumber == entrance);
                    break;

                case "Количество комнат":
                    if (!int.TryParse(value, out int rooms))
                    {
                        MessageBox.Show("Введите количество комнат");
                        return;
                    }
                    filtered = apartments.Where(a => a.RoomsCount == rooms);
                    break;

                case "Количество жильцов":
                    if (!int.TryParse(value, out int family))
                    {
                        MessageBox.Show("Введите количество жильцов");
                        return;
                    }
                    filtered = apartments.Where(a => a.FamilyCount == family);
                    break;

                case "Количество детей":
                    if (!int.TryParse(value, out int children))
                    {
                        MessageBox.Show("Введите количество детей");
                        return;
                    }
                    filtered = apartments.Where(a => a.ChildrenCount == children);
                    break;

                case "Общая площадь":
                    if (!double.TryParse(value.Replace('.', ','), out double totalArea))
                    {
                        MessageBox.Show("Введите число (например 45,5)");
                        return;
                    }
                    filtered = apartments.Where(a => a.TotalArea >= totalArea);
                    break;

                case "Полезная площадь":
                    if (!double.TryParse(value.Replace('.', ','), out double usefulArea))
                    {
                        MessageBox.Show("Введите число (например 30,0)");
                        return;
                    }
                    filtered = apartments.Where(a => a.UsefulArea >= usefulArea);
                    break;

                case "Задолженность":
                    filtered = apartments.Where(a => a.HasDebt.ToLower() == value);
                    break;
            }

            RefreshGrid(filtered);
        }

        private void UpdateChart()
        {
            chart_AJV.Series.Clear();
            chart_AJV.ChartAreas.Clear();

            chart_AJV.ChartAreas.Add(new ChartArea());

            int withDebt = apartments.Count(a => a.HasDebt == "Да");
            int withoutDebt = apartments.Count(a => a.HasDebt == "Нет");

            Series series = new Series
            {
                Name = "Задолженность",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            series.Points.AddXY("С задолженностью", withDebt);
            series.Points.AddXY("Без задолженности", withoutDebt);

            chart_AJV.Series.Add(series);
        }

        private void buttonStats_AJV_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics(apartments);
            formStatistics.ShowDialog();
        }
    }

    public class Apartment_AJV
    {
        public int EntranceNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public string OwnerSurname { get; set; } = "";
        public string OwnerName { get; set; } = "";
        public double TotalArea { get; set; }
        public double UsefulArea { get; set; }
        public int RoomsCount { get; set; }
        public int FamilyCount { get; set; }
        public int ChildrenCount { get; set; }
        public string HasDebt { get; set; } = "Нет";
    }
}
