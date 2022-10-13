using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectADO.NET
{
    public partial class poliklinikler : Form
    {
        public poliklinikler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("server=10.22.0.23; Database =M05; Integrated Security=True;"); 



        public void getir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "plistele";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pekle";
            cmd.Parameters.AddWithValue("PoliklinikAd", textBox2.Text);
            cmd.Parameters.AddWithValue("PoliklinikUzmanSayısı", textBox3.Text);
            cmd.Parameters.AddWithValue("PoliklinikBaşkanı", textBox4.Text);
            cmd.Parameters.AddWithValue("PoliklinikBaşHemşire", textBox5.Text);
            cmd.Parameters.AddWithValue("YatakSayısı", textBox6.Text);
            cmd.ExecuteNonQuery();            
            con.Close();
            getir();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //poliklinik data grid ekranı. 
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pyenile";
            cmd.Parameters.AddWithValue("PoliklinikNo", textBox1.Text);
            cmd.Parameters.AddWithValue("PoliklinikAd", textBox2.Text);
            cmd.Parameters.AddWithValue("PoliklinikUzmanSayısı", textBox3.Text);
            cmd.Parameters.AddWithValue("PoliklinikBaşkanı", textBox4.Text);
            cmd.Parameters.AddWithValue("PoliklinikBaşHemşire", textBox5.Text);
            cmd.Parameters.AddWithValue("YatakSayısı", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            getir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "para";
            cmd.Parameters.AddWithValue("PoliklinikNo", textBox8.Text);
            cmd.Parameters.AddWithValue("PoliklinikAd", textBox7.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "psil";
            cmd.Parameters.AddWithValue("PoliklinikNo", textBox9.Text);
            cmd.ExecuteNonQuery();      
            con.Close();
            getir();
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 go =new Form1();
            go.Show();
            this.Hide();
           
        }
    }
}
