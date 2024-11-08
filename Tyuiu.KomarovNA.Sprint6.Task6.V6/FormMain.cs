using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomarovNA.Sprint6.Task6.V6.Lib;

namespace Tyuiu.KomarovNA.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string openFilePath = "";
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            this.openFilePath = openFileDialogTask.FileName;
            if (openFilePath == "")
            {
                MessageBox.Show("Файл не был выбран", "Ошибка");
            }
            else
            {
                MessageBox.Show($"Файл {openFilePath} открыт успешно", "Открытие");
                textBoxInput.Text = File.ReadAllText(openFilePath);
                groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialogTask.FileName;
                buttonRun.Enabled = true;
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            textBoxPrint.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}