namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.lastnametextBox = new System.Windows.Forms.TextBox();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.firstnametextBox = new System.Windows.Forms.TextBox();
            this.adresstextBox = new System.Windows.Forms.TextBox();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addonebtn = new System.Windows.Forms.Button();
            this.addmorebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.taxbtn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.salarytax = new System.Windows.Forms.ColumnHeader();
            this.salary = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.email = new System.Windows.Forms.ColumnHeader();
            this.phone = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.label12 = new System.Windows.Forms.Label();
            this.sortbtn = new System.Windows.Forms.Button();
            this.selectedtaxbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(1029, 64);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 23);
            this.idtextBox.TabIndex = 0;
            this.idtextBox.TextChanged += new System.EventHandler(this.idtextBox_TextChanged);
            // 
            // lastnametextBox
            // 
            this.lastnametextBox.Location = new System.Drawing.Point(1029, 188);
            this.lastnametextBox.Name = "lastnametextBox";
            this.lastnametextBox.Size = new System.Drawing.Size(100, 23);
            this.lastnametextBox.TabIndex = 0;
            // 
            // phonetextBox
            // 
            this.phonetextBox.Location = new System.Drawing.Point(835, 123);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(100, 23);
            this.phonetextBox.TabIndex = 0;
            // 
            // firstnametextBox
            // 
            this.firstnametextBox.Location = new System.Drawing.Point(1029, 123);
            this.firstnametextBox.Name = "firstnametextBox";
            this.firstnametextBox.Size = new System.Drawing.Size(100, 23);
            this.firstnametextBox.TabIndex = 0;
            // 
            // adresstextBox
            // 
            this.adresstextBox.Location = new System.Drawing.Point(835, 64);
            this.adresstextBox.Name = "adresstextBox";
            this.adresstextBox.Size = new System.Drawing.Size(100, 23);
            this.adresstextBox.TabIndex = 0;
            this.adresstextBox.TextChanged += new System.EventHandler(this.adresstextBox5_TextChanged);
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(835, 185);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(100, 23);
            this.salarytextBox.TabIndex = 0;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(1029, 252);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(100, 23);
            this.emailtextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(946, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "כתובת";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1186, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ת\"ז";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(952, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "טלפון";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1158, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "שם פרטי";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(938, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "משכורת";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1135, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "שם המשפחה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1172, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "אימייל";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addonebtn
            // 
            this.addonebtn.Location = new System.Drawing.Point(835, 243);
            this.addonebtn.Name = "addonebtn";
            this.addonebtn.Size = new System.Drawing.Size(153, 32);
            this.addonebtn.TabIndex = 3;
            this.addonebtn.Text = "הוסף עובד";
            this.addonebtn.UseVisualStyleBackColor = true;
            this.addonebtn.Click += new System.EventHandler(this.addonebtn_Click);
            // 
            // addmorebtn
            // 
            this.addmorebtn.Location = new System.Drawing.Point(1058, 328);
            this.addmorebtn.Name = "addmorebtn";
            this.addmorebtn.Size = new System.Drawing.Size(153, 33);
            this.addmorebtn.TabIndex = 3;
            this.addmorebtn.Text = "הוספת 10,000 עובדים";
            this.addmorebtn.UseVisualStyleBackColor = true;
            this.addmorebtn.Click += new System.EventHandler(this.addmorebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(1121, 472);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(90, 37);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "יציאה";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // taxbtn
            // 
            this.taxbtn.Location = new System.Drawing.Point(858, 328);
            this.taxbtn.Name = "taxbtn";
            this.taxbtn.Size = new System.Drawing.Size(153, 32);
            this.taxbtn.TabIndex = 3;
            this.taxbtn.Text = "חישוב מס לכל העובדים";
            this.taxbtn.UseVisualStyleBackColor = true;
            this.taxbtn.Click += new System.EventHandler(this.taxbtn_Click);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.LightGray;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.salarytax,
            this.salary,
            this.address,
            this.email,
            this.phone,
            this.id,
            this.name});
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(24, 67);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(796, 435);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // salarytax
            // 
            this.salarytax.Text = "משכורת נטו";
            this.salarytax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salarytax.Width = 100;
            // 
            // salary
            // 
            this.salary.Text = "משכורת";
            this.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salary.Width = 100;
            // 
            // address
            // 
            this.address.Text = "כתובת";
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address.Width = 100;
            // 
            // email
            // 
            this.email.Text = "אימייל";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.Width = 165;
            // 
            // phone
            // 
            this.phone.Text = "טלפון";
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phone.Width = 100;
            // 
            // id
            // 
            this.id.Text = "ת\"ז";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 100;
            // 
            // name
            // 
            this.name.Text = "שם מלא";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 100;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(312, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "רשימת עובדים";
            // 
            // sortbtn
            // 
            this.sortbtn.Location = new System.Drawing.Point(1058, 385);
            this.sortbtn.Name = "sortbtn";
            this.sortbtn.Size = new System.Drawing.Size(153, 33);
            this.sortbtn.TabIndex = 3;
            this.sortbtn.Text = "מיון לפי משכורת";
            this.sortbtn.UseVisualStyleBackColor = true;
            this.sortbtn.Click += new System.EventHandler(this.sortbtn_Click);
            // 
            // selectedtaxbtn
            // 
            this.selectedtaxbtn.Location = new System.Drawing.Point(858, 385);
            this.selectedtaxbtn.Name = "selectedtaxbtn";
            this.selectedtaxbtn.Size = new System.Drawing.Size(153, 32);
            this.selectedtaxbtn.TabIndex = 5;
            this.selectedtaxbtn.Text = "חישוב מס לעובדים נבחרים";
            this.selectedtaxbtn.UseVisualStyleBackColor = true;
            this.selectedtaxbtn.Click += new System.EventHandler(this.selectedtaxbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1252, 560);
            this.Controls.Add(this.selectedtaxbtn);
            this.Controls.Add(this.sortbtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.taxbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.addmorebtn);
            this.Controls.Add(this.addonebtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.salarytextBox);
            this.Controls.Add(this.adresstextBox);
            this.Controls.Add(this.firstnametextBox);
            this.Controls.Add(this.phonetextBox);
            this.Controls.Add(this.lastnametextBox);
            this.Controls.Add(this.idtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox lastnametextBox;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.TextBox firstnametextBox;
        private System.Windows.Forms.TextBox adresstextBox;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addonebtn;
        private System.Windows.Forms.Button addmorebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button taxbtn;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button sortbtn;
        private System.Windows.Forms.ColumnHeader salary;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader salarytax;
        private System.Windows.Forms.Button selectedtaxbtn;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader phone;
    }
}

