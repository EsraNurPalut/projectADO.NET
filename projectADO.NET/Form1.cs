using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //poliklinik buton
        {
            poliklinikler go = new poliklinikler();
            go.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktor go = new doktor();
            go.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hastalar go = new hastalar();
            go.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hraporlama go = new Hraporlama();
            go.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Draporlama go = new Draporlama();
            go.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Praporlama go = new Praporlama();
            go.Show();
            this.Hide();
        }
    }
}
