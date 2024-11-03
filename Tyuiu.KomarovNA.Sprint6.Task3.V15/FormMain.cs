using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomarovNA.Sprint6.Task3.V15.Lib;

namespace Tyuiu.KomarovNA.Sprint6.Task3.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            int[,] matrix = {
                            { 33, 28, 31, -17, 4 },
                            { 1, 32, -3, 7, -12 },
                            { 24, -19, 26, 31, -3 },
                            { 30, -16, 29, 28, 8 },
                            { 30, 5, 11, 7, 32 }
                };
            inputGrid.ColumnCount = matrix.GetLength(1);
            inputGrid.RowCount = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    inputGrid.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        DataService ds = new DataService();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void doButton_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[inputGrid.RowCount, inputGrid.ColumnCount];
            for (int i = 0; i < inputGrid.RowCount; i++)
            {
                for (int j = 0; j < inputGrid.ColumnCount; j++)
                {
                    matrix[i, j] = Convert.ToInt32(inputGrid.Rows[i].Cells[j].Value);
                }
            }

            try
            {
                matrix = ds.Calculate(matrix);
                resultBox.ColumnCount = matrix.GetLength(1);
                resultBox.RowCount = matrix.GetLength(0);

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        resultBox.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-24-1 Комаров Никита Алексеевич", "Информация");
        }
    }
}