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
    public partial class doktor : Form
    {
        public doktor()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=10.22.0.23; Database =M05; Integrated Security=True;");


        private void label12_Click(object sender, EventArgs e)
        {

        }
        public void listele1()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dlistele";

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
            cmd.CommandText = "dekle";
            cmd.Parameters.AddWithValue("doktoradsoyad", textBox2.Text);
            cmd.Parameters.AddWithValue("doktortcno", textBox3.Text);
            cmd.Parameters.AddWithValue("uzmanlıkalanı", textBox4.Text);
            cmd.Parameters.AddWithValue("ünvanı", textBox5.Text);
            cmd.Parameters.AddWithValue("telefon", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("adres", textBox6.Text);
            cmd.Parameters.AddWithValue("dogumtarihi", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("poliklinikno", textBox9.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            listele1();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dyenile";
            cmd.Parameters.AddWithValue("doktorno", textBox1.Text);
            cmd.Parameters.AddWithValue("doktoradsoyad", textBox2.Text);
            cmd.Parameters.AddWithValue("doktortcno", textBox3.Text);
            cmd.Parameters.AddWithValue("uzmanlıkalanı", textBox4.Text);
            cmd.Parameters.AddWithValue("ünvanı", textBox5.Text);
            cmd.Parameters.AddWithValue("telefon", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("adres", textBox6.Text);
            cmd.Parameters.AddWithValue("dogumtarihi", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("poliklinikno", textBox9.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            listele1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dara";
            cmd.Parameters.AddWithValue("doktorNo", textBox7.Text);
            cmd.Parameters.AddWithValue("doktoradsoyad", textBox8.Text);
            cmd.Parameters.AddWithValue("doktortcno", textBox9.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }
    }
}
