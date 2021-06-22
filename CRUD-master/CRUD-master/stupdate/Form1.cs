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

namespace stupdate
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        SqlConnection conn = new SqlConnection("Server=DESKTOP-R7V17QH\\PAAVAISQLEXPRESS; Database=stdetails; Integrated Security=SSPI");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand newcom = conn.CreateCommand();
            newcom.CommandType = CommandType.Text;
            newcom.CommandText = "insert into details values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            newcom.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data inserted successfully");
        }

        public void display()
        {
            conn.Open();
            SqlCommand newcom = conn.CreateCommand();
            newcom.CommandType = CommandType.Text;
            newcom.CommandText = "select * from details";
            newcom.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(newcom);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand newcom = conn.CreateCommand();
            newcom.CommandType = CommandType.Text;
            newcom.CommandText = "delete from details where stname = '"+textBox1.Text+"'";
            newcom.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data deleted successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand newcom = conn.CreateCommand();
            newcom.CommandType = CommandType.Text;
            newcom.CommandText = "update details set stname = '" + textBox2.Text + "' where stname = '" + textBox1.Text + "'" ;
            newcom.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data updated successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
