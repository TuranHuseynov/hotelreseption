namespace HotelReseption
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.addRoom = new System.Windows.Forms.Button();
            this.btnRoomDetails = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.roomPrice = new System.Windows.Forms.TextBox();
            this.bedCount = new System.Windows.Forms.TextBox();
            this.reservationST = new System.Windows.Forms.CheckBox();
            this.roomST = new System.Windows.Forms.CheckBox();
            this.clearST = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEmployer = new System.Windows.Forms.Button();
            this.btnExpences = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addRoom
            // 
            this.addRoom.BackColor = System.Drawing.Color.SteelBlue;
            this.addRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addRoom.Location = new System.Drawing.Point(556, 13);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(75, 23);
            this.addRoom.TabIndex = 0;
            this.addRoom.Text = "Add Room";
            this.addRoom.UseVisualStyleBackColor = false;
            this.addRoom.Click += new System.EventHandler(this.addRoom_Click);
            // 
            // btnRoomDetails
            // 
            this.btnRoomDetails.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRoomDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRoomDetails.Location = new System.Drawing.Point(659, 13);
            this.btnRoomDetails.Name = "btnRoomDetails";
            this.btnRoomDetails.Size = new System.Drawing.Size(75, 23);
            this.btnRoomDetails.TabIndex = 0;
            this.btnRoomDetails.Text = "Room Details";
            this.btnRoomDetails.UseVisualStyleBackColor = false;
            this.btnRoomDetails.Click += new System.EventHandler(this.btnRoomDetails_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBooking.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBooking.Location = new System.Drawing.Point(556, 52);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(75, 23);
            this.btnBooking.TabIndex = 0;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // roomNumber
            // 
            this.roomNumber.Location = new System.Drawing.Point(133, 58);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(138, 20);
            this.roomNumber.TabIndex = 1;
            // 
            // cmbTypes
            // 
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(132, 136);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(139, 21);
            this.cmbTypes.TabIndex = 2;
            // 
            // roomPrice
            // 
            this.roomPrice.Location = new System.Drawing.Point(133, 110);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(138, 20);
            this.roomPrice.TabIndex = 1;
            // 
            // bedCount
            // 
            this.bedCount.Location = new System.Drawing.Point(133, 84);
            this.bedCount.Name = "bedCount";
            this.bedCount.Size = new System.Drawing.Size(138, 20);
            this.bedCount.TabIndex = 1;
            // 
            // reservationST
            // 
            this.reservationST.AutoSize = true;
            this.reservationST.BackColor = System.Drawing.Color.Transparent;
            this.reservationST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationST.ForeColor = System.Drawing.SystemColors.Control;
            this.reservationST.Location = new System.Drawing.Point(297, 59);
            this.reservationST.Name = "reservationST";
            this.reservationST.Size = new System.Drawing.Size(194, 19);
            this.reservationST.TabIndex = 3;
            this.reservationST.Text = "Room Reservation status :";
            this.reservationST.UseVisualStyleBackColor = false;
            // 
            // roomST
            // 
            this.roomST.AutoSize = true;
            this.roomST.BackColor = System.Drawing.Color.Transparent;
            this.roomST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomST.ForeColor = System.Drawing.SystemColors.Control;
            this.roomST.Location = new System.Drawing.Point(297, 116);
            this.roomST.Name = "roomST";
            this.roomST.Size = new System.Drawing.Size(114, 19);
            this.roomST.TabIndex = 3;
            this.roomST.Text = "Room status :";
            this.roomST.UseVisualStyleBackColor = false;
            // 
            // clearST
            // 
            this.clearST.AutoSize = true;
            this.clearST.BackColor = System.Drawing.Color.Transparent;
            this.clearST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearST.ForeColor = System.Drawing.SystemColors.Control;
            this.clearST.Location = new System.Drawing.Point(297, 86);
            this.clearST.Name = "clearST";
            this.clearST.Size = new System.Drawing.Size(165, 19);
            this.clearST.TabIndex = 3;
            this.clearST.Text = "Room cleanin status :";
            this.clearST.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Room Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bed Count :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Types :";
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.datagrid.GridColor = System.Drawing.Color.CadetBlue;
            this.datagrid.Location = new System.Drawing.Point(12, 241);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(762, 126);
            this.datagrid.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "R.Number";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "R.Type";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bed Count";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "R.Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "R.Reservation";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "R.Cleaning";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "R.Status";
            this.Column8.Name = "Column8";
            // 
            // btnEmployer
            // 
            this.btnEmployer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEmployer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployer.Location = new System.Drawing.Point(659, 52);
            this.btnEmployer.Name = "btnEmployer";
            this.btnEmployer.Size = new System.Drawing.Size(75, 23);
            this.btnEmployer.TabIndex = 6;
            this.btnEmployer.Text = "Employer";
            this.btnEmployer.UseVisualStyleBackColor = false;
            this.btnEmployer.Click += new System.EventHandler(this.btnEmployer_Click);
            // 
            // btnExpences
            // 
            this.btnExpences.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExpences.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExpences.Location = new System.Drawing.Point(556, 87);
            this.btnExpences.Name = "btnExpences";
            this.btnExpences.Size = new System.Drawing.Size(75, 23);
            this.btnExpences.TabIndex = 7;
            this.btnExpences.Text = "Expence";
            this.btnExpences.UseVisualStyleBackColor = false;
            this.btnExpences.Click += new System.EventHandler(this.btnExpences_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuest.Location = new System.Drawing.Point(659, 87);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(75, 23);
            this.btnGuest.TabIndex = 8;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(HotelReseption.Room);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 379);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnExpences);
            this.Controls.Add(this.btnEmployer);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearST);
            this.Controls.Add(this.roomST);
            this.Controls.Add(this.reservationST);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.bedCount);
            this.Controls.Add(this.roomPrice);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnRoomDetails);
            this.Controls.Add(this.addRoom);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRoom;
        private System.Windows.Forms.Button btnRoomDetails;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.TextBox roomPrice;
        private System.Windows.Forms.TextBox bedCount;
        private System.Windows.Forms.CheckBox reservationST;
        private System.Windows.Forms.CheckBox roomST;
        private System.Windows.Forms.CheckBox clearST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnEmployer;
        private System.Windows.Forms.Button btnExpences;
        private System.Windows.Forms.Button btnGuest;
    }
}