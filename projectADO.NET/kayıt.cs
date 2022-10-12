using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace projectADO.NET
{
    public partial class kayıt : Form
    {
        public kayıt()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=10.22.0.23; Database =M05; Integrated Security=True;");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "klogin";
            cmd.Parameters.AddWithValue("Kullanıcıadı", textBox1.Text);
            cmd.Parameters.AddWithValue("Sifre", textBox2.Text);
            cmd.ExecuteReader();
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //if(dr.Read())
            //{
            //    MessageBox.Show("kullanıcı giriş başarılı");
            //    Form1 go = new Form1();
            //    go.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("giriş hatalı");
            //    textBox1.Clear();
            //    textBox2.Clear();
            //}
            con.Close();
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void kayıt_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "KULLANICI EKLE";
            cmd.Parameters.AddWithValue("kullanıcı adı", textBox3.Text);
            cmd.Parameters.AddWithValue("ŞİFRE", textBox4.Text);
            cmd.Parameters.AddWithValue("MAİL", textBox5.Text);
            cmd.Parameters.AddWithValue("TELEFON", maskedTextBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("KAYIT OLUNDU");
            con.Close();





        }
    }
}
