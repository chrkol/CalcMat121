using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mat121
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openTextTask();
        }

        private void openTextTask()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        public void spawnMatrix()
        {
            //funker fortsatt ikke med å åpne .txt fil :/
            Char delimiter = ',';
            String[] all = richTextBox1.Text.Split(delimiter);
            Double[] allN = new double[all.Length];

            for(int i = 0; i<all.Length; i++)
            {
                Double mem = double.Parse(all[i]);
                allN[i] = mem;
                System.Console.WriteLine(all[i]);
                System.Console.WriteLine(allN[i]);
            }
            rowR(allN);

        }

        public void rowR(double[] allN)
        {
            //col1 = 0,3,6
            double[] matrix = allN;
            
            if (matrix.Length == 9)
            {


                if (matrix[0] == 0)
                {

                }
                if (matrix[3] == 0)
                {
                    double mem = matrix[0];
                    double mem2 = matrix[1];
                    double mem3 = matrix[2];
                    matrix[0] = matrix[3];
                    matrix[1] = matrix[4];
                    matrix[2] = matrix[5];
                    matrix[3] = mem;
                    matrix[4] = mem2;
                    matrix[5] = mem3;
                    //for (int i = 0; i < matrix.Length; i++)
                    //{
                    //    richTextBox2.Text = matrix[0] + " " + matrix[1] + " " + matrix[2] + "\n" + matrix[3] + " " + matrix[4] + " " + matrix[5] + "\n" + matrix[6] + " " + matrix[7] + " " + matrix[8];
                    //}
                }
                if (matrix[6] == 0)
                {
                    double mem = matrix[0];
                    double mem2 = matrix[1];
                    double mem3 = matrix[2];
                    matrix[0] = matrix[6];
                    matrix[1] = matrix[7];
                    matrix[2] = matrix[8];
                    matrix[6] = mem;
                    matrix[7] = mem2;
                    matrix[8] = mem3;
                }
            }

            if(matrix.Length == 16)
            {
              
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            var lineCount = richTextBox1.Lines.Count();
            label1.Text = lineCount.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            spawnMatrix();
        }
    }
}
