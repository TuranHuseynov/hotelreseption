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
    public partial class Form5 : Form
    {
        HotelReseptionDataEntities db = new HotelReseptionDataEntities();
        public Form5()
        {
            InitializeComponent();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Employer_Types.ToList())
            {
                cmbempTypes.Items.Add(item.employer_type_name);
            }
             fillEmployer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iscinovu = db.Employer_Types.Where(b => b.employer_type_name == this.cmbempTypes.Text).First().id;
            var isciadi = this.empName.Text;
            var iscimaawi = Convert.ToInt32(this.empSalary.Text);
            var iscihaqqinda = this.empinfo.Text;
            var startvaxti = this.empStartTime.Value;
            var endtvaxti = this.empEndTime.Value;


            var newEmployer = new Employer();
            newEmployer.employer_type_id = iscinovu;
            newEmployer.employer_full_name = isciadi;
            newEmployer.employer_salary = iscimaawi;
            newEmployer.employer_info = iscihaqqinda;
            newEmployer.employer_start_time = startvaxti;
            newEmployer.employer_end_time = endtvaxti;
           
            db.Employers.Add(newEmployer);
            db.SaveChanges();
            fillEmployer();
           
        }

        private void fillEmployer()
        {
            int e = 0;
            dgwEmployer.Rows.Clear();
            List<Employer> list = db.Employers.ToList();
            foreach (Employer item in list)
            {
                dgwEmployer.Rows.Add();
                dgwEmployer.Rows[e].Cells[0].Value = item.id;
                dgwEmployer.Rows[e].Cells[1].Value = item.employer_full_name;
                dgwEmployer.Rows[e].Cells[2].Value = item.employer_info;
                dgwEmployer.Rows[e].Cells[3].Value = item.employer_start_time;
                dgwEmployer.Rows[e].Cells[4].Value = item.employer_end_time;
                dgwEmployer.Rows[e].Cells[5].Value = item.employer_salary;
                dgwEmployer.Rows[e].Cells[6].Value = item.employer_type_id;
                e++;
            }
        }


    }
   
}
