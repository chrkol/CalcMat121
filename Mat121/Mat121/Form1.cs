using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
           
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            spawnMatrix(x, y);
        }

        public void spawnMatrix(int x, int y)
        {
           //FACK
            TextBox txt = new TextBox();
          
                
                txt.Text = "0";
           

            txt.Top = 140;
            txt.Left = 560;
                this.Controls.Add(txt);
            
             
                
                
         
        }
    }
}
