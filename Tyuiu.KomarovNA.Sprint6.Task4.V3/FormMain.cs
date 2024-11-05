using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomarovNA.Sprint6.Task4.V3.Lib;

namespace Tyuiu.KomarovNA.Sprint6.Task4.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonSaveClick(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранен успешно! \n Хотите его открыть?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка с сохранением файла", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doButton_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            textBoxResult.AppendText("+----------+--------+" + Environment.NewLine);
            textBoxResult.AppendText("|     X    |  f(X)  |" + Environment.NewLine);
            textBoxResult.AppendText("+----------+--------+" + Environment.NewLine);
            try
            {
                int start = Convert.ToInt32(start_input.Text);
                int end = Convert.ToInt32(end_input.Text);
                int i = start;
                string spacing = "";
                foreach (int num in ds.GetMassFunction(start, end))
                {
                    if (i >= 0) spacing = " ";
                    textBoxResult.AppendText($"     {spacing}{i}    |   {num}" + Environment.NewLine);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Внимание! Ошибка. Вы ошиблись.");
            }
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-24-1 Комаров Никита Алексеевич", "Информация");
        }
    }
}