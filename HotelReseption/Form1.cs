using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReseption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(username.Text == "admin" && parol.Text == "admin")
            {
                Form2 reseption = new Form2();
                reseption.ShowDialog();
            }
            else
            {
                elsems.Text = "Your username or password incorrect";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
