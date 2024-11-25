
namespace Airline_Reservation
{
    partial class Booking_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.proceedbtn = new System.Windows.Forms.Button();
            this.psprtnotxt = new System.Windows.Forms.TextBox();
            this.pasnametxt = new System.Windows.Forms.TextBox();
            this.pasagetxt = new System.Windows.Forms.TextBox();
            this.totprice = new System.Windows.Forms.TextBox();
            this.ttype = new System.Windows.Forms.ComboBox();
            this.malerad = new System.Windows.Forms.RadioButton();
            this.femalerad = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.bookidtxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passport Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passenger name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "TicketType";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Price";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(71)))), ((int)(((byte)(39)))));
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbtn.Location = new System.Drawing.Point(47, 282);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 30);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(71)))), ((int)(((byte)(39)))));
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitbtn.Location = new System.Drawing.Point(143, 282);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(90, 30);
            this.submitbtn.TabIndex = 7;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // proceedbtn
            // 
            this.proceedbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(71)))), ((int)(((byte)(39)))));
            this.proceedbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proceedbtn.Location = new System.Drawing.Point(241, 282);
            this.proceedbtn.Name = "proceedbtn";
            this.proceedbtn.Size = new System.Drawing.Size(90, 30);
            this.proceedbtn.TabIndex = 8;
            this.proceedbtn.Text = "Next";
            this.proceedbtn.UseVisualStyleBackColor = false;
            this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
            // 
            // psprtnotxt
            // 
            this.psprtnotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psprtnotxt.Location = new System.Drawing.Point(158, 62);
            this.psprtnotxt.Name = "psprtnotxt";
            this.psprtnotxt.Size = new System.Drawing.Size(173, 24);
            this.psprtnotxt.TabIndex = 9;
            // 
            // pasnametxt
            // 
            this.pasnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasnametxt.Location = new System.Drawing.Point(158, 107);
            this.pasnametxt.Name = "pasnametxt";
            this.pasnametxt.Size = new System.Drawing.Size(173, 24);
            this.pasnametxt.TabIndex = 10;
            // 
            // pasagetxt
            // 
            this.pasagetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasagetxt.Location = new System.Drawing.Point(158, 150);
            this.pasagetxt.Name = "pasagetxt";
            this.pasagetxt.Size = new System.Drawing.Size(100, 24);
            this.pasagetxt.TabIndex = 11;
            // 
            // totprice
            // 
            this.totprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totprice.Location = new System.Drawing.Point(158, 323);
            this.totprice.Name = "totprice";
            this.totprice.ReadOnly = true;
            this.totprice.Size = new System.Drawing.Size(173, 24);
            this.totprice.TabIndex = 13;
            // 
            // ttype
            // 
            this.ttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttype.FormattingEnabled = true;
            this.ttype.Items.AddRange(new object[] {
            "Economy Class",
            "Business Class",
            "First Class"});
            this.ttype.Location = new System.Drawing.Point(158, 231);
            this.ttype.Name = "ttype";
            this.ttype.Size = new System.Drawing.Size(173, 26);
            this.ttype.TabIndex = 14;
            this.ttype.Text = "Select a ticket type";
            // 
            // malerad
            // 
            this.malerad.AutoSize = true;
            this.malerad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.malerad.Checked = true;
            this.malerad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malerad.Location = new System.Drawing.Point(158, 194);
            this.malerad.Name = "malerad";
            this.malerad.Size = new System.Drawing.Size(58, 22);
            this.malerad.TabIndex = 15;
            this.malerad.TabStop = true;
            this.malerad.Text = "Male";
            this.malerad.UseVisualStyleBackColor = false;
            // 
            // femalerad
            // 
            this.femalerad.AutoSize = true;
            this.femalerad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.femalerad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalerad.Location = new System.Drawing.Point(241, 194);
            this.femalerad.Name = "femalerad";
            this.femalerad.Size = new System.Drawing.Size(75, 22);
            this.femalerad.TabIndex = 16;
            this.femalerad.Text = "Female";
            this.femalerad.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.bookidtxt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.totprice);
            this.panel1.Controls.Add(this.ttype);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.proceedbtn);
            this.panel1.Controls.Add(this.femalerad);
            this.panel1.Controls.Add(this.submitbtn);
            this.panel1.Controls.Add(this.psprtnotxt);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.malerad);
            this.panel1.Controls.Add(this.pasnametxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pasagetxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 354);
            this.panel1.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::Airline_Reservation.Properties.Resources.Screenshot_2024_07_25_115522;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 67);
            this.panel2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Booking ID";
            // 
            // bookidtxt
            // 
            this.bookidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidtxt.Location = new System.Drawing.Point(158, 17);
            this.bookidtxt.Name = "bookidtxt";
            this.bookidtxt.ReadOnly = true;
            this.bookidtxt.Size = new System.Drawing.Size(173, 24);
            this.bookidtxt.TabIndex = 18;
            // 
            // Booking_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Booking_Form";
            this.Text = "Booking_Form";
            this.Load += new System.EventHandler(this.Booking_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button proceedbtn;
        private System.Windows.Forms.TextBox psprtnotxt;
        private System.Windows.Forms.TextBox pasnametxt;
        private System.Windows.Forms.TextBox pasagetxt;
        private System.Windows.Forms.TextBox totprice;
        private System.Windows.Forms.ComboBox ttype;
        private System.Windows.Forms.RadioButton malerad;
        private System.Windows.Forms.RadioButton femalerad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox bookidtxt;
        private System.Windows.Forms.Label label7;
    }
}