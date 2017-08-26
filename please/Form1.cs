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

namespace please
{
    public partial class Form1 : Form
    {
       // public string constring = "Data Source=DESKTOP-G0GJSB7\SQLDATA;Initial Catalog = SQLDataB; Integrated Security = True";
        // SqlConnection con = new SqlConnection(constring);
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
          //  con.Open();
            // SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select Tutorname, Tutoremail from Tutorslist where degree = '" + listBox7.SelectedItem.ToString() + "' AND CRN = '" + listBox8.SelectedItem.ToString()";
            //cmd.ExecuteNonQuery();
            //con.Close();
                    
        }

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            listBox5.Items.Add("Kent State University");
            listBox6.Items.Add("Accounting");
            listBox6.Items.Add("Aeronautical Engineering");
            listBox6.Items.Add("Biotechnology");
            listBox6.Items.Add("Business Administration");
            listBox6.Items.Add("Chemical Engineering");
            listBox6.Items.Add("Computer Engineering");
            listBox6.Items.Add("Computer and Information Sciences");
            listBox6.SelectionMode = SelectionMode.MultiSimple;
            listBox7.Items.Add("Undergraduate");
            listBox7.Items.Add("Masters");
            listBox7.Items.Add("Ph.D");
            listBox7.SelectionMode = SelectionMode.MultiSimple;
            listBox8.Items.Add("12234");
            listBox8.Items.Add("12235");
            listBox8.Items.Add("12236");
            listBox8.Items.Add("12237");
            listBox8.SelectionMode = SelectionMode.MultiSimple;
           // string degrees;
            //degrees = listBox7.Text;
            //string course;
            //course = listBox8.Text;
        }
    }
}

