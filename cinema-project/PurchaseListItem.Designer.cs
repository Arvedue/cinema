namespace cinema_project
{
    partial class PurchaseListItem
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
            this.labelPurchaseId = new System.Windows.Forms.Label();
            this.labelSessionId = new System.Windows.Forms.Label();
            this.labelMovie = new System.Windows.Forms.Label();
            this.labelFilmRoomId = new System.Windows.Forms.Label();
            this.labelFilmRoomType = new System.Windows.Forms.Label();
            this.labelSessionTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelPurchaseId
            // 
            this.labelPurchaseId.AutoSize = true;
            this.labelPurchaseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPurchaseId.Location = new System.Drawing.Point(13, 13);
            this.labelPurchaseId.Name = "labelPurchaseId";
            this.labelPurchaseId.Size = new System.Drawing.Size(103, 25);
            this.labelPurchaseId.TabIndex = 9;
            this.labelPurchaseId.Text = "Purchase";
            // 
            // labelSessionId
            // 
            this.labelSessionId.AutoSize = true;
            this.labelSessionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSessionId.Location = new System.Drawing.Point(13, 48);
            this.labelSessionId.Name = "labelSessionId";
            this.labelSessionId.Size = new System.Drawing.Size(103, 25);
            this.labelSessionId.TabIndex = 10;
            this.labelSessionId.Text = "Session id";
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMovie.Location = new System.Drawing.Point(13, 83);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(129, 25);
            this.labelMovie.TabIndex = 11;
            this.labelMovie.Text = "Movie name";
            // 
            // labelFilmRoomId
            // 
            this.labelFilmRoomId.AutoSize = true;
            this.labelFilmRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilmRoomId.Location = new System.Drawing.Point(13, 121);
            this.labelFilmRoomId.Name = "labelFilmRoomId";
            this.labelFilmRoomId.Size = new System.Drawing.Size(97, 25);
            this.labelFilmRoomId.TabIndex = 12;
            this.labelFilmRoomId.Text = "Film room";
            // 
            // labelFilmRoomType
            // 
            this.labelFilmRoomType.AutoSize = true;
            this.labelFilmRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilmRoomType.Location = new System.Drawing.Point(267, 121);
            this.labelFilmRoomType.Name = "labelFilmRoomType";
            this.labelFilmRoomType.Size = new System.Drawing.Size(139, 25);
            this.labelFilmRoomType.TabIndex = 13;
            this.labelFilmRoomType.Text = "Film room type";
            // 
            // labelSessionTime
            // 
            this.labelSessionTime.AutoSize = true;
            this.labelSessionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSessionTime.Location = new System.Drawing.Point(267, 48);
            this.labelSessionTime.Name = "labelSessionTime";
            this.labelSessionTime.Size = new System.Drawing.Size(124, 25);
            this.labelSessionTime.TabIndex = 14;
            this.labelSessionTime.Text = "Session time";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(267, 13);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 25);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Date";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(13, 161);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(56, 25);
            this.labelPrice.TabIndex = 16;
            this.labelPrice.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(3, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 1);
            this.panel1.TabIndex = 17;
            // 
            // PurchaseListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSessionTime);
            this.Controls.Add(this.labelFilmRoomType);
            this.Controls.Add(this.labelFilmRoomId);
            this.Controls.Add(this.labelMovie);
            this.Controls.Add(this.labelSessionId);
            this.Controls.Add(this.labelPurchaseId);
            this.Name = "PurchaseListItem";
            this.Size = new System.Drawing.Size(640, 203);
            this.Load += new System.EventHandler(this.PurchaseListItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPurchaseId;
        private System.Windows.Forms.Label labelSessionId;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.Label labelFilmRoomId;
        private System.Windows.Forms.Label labelFilmRoomType;
        private System.Windows.Forms.Label labelSessionTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panel1;
    }
}
