namespace InstituteMS
{
    partial class Course
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.teaIdSelectlbl = new System.Windows.Forms.TextBox();
            this.labe = new System.Windows.Forms.Label();
            this.clsEndTimecmb = new System.Windows.Forms.ComboBox();
            this.clsStartTimecmb = new System.Windows.Forms.ComboBox();
            this.clsLastId = new System.Windows.Forms.Label();
            this.couTeaDetails = new System.Windows.Forms.DataGridView();
            this.clsDaycmb = new System.Windows.Forms.ComboBox();
            this.clsIDtxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clsFeetxt = new System.Windows.Forms.TextBox();
            this.clsBatchtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clsGridView = new System.Windows.Forms.DataGridView();
            this.clsAllRbn = new System.Windows.Forms.RadioButton();
            this.days = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.couTeaDetails)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.tabControl1.Location = new System.Drawing.Point(9, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 503);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.teaIdSelectlbl);
            this.tabPage1.Controls.Add(this.labe);
            this.tabPage1.Controls.Add(this.clsEndTimecmb);
            this.tabPage1.Controls.Add(this.clsStartTimecmb);
            this.tabPage1.Controls.Add(this.clsLastId);
            this.tabPage1.Controls.Add(this.couTeaDetails);
            this.tabPage1.Controls.Add(this.clsDaycmb);
            this.tabPage1.Controls.Add(this.clsIDtxt);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.clsFeetxt);
            this.tabPage1.Controls.Add(this.clsBatchtxt);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // teaIdSelectlbl
            // 
            this.teaIdSelectlbl.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.teaIdSelectlbl.Location = new System.Drawing.Point(167, 64);
            this.teaIdSelectlbl.Name = "teaIdSelectlbl";
            this.teaIdSelectlbl.ReadOnly = true;
            this.teaIdSelectlbl.Size = new System.Drawing.Size(75, 26);
            this.teaIdSelectlbl.TabIndex = 52;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labe.ForeColor = System.Drawing.Color.White;
            this.labe.Location = new System.Drawing.Point(24, 67);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(95, 23);
            this.labe.TabIndex = 51;
            this.labe.Text = "Teacher ID";
            // 
            // clsEndTimecmb
            // 
            this.clsEndTimecmb.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.clsEndTimecmb.FormattingEnabled = true;
            this.clsEndTimecmb.Location = new System.Drawing.Point(167, 213);
            this.clsEndTimecmb.Name = "clsEndTimecmb";
            this.clsEndTimecmb.Size = new System.Drawing.Size(196, 26);
            this.clsEndTimecmb.TabIndex = 50;
            // 
            // clsStartTimecmb
            // 
            this.clsStartTimecmb.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.clsStartTimecmb.FormattingEnabled = true;
            this.clsStartTimecmb.Location = new System.Drawing.Point(167, 176);
            this.clsStartTimecmb.Name = "clsStartTimecmb";
            this.clsStartTimecmb.Size = new System.Drawing.Size(196, 26);
            this.clsStartTimecmb.TabIndex = 49;
            // 
            // clsLastId
            // 
            this.clsLastId.AutoSize = true;
            this.clsLastId.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.clsLastId.ForeColor = System.Drawing.Color.White;
            this.clsLastId.Location = new System.Drawing.Point(257, 23);
            this.clsLastId.Name = "clsLastId";
            this.clsLastId.Size = new System.Drawing.Size(31, 23);
            this.clsLastId.TabIndex = 48;
            this.clsLastId.Text = "ID";
            // 
            // couTeaDetails
            // 
            this.couTeaDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couTeaDetails.Location = new System.Drawing.Point(458, 23);
            this.couTeaDetails.Name = "couTeaDetails";
            this.couTeaDetails.Size = new System.Drawing.Size(365, 280);
            this.couTeaDetails.TabIndex = 47;
            this.couTeaDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.couTeaDetails_CellClick);
            this.couTeaDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.couTeaDetails_CellContentClick);
            // 
            // clsDaycmb
            // 
            this.clsDaycmb.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.clsDaycmb.FormattingEnabled = true;
            this.clsDaycmb.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.clsDaycmb.Location = new System.Drawing.Point(167, 139);
            this.clsDaycmb.Name = "clsDaycmb";
            this.clsDaycmb.Size = new System.Drawing.Size(196, 26);
            this.clsDaycmb.TabIndex = 46;
            // 
            // clsIDtxt
            // 
            this.clsIDtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.clsIDtxt.Location = new System.Drawing.Point(167, 23);
            this.clsIDtxt.Name = "clsIDtxt";
            this.clsIDtxt.Size = new System.Drawing.Size(75, 26);
            this.clsIDtxt.TabIndex = 44;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(395, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 40);
            this.button3.TabIndex = 43;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(252, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 40);
            this.button2.TabIndex = 42;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(113, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 41;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clsFeetxt
            // 
            this.clsFeetxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.clsFeetxt.Location = new System.Drawing.Point(167, 251);
            this.clsFeetxt.Name = "clsFeetxt";
            this.clsFeetxt.Size = new System.Drawing.Size(196, 26);
            this.clsFeetxt.TabIndex = 40;
            // 
            // clsBatchtxt
            // 
            this.clsBatchtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.clsBatchtxt.Location = new System.Drawing.Point(167, 103);
            this.clsBatchtxt.Name = "clsBatchtxt";
            this.clsBatchtxt.Size = new System.Drawing.Size(196, 26);
            this.clsBatchtxt.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Batch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Start Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Course ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.clsGridView);
            this.tabPage2.Controls.Add(this.clsAllRbn);
            this.tabPage2.Controls.Add(this.days);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Report";
            // 
            // clsGridView
            // 
            this.clsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clsGridView.Location = new System.Drawing.Point(8, 131);
            this.clsGridView.Name = "clsGridView";
            this.clsGridView.Size = new System.Drawing.Size(774, 304);
            this.clsGridView.TabIndex = 12;
            // 
            // clsAllRbn
            // 
            this.clsAllRbn.AutoSize = true;
            this.clsAllRbn.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.clsAllRbn.ForeColor = System.Drawing.Color.White;
            this.clsAllRbn.Location = new System.Drawing.Point(51, 22);
            this.clsAllRbn.Name = "clsAllRbn";
            this.clsAllRbn.Size = new System.Drawing.Size(50, 27);
            this.clsAllRbn.TabIndex = 10;
            this.clsAllRbn.TabStop = true;
            this.clsAllRbn.Text = "All";
            this.clsAllRbn.UseVisualStyleBackColor = true;
            this.clsAllRbn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // days
            // 
            this.days.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.days.FormattingEnabled = true;
            this.days.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.days.Location = new System.Drawing.Point(516, 25);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(121, 26);
            this.days.TabIndex = 9;
            this.days.SelectedIndexChanged += new System.EventHandler(this.days_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(471, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Day";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(278, 25);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 26);
            this.comboBox4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(204, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Subject";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 76);
            this.panel1.TabIndex = 2;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(798, 18);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 41);
            this.button10.TabIndex = 29;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(744, 18);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 41);
            this.button9.TabIndex = 28;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(690, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 41);
            this.button8.TabIndex = 27;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(632, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 41);
            this.button7.TabIndex = 26;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Moire", 30F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 48);
            this.label10.TabIndex = 23;
            this.label10.Text = "Course";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(312, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 26);
            this.button4.TabIndex = 53;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(858, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.couTeaDetails)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox clsDaycmb;
        private System.Windows.Forms.TextBox clsIDtxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox clsFeetxt;
        private System.Windows.Forms.TextBox clsBatchtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton clsAllRbn;
        private System.Windows.Forms.ComboBox days;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView clsGridView;
        private System.Windows.Forms.DataGridView couTeaDetails;
        private System.Windows.Forms.Label clsLastId;
        private System.Windows.Forms.ComboBox clsEndTimecmb;
        private System.Windows.Forms.ComboBox clsStartTimecmb;
        private System.Windows.Forms.TextBox teaIdSelectlbl;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Button button4;

    }
}