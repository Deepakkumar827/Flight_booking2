using System.Data.SqlClient;




namespace Flight_booking2
{
    /// <summary>
    /// /dsgrdsgrt
    /// </summary>
    partial class AddPassenger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        
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
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.nationality = new System.Windows.Forms.ComboBox();
            this.text3 = new System.Windows.Forms.Label();
            this.no_of_seat = new System.Windows.Forms.Label();
            this.flightCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.number = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.passID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gender";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Green;
            this.add.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(585, 567);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(182, 64);
            this.add.TabIndex = 16;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DarkGray;
            this.reset.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(339, 567);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(182, 64);
            this.reset.TabIndex = 15;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Firebrick;
            this.exit.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(100, 567);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(182, 64);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // nationality
            // 
            this.nationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationality.FormattingEnabled = true;
            this.nationality.Items.AddRange(new object[] {
            "INDIAN",
            "USA",
            "CHINESE",
            "SRILANKA",
            "PAKISTAN",
            "CANADA",
            "UAE",
            "JAPAN"});
            this.nationality.Location = new System.Drawing.Point(335, 397);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(299, 37);
            this.nationality.TabIndex = 12;
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.Location = new System.Drawing.Point(94, 324);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(118, 32);
            this.text3.TabIndex = 9;
            this.text3.Text = "Address";
            // 
            // no_of_seat
            // 
            this.no_of_seat.AutoSize = true;
            this.no_of_seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_seat.Location = new System.Drawing.Point(94, 397);
            this.no_of_seat.Name = "no_of_seat";
            this.no_of_seat.Size = new System.Drawing.Size(149, 32);
            this.no_of_seat.TabIndex = 8;
            this.no_of_seat.Text = "Nationality";
            // 
            // flightCode
            // 
            this.flightCode.AutoSize = true;
            this.flightCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightCode.Location = new System.Drawing.Point(94, 176);
            this.flightCode.Name = "flightCode";
            this.flightCode.Size = new System.Drawing.Size(232, 32);
            this.flightCode.TabIndex = 7;
            this.flightCode.Text = "Passenger Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add passenger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.number);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.passID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.nationality);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.text3);
            this.panel1.Controls.Add(this.no_of_seat);
            this.panel1.Controls.Add(this.flightCode);
            this.panel1.Controls.Add(this.From);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 678);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(335, 245);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(299, 38);
            this.number.TabIndex = 23;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(339, 321);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(299, 38);
            this.address.TabIndex = 22;
            // 
            // passID
            // 
            this.passID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passID.Location = new System.Drawing.Point(335, 89);
            this.passID.Name = "passID";
            this.passID.Size = new System.Drawing.Size(299, 38);
            this.passID.TabIndex = 21;
            this.passID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Passenger ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "FEMALE",
            "MALE"});
            this.gender.Location = new System.Drawing.Point(335, 467);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(299, 37);
            this.gender.TabIndex = 13;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(335, 173);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(299, 38);
            this.name.TabIndex = 11;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(94, 245);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(204, 32);
            this.From.TabIndex = 6;
            this.From.Text = "Phone Number";
            // 
            // AddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 763);
            this.Controls.Add(this.panel1);
            this.Name = "AddPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPassenger";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox nationality;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label no_of_seat;
        private System.Windows.Forms.Label flightCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox address;
    }
}