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
            foreach (var item in db.Expences_Types)
            {
                cmbexpence.Items.Add(item.expences_type_name);
            }

            foreach (var item in db.Payments)
            {
                cmbpayment.Items.Add(item.payment_type_id);
            }

        }

        private void btnexpence_Click(object sender, EventArgs e)
        {

        }
    }
}
