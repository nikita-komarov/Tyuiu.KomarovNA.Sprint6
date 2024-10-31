using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomarovNA.Sprint6.Task1.V12.Lib;

namespace Tyuiu.KomarovNA.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void doButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            resultBox.AppendText("+----------+--------+" + Environment.NewLine);
            resultBox.AppendText("|     X    |  f(X)  |" + Environment.NewLine);
            resultBox.AppendText("+----------+--------+" + Environment.NewLine);

            int i = -5;
            try
            {
                foreach (double value in ds.GetMassFunction(Convert.ToInt32(start_input.Text), Convert.ToInt32(end_input.Text)))
                {
                    resultBox.AppendText($"|     {i}    |  {value}  |" + Environment.NewLine);
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
    }
}