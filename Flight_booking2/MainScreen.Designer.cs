namespace Flight_booking2
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPassenger = new System.Windows.Forms.Button();
            this.addFlight = new System.Windows.Forms.Button();
            this.ticket_booking = new System.Windows.Forms.Button();
            this.viewPassenger = new System.Windows.Forms.Button();
            this.view_flight = new System.Windows.Forms.Button();
            this.cancel_ticket = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Booking System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.viewPassenger);
            this.panel1.Controls.Add(this.view_flight);
            this.panel1.Controls.Add(this.cancel_ticket);
            this.panel1.Controls.Add(this.addPassenger);
            this.panel1.Controls.Add(this.addFlight);
            this.panel1.Controls.Add(this.ticket_booking);
            this.panel1.Location = new System.Drawing.Point(12, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 264);
            this.panel1.TabIndex = 1;
            // 
            // addPassenger
            // 
            this.addPassenger.BackColor = System.Drawing.Color.Green;
            this.addPassenger.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPassenger.Location = new System.Drawing.Point(648, 28);
            this.addPassenger.Name = "addPassenger";
            this.addPassenger.Size = new System.Drawing.Size(237, 64);
            this.addPassenger.TabIndex = 7;
            this.addPassenger.Text = "Add Passenger";
            this.addPassenger.UseVisualStyleBackColor = false;
            this.addPassenger.Click += new System.EventHandler(this.addPassenger_Click);
            // 
            // addFlight
            // 
            this.addFlight.BackColor = System.Drawing.Color.DarkGray;
            this.addFlight.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFlight.Location = new System.Drawing.Point(329, 28);
            this.addFlight.Name = "addFlight";
            this.addFlight.Size = new System.Drawing.Size(276, 64);
            this.addFlight.TabIndex = 6;
            this.addFlight.Text = "Add flight";
            this.addFlight.UseVisualStyleBackColor = false;
            this.addFlight.Click += new System.EventHandler(this.addFlight_Click);
            // 
            // ticket_booking
            // 
            this.ticket_booking.BackColor = System.Drawing.Color.Firebrick;
            this.ticket_booking.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_booking.Location = new System.Drawing.Point(35, 28);
            this.ticket_booking.Name = "ticket_booking";
            this.ticket_booking.Size = new System.Drawing.Size(237, 64);
            this.ticket_booking.TabIndex = 5;
            this.ticket_booking.Text = "Ticket";
            this.ticket_booking.UseVisualStyleBackColor = false;
            this.ticket_booking.Click += new System.EventHandler(this.ticket_booking_Click);
            // 
            // viewPassenger
            // 
            this.viewPassenger.BackColor = System.Drawing.Color.LightGreen;
            this.viewPassenger.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPassenger.Location = new System.Drawing.Point(648, 126);
            this.viewPassenger.Name = "viewPassenger";
            this.viewPassenger.Size = new System.Drawing.Size(237, 64);
            this.viewPassenger.TabIndex = 10;
            this.viewPassenger.Text = "view passenger";
            this.viewPassenger.UseVisualStyleBackColor = false;
            this.viewPassenger.Click += new System.EventHandler(this.viewPassenger_Click);
            // 
            // view_flight
            // 
            this.view_flight.BackColor = System.Drawing.Color.Gainsboro;
            this.view_flight.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_flight.Location = new System.Drawing.Point(329, 126);
            this.view_flight.Name = "view_flight";
            this.view_flight.Size = new System.Drawing.Size(276, 64);
            this.view_flight.TabIndex = 9;
            this.view_flight.Text = "view flight";
            this.view_flight.UseVisualStyleBackColor = false;
            this.view_flight.Click += new System.EventHandler(this.button5_Click);
            // 
            // cancel_ticket
            // 
            this.cancel_ticket.BackColor = System.Drawing.Color.RosyBrown;
            this.cancel_ticket.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_ticket.Location = new System.Drawing.Point(35, 126);
            this.cancel_ticket.Name = "cancel_ticket";
            this.cancel_ticket.Size = new System.Drawing.Size(237, 64);
            this.cancel_ticket.TabIndex = 8;
            this.cancel_ticket.Text = "cancel ticket";
            this.cancel_ticket.UseVisualStyleBackColor = false;
            this.cancel_ticket.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(955, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewPassenger;
        private System.Windows.Forms.Button view_flight;
        private System.Windows.Forms.Button cancel_ticket;
        private System.Windows.Forms.Button addPassenger;
        private System.Windows.Forms.Button addFlight;
        private System.Windows.Forms.Button ticket_booking;
    }
}

