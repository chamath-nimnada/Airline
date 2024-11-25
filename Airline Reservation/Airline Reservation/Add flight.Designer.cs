
namespace Airline_Reservation
{
    partial class Add_flight
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Arrtime = new System.Windows.Forms.DateTimePicker();
            this.deptime = new System.Windows.Forms.DateTimePicker();
            this.submitbtn = new System.Windows.Forms.Button();
            this.arrivalcmb = new System.Windows.Forms.ComboBox();
            this.depcmb = new System.Windows.Forms.ComboBox();
            this.datetxt = new System.Windows.Forms.DateTimePicker();
            this.fnotxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.logoutbtn);
            this.groupBox1.Controls.Add(this.profilebtn);
            this.groupBox1.Controls.Add(this.viewbtn);
            this.groupBox1.Controls.Add(this.searchbtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Access";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(71)))), ((int)(((byte)(39)))));
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(16, 41);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(159, 41);
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "Dashboard";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(71)))), ((int)(((byte)(39)))));
            this.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutbtn.Location = new System.Drawing.Point(16, 291);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(159, 41);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(71)))), ((int)(((byte)(39)))));
            this.profilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.profilebtn.Location = new System.Drawing.Point(16, 163);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(159, 41);
            this.profilebtn.TabIndex = 2;
            this.profilebtn.Text = "My Profile";
            this.profilebtn.UseVisualStyleBackColor = false;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(71)))), ((int)(((byte)(39)))));
            this.viewbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.viewbtn.Location = new System.Drawing.Point(16, 226);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(159, 41);
            this.viewbtn.TabIndex = 1;
            this.viewbtn.Text = "View Booking";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(71)))), ((int)(((byte)(39)))));
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(16, 103);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(159, 41);
            this.searchbtn.TabIndex = 0;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.groupBox2.Controls.Add(this.Arrtime);
            this.groupBox2.Controls.Add(this.deptime);
            this.groupBox2.Controls.Add(this.submitbtn);
            this.groupBox2.Controls.Add(this.arrivalcmb);
            this.groupBox2.Controls.Add(this.depcmb);
            this.groupBox2.Controls.Add(this.datetxt);
            this.groupBox2.Controls.Add(this.fnotxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(257, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 366);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Flight";
            // 
            // Arrtime
            // 
            this.Arrtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Arrtime.Location = new System.Drawing.Point(173, 263);
            this.Arrtime.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.Arrtime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Arrtime.Name = "Arrtime";
            this.Arrtime.Size = new System.Drawing.Size(115, 22);
            this.Arrtime.TabIndex = 14;
            this.Arrtime.Value = new System.DateTime(2024, 7, 27, 1, 7, 50, 0);
            // 
            // deptime
            // 
            this.deptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.deptime.Location = new System.Drawing.Point(173, 171);
            this.deptime.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.deptime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.deptime.Name = "deptime";
            this.deptime.Size = new System.Drawing.Size(115, 22);
            this.deptime.TabIndex = 13;
            this.deptime.Value = new System.DateTime(2024, 7, 27, 1, 7, 34, 0);
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(71)))), ((int)(((byte)(39)))));
            this.submitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitbtn.Location = new System.Drawing.Point(282, 301);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(91, 31);
            this.submitbtn.TabIndex = 12;
            this.submitbtn.Text = "Add";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // arrivalcmb
            // 
            this.arrivalcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalcmb.FormattingEnabled = true;
            this.arrivalcmb.Items.AddRange(new object[] {
            "Amsterdam",
            "London",
            "Paris",
            "Bangkok",
            "Delhi",
            "Singapore",
            "Dubai",
            "Jeddah",
            "Riyadh",
            ""});
            this.arrivalcmb.Location = new System.Drawing.Point(173, 218);
            this.arrivalcmb.Name = "arrivalcmb";
            this.arrivalcmb.Size = new System.Drawing.Size(200, 24);
            this.arrivalcmb.TabIndex = 11;
            // 
            // depcmb
            // 
            this.depcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depcmb.FormattingEnabled = true;
            this.depcmb.Items.AddRange(new object[] {
            "Colombo",
            "Mattala"});
            this.depcmb.Location = new System.Drawing.Point(173, 125);
            this.depcmb.Name = "depcmb";
            this.depcmb.Size = new System.Drawing.Size(200, 24);
            this.depcmb.TabIndex = 8;
            // 
            // datetxt
            // 
            this.datetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetxt.Location = new System.Drawing.Point(173, 87);
            this.datetxt.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.datetxt.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(200, 22);
            this.datetxt.TabIndex = 7;
            this.datetxt.Value = new System.DateTime(2024, 7, 27, 0, 0, 0, 0);
            // 
            // fnotxt
            // 
            this.fnotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnotxt.Location = new System.Drawing.Point(173, 49);
            this.fnotxt.Name = "fnotxt";
            this.fnotxt.Size = new System.Drawing.Size(200, 22);
            this.fnotxt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Arrival Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arrival Airport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departure Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Airport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Number";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = global::Airline_Reservation.Properties.Resources.Screenshot_2024_07_25_115522;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 95);
            this.panel1.TabIndex = 3;
            // 
            // Add_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_flight";
            this.Text = "Add_flight";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.ComboBox arrivalcmb;
        private System.Windows.Forms.ComboBox depcmb;
        private System.Windows.Forms.DateTimePicker datetxt;
        private System.Windows.Forms.TextBox fnotxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker Arrtime;
        private System.Windows.Forms.DateTimePicker deptime;
        private System.Windows.Forms.Panel panel1;
    }
}