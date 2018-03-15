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

        //This function reads from a .txt file. The function doesnt work with SpawnMatrix() because of parsing issues.
        private void openTextTask()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        //This function filters the text from rtb1 into a double array.
        public double[] spawnMatrix()
        {
            //Doesn't work with .txt files

            //Splits the text from richtextbox1(removes the , between the numbers)
            Char delimiter = ',';
            String[] all = richTextBox1.Text.Split(delimiter);
            Double[] allN = new double[all.Length];

            for (int i = 0; i < all.Length; i++)
            {
                //since rtb1 is a string, we have to parse it to a double
                Double mem = double.Parse(all[i]);
                allN[i] = mem;
                System.Console.WriteLine(all[i]);
                System.Console.WriteLine(allN[i]);
            }
            return allN;

        }

        public void rowR(double[] allN)
        {
            //col1 = 0,3,6
            double[] matrix = allN;
            System.Console.WriteLine(matrix[1] + " " + matrix[3]);

            if (matrix.Length == 9)
            {
                while (matrix[0] != 1 && matrix[3] != 1 && matrix[6] != 1)
                {
                    //ex: matrix A = 0,2,3,2,4,5,6,7,8
                    if (matrix[0] == 1)
                    {
                        System.Console.Write("No need to move");
                        //if (matrix[3] < matrix[6])
                        //{
                        //    double numb = matrix[6] - matrix[3];
                        //    if(matrix[6]%numb == 0)
                        //    {
                        //        matrix[7]*
                        //    }
                        //    
                        //    
                        //}
                        
                        //Checks if there is a 0 before the pivot position and modifies if necessary
                        if (matrix[3] == 0)
                        {
                            System.Console.Write("No need to move");
                        }
                        else if (matrix[6] == 0)
                        {
                            double mem = matrix[3];
                            double mem2 = matrix[4];
                            double mem3 = matrix[5];
                            matrix[3] = matrix[6];
                            matrix[4] = matrix[7];
                            matrix[5] = matrix[8];
                            matrix[6] = mem;
                            matrix[7] = mem2;
                            matrix[8] = mem3;
                        }
                    }
                    //ex: matrix A = 1,2,3,0,4,5,6,7,8
                    else if (matrix[3] == 1)
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
                        //Prints the modified matrix into rtb2 (Doesn't work)
                        richTextBox2.Text = matrix[0] + " " + matrix[1] + " " + matrix[2] + "\n" + matrix[3] + " " + matrix[4] + " " + matrix[5] + "\n" + matrix[6] + " " + matrix[7] + " " + matrix[8];


                    }
                    //ex: matrix A = 1,2,3,3,4,5,0,7,8
                    else if (matrix[6] == 1)
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
            }


            if (matrix.Length == 16)
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
            rowR(spawnMatrix());
        }
    }
}

