namespace HotelReseption
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.adultcount = new System.Windows.Forms.TextBox();
            this.DataBooking = new System.Windows.Forms.DataGridView();
            this.checkinDate = new System.Windows.Forms.DateTimePicker();
            this.checkoutDate = new System.Windows.Forms.DateTimePicker();
            this.childcount = new System.Windows.Forms.TextBox();
            this.bookingcode = new System.Windows.Forms.TextBox();
            this.cmbRoomTypeid = new System.Windows.Forms.ComboBox();
            this.cmbUserid = new System.Windows.Forms.ComboBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bookingST = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adultcount
            // 
            this.adultcount.Location = new System.Drawing.Point(124, 39);
            this.adultcount.Name = "adultcount";
            this.adultcount.Size = new System.Drawing.Size(118, 20);
            this.adultcount.TabIndex = 0;
            // 
            // DataBooking
            // 
            this.DataBooking.AutoGenerateColumns = false;
            this.DataBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookingcodeDataGridViewTextBoxColumn,
            this.checkindateDataGridViewTextBoxColumn,
            this.checkoutdateDataGridViewTextBoxColumn,
            this.adultcountDataGridViewTextBoxColumn,
            this.childcountDataGridViewTextBoxColumn,
            this.roomtypeidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.bookingstatusDataGridViewCheckBoxColumn});
            this.DataBooking.DataSource = this.bookingBindingSource;
            this.DataBooking.Location = new System.Drawing.Point(21, 206);
            this.DataBooking.Name = "DataBooking";
            this.DataBooking.Size = new System.Drawing.Size(842, 151);
            this.DataBooking.TabIndex = 1;
            // 
            // checkinDate
            // 
            this.checkinDate.Location = new System.Drawing.Point(614, 42);
            this.checkinDate.Name = "checkinDate";
            this.checkinDate.Size = new System.Drawing.Size(200, 20);
            this.checkinDate.TabIndex = 2;
            // 
            // checkoutDate
            // 
            this.checkoutDate.Location = new System.Drawing.Point(614, 70);
            this.checkoutDate.Name = "checkoutDate";
            this.checkoutDate.Size = new System.Drawing.Size(200, 20);
            this.checkoutDate.TabIndex = 2;
            // 
            // childcount
            // 
            this.childcount.Location = new System.Drawing.Point(125, 77);
            this.childcount.Name = "childcount";
            this.childcount.Size = new System.Drawing.Size(118, 20);
            this.childcount.TabIndex = 0;
            // 
            // bookingcode
            // 
            this.bookingcode.Location = new System.Drawing.Point(125, 109);
            this.bookingcode.Name = "bookingcode";
            this.bookingcode.Size = new System.Drawing.Size(117, 20);
            this.bookingcode.TabIndex = 0;
            // 
            // cmbRoomTypeid
            // 
            this.cmbRoomTypeid.FormattingEnabled = true;
            this.cmbRoomTypeid.Location = new System.Drawing.Point(376, 40);
            this.cmbRoomTypeid.Name = "cmbRoomTypeid";
            this.cmbRoomTypeid.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomTypeid.TabIndex = 3;
            // 
            // cmbUserid
            // 
            this.cmbUserid.FormattingEnabled = true;
            this.cmbUserid.Location = new System.Drawing.Point(376, 73);
            this.cmbUserid.Name = "cmbUserid";
            this.cmbUserid.Size = new System.Drawing.Size(121, 21);
            this.cmbUserid.TabIndex = 3;
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(715, 129);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(99, 29);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Text = "Booking ";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Child Count :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(18, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adult Count :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Booking Code :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(257, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Room Type id :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(298, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "User id :";
            // 
            // bookingST
            // 
            this.bookingST.AutoSize = true;
            this.bookingST.BackColor = System.Drawing.Color.Transparent;
            this.bookingST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingST.ForeColor = System.Drawing.SystemColors.Control;
            this.bookingST.Location = new System.Drawing.Point(272, 110);
            this.bookingST.Name = "bookingST";
            this.bookingST.Size = new System.Drawing.Size(128, 19);
            this.bookingST.TabIndex = 11;
            this.bookingST.Text = "Booking status :";
            this.bookingST.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(538, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "in Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(528, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "out Date :";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(HotelReseption.Booking);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bookingcodeDataGridViewTextBoxColumn
            // 
            this.bookingcodeDataGridViewTextBoxColumn.DataPropertyName = "booking_code";
            this.bookingcodeDataGridViewTextBoxColumn.HeaderText = "booking_code";
            this.bookingcodeDataGridViewTextBoxColumn.Name = "bookingcodeDataGridViewTextBoxColumn";
            // 
            // checkindateDataGridViewTextBoxColumn
            // 
            this.checkindateDataGridViewTextBoxColumn.DataPropertyName = "check_in_date";
            this.checkindateDataGridViewTextBoxColumn.HeaderText = "check_in_date";
            this.checkindateDataGridViewTextBoxColumn.Name = "checkindateDataGridViewTextBoxColumn";
            // 
            // checkoutdateDataGridViewTextBoxColumn
            // 
            this.checkoutdateDataGridViewTextBoxColumn.DataPropertyName = "check_out_date";
            this.checkoutdateDataGridViewTextBoxColumn.HeaderText = "check_out_date";
            this.checkoutdateDataGridViewTextBoxColumn.Name = "checkoutdateDataGridViewTextBoxColumn";
            // 
            // adultcountDataGridViewTextBoxColumn
            // 
            this.adultcountDataGridViewTextBoxColumn.DataPropertyName = "adult_count";
            this.adultcountDataGridViewTextBoxColumn.HeaderText = "adult_count";
            this.adultcountDataGridViewTextBoxColumn.Name = "adultcountDataGridViewTextBoxColumn";
            // 
            // childcountDataGridViewTextBoxColumn
            // 
            this.childcountDataGridViewTextBoxColumn.DataPropertyName = "child_count";
            this.childcountDataGridViewTextBoxColumn.HeaderText = "child_count";
            this.childcountDataGridViewTextBoxColumn.Name = "childcountDataGridViewTextBoxColumn";
            // 
            // roomtypeidDataGridViewTextBoxColumn
            // 
            this.roomtypeidDataGridViewTextBoxColumn.DataPropertyName = "room_type_id";
            this.roomtypeidDataGridViewTextBoxColumn.HeaderText = "room_type_id";
            this.roomtypeidDataGridViewTextBoxColumn.Name = "roomtypeidDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // bookingstatusDataGridViewCheckBoxColumn
            // 
            this.bookingstatusDataGridViewCheckBoxColumn.DataPropertyName = "booking_status";
            this.bookingstatusDataGridViewCheckBoxColumn.HeaderText = "booking_status";
            this.bookingstatusDataGridViewCheckBoxColumn.Name = "bookingstatusDataGridViewCheckBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingST);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.cmbUserid);
            this.Controls.Add(this.cmbRoomTypeid);
            this.Controls.Add(this.checkoutDate);
            this.Controls.Add(this.checkinDate);
            this.Controls.Add(this.DataBooking);
            this.Controls.Add(this.bookingcode);
            this.Controls.Add(this.childcount);
            this.Controls.Add(this.adultcount);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adultcount;
        private System.Windows.Forms.DataGridView DataBooking;
        private System.Windows.Forms.DateTimePicker checkinDate;
        private System.Windows.Forms.DateTimePicker checkoutDate;
        private System.Windows.Forms.TextBox childcount;
        private System.Windows.Forms.TextBox bookingcode;
        private System.Windows.Forms.ComboBox cmbRoomTypeid;
        private System.Windows.Forms.ComboBox cmbUserid;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox bookingST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bookingstatusDataGridViewCheckBoxColumn;
    }
}