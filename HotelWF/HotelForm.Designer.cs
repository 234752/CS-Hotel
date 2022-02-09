namespace HotelWF
{
    partial class HotelForm
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
            this.GuestGrid = new System.Windows.Forms.DataGridView();
            this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.RoomGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GuestGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestGrid
            // 
            this.GuestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestName,
            this.GuestBalance});
            this.GuestGrid.Location = new System.Drawing.Point(115, 136);
            this.GuestGrid.Name = "GuestGrid";
            this.GuestGrid.RowTemplate.Height = 25;
            this.GuestGrid.Size = new System.Drawing.Size(280, 242);
            this.GuestGrid.TabIndex = 0;
            // 
            // GuestName
            // 
            this.GuestName.HeaderText = "Name";
            this.GuestName.Name = "GuestName";
            // 
            // GuestBalance
            // 
            this.GuestBalance.HeaderText = "Balance";
            this.GuestBalance.Name = "GuestBalance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoomGrid
            // 
            this.RoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.RoomArea});
            this.RoomGrid.Location = new System.Drawing.Point(748, 312);
            this.RoomGrid.Name = "RoomGrid";
            this.RoomGrid.RowTemplate.Height = 25;
            this.RoomGrid.Size = new System.Drawing.Size(260, 150);
            this.RoomGrid.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1055, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "No";
            this.RoomNumber.Name = "RoomNumber";
            // 
            // RoomArea
            // 
            this.RoomArea.HeaderText = "Area";
            this.RoomArea.Name = "RoomArea";
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 663);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RoomGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GuestGrid);
            this.Name = "HotelForm";
            this.Text = "HOTEL DATABASE";
            ((System.ComponentModel.ISupportInitialize)(this.GuestGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GuestGrid;
        private DataGridViewTextBoxColumn GuestName;
        private DataGridViewTextBoxColumn GuestBalance;
        private Button button1;
        private DataGridView RoomGrid;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn RoomArea;
        private Button button2;
    }
}