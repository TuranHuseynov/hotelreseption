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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        HotelReseptionDataEntities db = new HotelReseptionDataEntities();

        private void Form7_Load(object sender, EventArgs e)
        {
            //Fill comboboxes
            foreach (var item in db.Users)
            {
                cmbUser.Items.Add(item.user_full_name);
            }

            foreach (var item in db.Bookings)
            {
                cmbBooking.Items.Add(item.booking_code);
            }
            fillGuests();


        }
        private void btnGuest_Click(object sender, EventArgs e)
        {
            var userId = db.Users.Where(u => u.id == Convert.ToInt32(this.cmbUser.Text)).First().id;
            int booknovuId = db.Bookings.Where(b => b.id == Convert.ToInt32(this.cmbBooking.Text)).First().id;


            var newGuest = new Guest();
            newGuest.User.id = userId;
            newGuest.Booking.booking_code = booknovuId;
            db.Guests.Add(newGuest);
            db.SaveChanges();
            fillGuests();
        }
        private void fillGuests()
        {
            int g = 0;
            dataGridGuest.Rows.Clear();
            List<Guest> list = db.Guests.ToList();
            foreach (Guest item in list)
            {
                dataGridGuest.Rows.Add();
                dataGridGuest.Rows[g].Cells[0].Value = item.User.user_full_name;
                dataGridGuest.Rows[g].Cells[1].Value = item.Booking.booking_code;
  
                g++;
            }
        }


    }
}
