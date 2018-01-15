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
    public partial class Form3 : Form
    {
        HotelReseptionDataEntities db = new HotelReseptionDataEntities();
        public Form3()
        {
            InitializeComponent();
            fillRoomDetail();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach(var item in db.Rooms)
            {
                cmbRNumber.Items.Add(item.room_number);
            }
            foreach (var item in db.Room_Details)
            {
                cmbRDetail.Items.Add(item.detail_name);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int roomNumber = Convert.ToInt32(this.cmbRNumber.Text);
            int roomId = db.Rooms.Where(r => r.room_number == roomNumber).First().id;
            int detailId = db.Room_Details.Where(d => d.detail_name == this.cmbRDetail.Text).First().id;

            Room_Details rmdetails = new Room_Details();
            rmdetails.id = roomId;
            rmdetails.detail_name = detailId.ToString();
            db.Room_Details.Add(rmdetails);
            db.SaveChanges();
            fillRoomDetail();
        }

        private void fillRoomDetail()
        {
            var a = 0;
            dataGridDetail.Rows.Clear();
            List<Room_Details> list = db.Room_Details.ToList();
            foreach (Room_Details item in list)
            {
                dataGridDetail.Rows.Add();
                dataGridDetail.Rows[a].Cells[0].Value = item.id;
                dataGridDetail.Rows[a].Cells[1].Value = item.detail_name;
                a++;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var adddetail = this.newdetail.Text;
            var newDetail = new Room_Details();
            newDetail.detail_name = adddetail;
            db.Room_Details.Add(newDetail);
            db.SaveChanges();


        }

       
    }
}
