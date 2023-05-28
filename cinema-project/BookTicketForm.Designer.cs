namespace cinema_project
{
    partial class BookTicketForm
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
            this.pbFilmRoom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSeats = new System.Windows.Forms.ComboBox();
            this.buttonBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFilmRoom
            // 
            this.pbFilmRoom.Location = new System.Drawing.Point(12, 12);
            this.pbFilmRoom.Name = "pbFilmRoom";
            this.pbFilmRoom.Size = new System.Drawing.Size(670, 502);
            this.pbFilmRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFilmRoom.TabIndex = 0;
            this.pbFilmRoom.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(724, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booking Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(709, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please choose seat:";
            // 
            // cbSeats
            // 
            this.cbSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSeats.FormattingEnabled = true;
            this.cbSeats.Location = new System.Drawing.Point(714, 122);
            this.cbSeats.Name = "cbSeats";
            this.cbSeats.Size = new System.Drawing.Size(121, 33);
            this.cbSeats.TabIndex = 3;
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBook.Location = new System.Drawing.Point(787, 480);
            this.buttonBook.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(123, 34);
            this.buttonBook.TabIndex = 22;
            this.buttonBook.Text = "book";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // BookTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(996, 526);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.cbSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFilmRoom);
            this.Name = "BookTicketForm";
            this.Text = "BookTicketForm";
            this.Load += new System.EventHandler(this.BookTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFilmRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSeats;
        private System.Windows.Forms.Button buttonBook;
    }
}