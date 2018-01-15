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
    public partial class Form2 : Form
    {
        HotelReseptionDataEntities db = new HotelReseptionDataEntities();
        public Form2()
        {
            InitializeComponent();
            fillRooms();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //RoomTypes
            var roomtypes = db.Room_Types.ToList();
            foreach (Room_Types item in roomtypes)
            {
                this.cmbTypes.Items.Add(item.room_type_name);
            }

        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            int otaqnovuId = db.Room_Types.Where(t => t.room_type_name == this.cmbTypes.Text).First().id;
            var bedcount = Convert.ToInt32(this.bedCount.Text);
            var otaqnomresi = Convert.ToInt32(this.roomNumber.Text);
            var otaqqiymeti = Convert.ToInt32(this.roomPrice.Text);
            bool rezervveziyyet = reservationST.Checked;
            bool temizlikveziyyet = clearST.Checked;
            bool otagveziyyet = roomST.Checked;

            var newRoom = new Room();
            newRoom.room_type_id = otaqnovuId;
            newRoom.bed_count = bedcount;
            newRoom.room_number = otaqnomresi;
            newRoom.room_price = otaqqiymeti;
            newRoom.room_reservation_status = rezervveziyyet;
            newRoom.room_cleaning_status = temizlikveziyyet;
            newRoom.room_status = otagveziyyet;
            db.Rooms.Add(newRoom);
            db.SaveChanges();
            fillRooms();
        }

        private void fillRooms()
        {
            var a = 0;
            datagrid.Rows.Clear();
            List<Room> list = db.Rooms.ToList();
            foreach (Room item in list)
            {
                datagrid.Rows.Add();
                datagrid.Rows[a].Cells[0].Value = item.id;
                datagrid.Rows[a].Cells[1].Value = item.room_number;
                datagrid.Rows[a].Cells[2].Value = item.Room_Types.room_type_name;
                datagrid.Rows[a].Cells[3].Value = item.bed_count;
                datagrid.Rows[a].Cells[4].Value = item.room_price;
                datagrid.Rows[a].Cells[5].Value = item.room_reservation_status==true ? "bowdur" : "doludur";
                datagrid.Rows[a].Cells[6].Value = item.room_cleaning_status == true ? "temizdir" : "temiz deyil";
                datagrid.Rows[a].Cells[7].Value = item.room_status == true ? "ishlek" : "Temirdedir";
                a++;

            }

        }

        private void btnRoomDetails_Click(object sender, EventArgs e)
        {
            Form3 detail = new Form3();
            detail.ShowDialog();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Form4 booking = new Form4();
            booking.ShowDialog();
        }


        private void btnEmployer_Click(object sender, EventArgs e)
        {
            Form5 employer = new Form5();
            employer.ShowDialog();

        }
    }
    
}
