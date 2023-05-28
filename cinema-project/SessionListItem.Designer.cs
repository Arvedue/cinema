namespace cinema_project
{
    partial class SessionListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelNumberOfSeats = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelFilmRoom = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.movieBanner = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(252, 187);
            this.labelPrice.MaximumSize = new System.Drawing.Size(700, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(56, 25);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Price";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(252, 153);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(56, 25);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "Time";
            // 
            // labelNumberOfSeats
            // 
            this.labelNumberOfSeats.AutoSize = true;
            this.labelNumberOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfSeats.Location = new System.Drawing.Point(252, 119);
            this.labelNumberOfSeats.Name = "labelNumberOfSeats";
            this.labelNumberOfSeats.Size = new System.Drawing.Size(154, 25);
            this.labelNumberOfSeats.TabIndex = 11;
            this.labelNumberOfSeats.Text = "Number of seats";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(252, 84);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(139, 25);
            this.labelType.TabIndex = 10;
            this.labelType.Text = "Film room type";
            // 
            // labelFilmRoom
            // 
            this.labelFilmRoom.AutoSize = true;
            this.labelFilmRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilmRoom.Location = new System.Drawing.Point(252, 50);
            this.labelFilmRoom.Name = "labelFilmRoom";
            this.labelFilmRoom.Size = new System.Drawing.Size(97, 25);
            this.labelFilmRoom.TabIndex = 9;
            this.labelFilmRoom.Text = "Film room";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(251, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // movieBanner
            // 
            this.movieBanner.Location = new System.Drawing.Point(3, 3);
            this.movieBanner.Name = "movieBanner";
            this.movieBanner.Size = new System.Drawing.Size(223, 294);
            this.movieBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movieBanner.TabIndex = 7;
            this.movieBanner.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(3, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 1);
            this.panel1.TabIndex = 14;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(123, 302);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 34);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(3, 302);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(103, 34);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // SessionListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelNumberOfSeats);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelFilmRoom);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.movieBanner);
            this.Name = "SessionListItem";
            this.Size = new System.Drawing.Size(970, 346);
            this.Load += new System.EventHandler(this.SessionListItem_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SessionListItem_MouseClick);
            this.MouseEnter += new System.EventHandler(this.SessionListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SessionListItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.movieBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelNumberOfSeats;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelFilmRoom;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox movieBanner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
    }
}
