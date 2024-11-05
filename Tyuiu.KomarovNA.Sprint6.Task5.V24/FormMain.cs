using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomarovNA.Sprint6.Task5.V24.Lib;

namespace Tyuiu.KomarovNA.Sprint6.Task5.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V24.txt";

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-24-1 Комаров Никита Алексеевич", "Информация");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = this.path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка с открытием файла", "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doButton_Click(object sender, EventArgs e)
        {
            double [] result = ds.LoadFromDataFile(this.path);
            outputGrid.ColumnCount = 2;
            outputGrid.RowCount = result.Length;
            for (int i = 0; i < result.Length; i++)
            {
                outputGrid.Rows[i].Cells[0].Value = i;
                outputGrid.Rows[i].Cells[1].Value = result[i];
            }
        }
    }
}