using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.AymurzinaJV.Sprint7.Project.V7
{
    public partial class FormStatistics : Form
    {
        private List<Apartment_AJV> apartments;

        public FormStatistics(List<Apartment_AJV> apartments)
        {
            InitializeComponent();
            this.apartments = apartments;
            CalculateStatistics();
        }

        private void CalculateStatistics()
        {
            if (apartments == null || apartments.Count == 0)
            {
                MessageBox.Show("Нет данных для статистики");
                return;
            }

            textBoxCount_AJV.Text = apartments.Count.ToString();
            textBoxSum_AJV.Text = apartments.Sum(a => a.TotalArea).ToString("0.00");
            textBoxAvg_AJV.Text = apartments.Average(a => a.TotalArea).ToString("0.00");
            textBoxMin_AJV.Text = apartments.Min(a => a.TotalArea).ToString("0.00");
            textBoxMax_AJV.Text = apartments.Max(a => a.TotalArea).ToString("0.00");
            textBoxDebt_AJV.Text = apartments.Count(a => a.HasDebt == "Да").ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
