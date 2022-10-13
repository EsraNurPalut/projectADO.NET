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
    public partial class hastalar : Form
    {
        public hastalar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=10.22.0.23; Database =M05; Integrated Security=True;");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //ekle butonu
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hekle11";
            cmd.Parameters.AddWithValue("HastaAdıSoyadı", textBox2.Text);
            cmd.Parameters.AddWithValue("HastaTC", textBox3.Text);
            cmd.Parameters.AddWithValue("DogumTarihi", textBox4.Text);
            cmd.Parameters.AddWithValue("Boy", textBox5.Text);
            cmd.Parameters.AddWithValue("Yas", textBox6.Text);
            cmd.Parameters.AddWithValue("Reçete", textBox7.Text);
            cmd.Parameters.AddWithValue("RaporDurumu", textBox8.Text);
            cmd.Parameters.AddWithValue("RandevuTarihi", textBox9.Text);
            cmd.Parameters.AddWithValue("DoktorNo", textBox10.Text);         
            cmd.ExecuteNonQuery();
            con.Close();
            listele();

        }
        public void listele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hlistele";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e) //hasta güncelle
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hgüncelle";
            cmd.Parameters.AddWithValue("HastaNo", textBox1.Text);
            cmd.Parameters.AddWithValue("HastaAdıSoyadı", textBox2.Text);
            cmd.Parameters.AddWithValue("HastaTC", textBox3.Text);
            cmd.Parameters.AddWithValue("DogumTarihi", textBox4.Text);
            cmd.Parameters.AddWithValue("Boy", textBox5.Text);
            cmd.Parameters.AddWithValue("Yas", textBox6.Text);
            cmd.Parameters.AddWithValue("Reçete", textBox7.Text);
            cmd.Parameters.AddWithValue("RaporDurumu", textBox8.Text);
            cmd.Parameters.AddWithValue("RandevuTarihi", textBox9.Text);
            cmd.Parameters.AddWithValue("DoktorNo", textBox10.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            listele();
        }

        private void button3_Click(object sender, EventArgs e) //hara butonu
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hara";
            cmd.Parameters.AddWithValue("HastaNo", textBox11.Text);
            cmd.Parameters.AddWithValue("HastaAdıSoyadı", textBox12.Text);
            cmd.Parameters.AddWithValue("HastaTC", textBox13.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
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
            textBox7.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[sec].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.Rows[sec].Cells[9].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e) //hastalistelebutonu
        {
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }
    }
}
