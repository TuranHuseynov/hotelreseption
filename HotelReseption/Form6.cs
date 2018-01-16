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
    public partial class Form6 : Form
    {
        HotelReseptionDataEntities db = new HotelReseptionDataEntities();
        public Form6()
        {
            InitializeComponent();
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            //Fill comboboxes
            foreach (var item in db.Expences_Types)
            {
                cmbexpence.Items.Add(item.expences_type_name);
            }

            foreach (var item in db.Payments)
            {
                cmbpayment.Items.Add(item.payment_type_id);
            }

            fillExpences();
        }

        private void btnexpence_Click(object sender, EventArgs e)
        {

            var exptesviri = textBox1.Text;
            int expsayi = Convert.ToInt32(this.textBox3.Text);
            var expnovu = db.Expences_Types.Where(t => t.expences_type_name == this.cmbexpence.Text).First().id;
            var paymentnovu = db.Payment_Types.Where(p => p.payment_type_name == this.cmbpayment.Text).First().id;
            

            var newExpences = new Expence();
            newExpences.expence_description = exptesviri;
            newExpences.expence_amount = expsayi;
            newExpences.expence_type_id = expnovu;
            newExpences.payment_id = paymentnovu;
            db.Expences.Add(newExpences);
            db.SaveChanges();
            fillExpences();

        }
        private void fillExpences()
        {
            int c = 0;
            dataGridExpence.Rows.Clear();
            List<Expence> list = db.Expences.ToList();
            foreach (Expence item in list)
            {
                dataGridExpence.Rows.Add();
                dataGridExpence.Rows[c].Cells[0].Value = item.expence_type_id;
                dataGridExpence.Rows[c].Cells[1].Value = item.expence_description;
                dataGridExpence.Rows[c].Cells[2].Value = item.expence_amount;
                dataGridExpence.Rows[c].Cells[3].Value = item.payment_id;
                
                c++;
            }
        }
    }
}
