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
    public partial class Form4 : Form
    {
        HotelReseptionDataEntities db = new HotelReseptionDataEntities();
        public Form4()
        {
            InitializeComponent();
            fillBooking();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Users)
            {
                cmbUserid.Items.Add(item.user_full_name);
            }
            foreach (var item in db.Room_Types)
            {
                cmbRoomTypeid.Items.Add(item.room_type_name);

            }
            
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            var boyuksayi = Convert.ToInt32(this.adultcount.Text);
            var usaqsayi = Convert.ToInt32(this.childcount.Text);
            var booksifre = Convert.ToInt32(this.bookingcode.Text);
            bool bookingvezyeti = bookingST.Checked;
            var otaqnovuid = db.Room_Types.Where(t => t.room_type_name == this.cmbRoomTypeid.Text).First().id;
            var istifadeid = db.Users.Where(u => u.user_full_name == this.cmbUserid.Text).First().id;
            var invaxt = checkinDate.Value;
            var outvaxt = checkoutDate.Value;

            var newBooking = new Booking();
            newBooking.adult_count = boyuksayi;
            newBooking.booking_code = booksifre;
            newBooking.child_count = usaqsayi;
            newBooking.room_type_id = otaqnovuid;
            newBooking.user_id = istifadeid;
            newBooking.booking_status = bookingvezyeti;
            newBooking.check_in_date = invaxt;
            newBooking.check_out_date = outvaxt;


            db.Bookings.Add(newBooking);
            db.SaveChanges();
            fillBooking();

        }

        private void fillBooking()
        {
            int b = 0;
            DataBooking.Rows.Clear();
            List<Booking> list = db.Bookings.ToList();
            foreach (Booking item in list)
            {
                DataBooking.Rows.Add();
                DataBooking.Rows[b].Cells[0].Value = item.id;
                DataBooking.Rows[b].Cells[1].Value = item.booking_code;
                DataBooking.Rows[b].Cells[2].Value = item.check_in_date;
                DataBooking.Rows[b].Cells[3].Value = item.check_out_date;
                DataBooking.Rows[b].Cells[4].Value = item.adult_count;
                DataBooking.Rows[b].Cells[5].Value = item.child_count;
                DataBooking.Rows[b].Cells[6].Value = item.Room_Types.room_type_name;
                DataBooking.Rows[b].Cells[7].Value = item.User.user_full_name;
                DataBooking.Rows[b].Cells[8].Value = item.booking_status;
                b++;

            }
        }
    }
}
