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
            this.RoomGrid = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomMaxGuests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumberOfGuests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.AddRoomNoInput = new System.Windows.Forms.TextBox();
            this.AddRoomAreaInput = new System.Windows.Forms.TextBox();
            this.AddRoomMaxGuestsInput = new System.Windows.Forms.TextBox();
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
            this.GuestGrid.Location = new System.Drawing.Point(60, 341);
            this.GuestGrid.Name = "GuestGrid";
            this.GuestGrid.RowTemplate.Height = 25;
            this.GuestGrid.Size = new System.Drawing.Size(247, 242);
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
            // RoomGrid
            // 
            this.RoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.RoomArea,
            this.RoomMaxGuests,
            this.RoomNumberOfGuests});
            this.RoomGrid.Location = new System.Drawing.Point(60, 151);
            this.RoomGrid.Name = "RoomGrid";
            this.RoomGrid.RowTemplate.Height = 25;
            this.RoomGrid.Size = new System.Drawing.Size(445, 150);
            this.RoomGrid.TabIndex = 2;
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
            // RoomMaxGuests
            // 
            this.RoomMaxGuests.HeaderText = "Max Guests";
            this.RoomMaxGuests.Name = "RoomMaxGuests";
            // 
            // RoomNumberOfGuests
            // 
            this.RoomNumberOfGuests.HeaderText = "NumberOfGuests";
            this.RoomNumberOfGuests.Name = "RoomNumberOfGuests";
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(430, 93);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 3;
            this.addRoomButton.Text = "Add Room";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // AddRoomNoInput
            // 
            this.AddRoomNoInput.Location = new System.Drawing.Point(110, 93);
            this.AddRoomNoInput.Name = "AddRoomNoInput";
            this.AddRoomNoInput.Size = new System.Drawing.Size(67, 23);
            this.AddRoomNoInput.TabIndex = 4;
            // 
            // AddRoomAreaInput
            // 
            this.AddRoomAreaInput.Location = new System.Drawing.Point(207, 93);
            this.AddRoomAreaInput.Name = "AddRoomAreaInput";
            this.AddRoomAreaInput.Size = new System.Drawing.Size(70, 23);
            this.AddRoomAreaInput.TabIndex = 5;
            // 
            // AddRoomMaxGuestsInput
            // 
            this.AddRoomMaxGuestsInput.Location = new System.Drawing.Point(311, 93);
            this.AddRoomMaxGuestsInput.Name = "AddRoomMaxGuestsInput";
            this.AddRoomMaxGuestsInput.Size = new System.Drawing.Size(74, 23);
            this.AddRoomMaxGuestsInput.TabIndex = 6;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 663);
            this.Controls.Add(this.AddRoomMaxGuestsInput);
            this.Controls.Add(this.AddRoomAreaInput);
            this.Controls.Add(this.AddRoomNoInput);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.RoomGrid);
            this.Controls.Add(this.GuestGrid);
            this.Name = "HotelForm";
            this.Text = "HOTEL DATABASE";
            ((System.ComponentModel.ISupportInitialize)(this.GuestGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GuestGrid;
        private DataGridViewTextBoxColumn GuestName;
        private DataGridViewTextBoxColumn GuestBalance;
        private DataGridView RoomGrid;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn RoomArea;
        private DataGridViewTextBoxColumn RoomMaxGuests;
        private DataGridViewTextBoxColumn RoomNumberOfGuests;
        private Button addRoomButton;
        private TextBox AddRoomNoInput;
        private TextBox AddRoomAreaInput;
        private TextBox AddRoomMaxGuestsInput;
    }
}