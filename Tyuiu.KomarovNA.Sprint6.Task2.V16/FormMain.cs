using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomarovNA.Sprint6.Task2.V16.Lib;

namespace Tyuiu.KomarovNA.Sprint6.Task2.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void doButton_Click(object sender, EventArgs e)
        {
            int i = -5;
            try
            {
                foreach (double value in ds.GetMassFunction(Convert.ToInt32(start_input.Text), Convert.ToInt32(end_input.Text)))
                {
                    resultBox.Rows.Add(value);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-1 Комаров Никита Алексеевич", "Информация");
        }

        private void resultBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resultBox_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FAQButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-1 Комаров Никита Алексеевич", "Информация");
        }
    }
}