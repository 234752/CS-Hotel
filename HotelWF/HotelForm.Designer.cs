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
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomMaxGuests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumberOfGuests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.addRoomNoInput = new System.Windows.Forms.TextBox();
            this.addRoomAreaInput = new System.Windows.Forms.TextBox();
            this.addRoomMaxGuestsInput = new System.Windows.Forms.TextBox();
            this.addGuestButton = new System.Windows.Forms.Button();
            this.addGuestNameInput = new System.Windows.Forms.TextBox();
            this.addGuestBalanceInput = new System.Windows.Forms.TextBox();
            this.displayGuestsButton = new System.Windows.Forms.Button();
            this.removeGuestButton = new System.Windows.Forms.Button();
            this.RegularRoomSwitch = new System.Windows.Forms.RadioButton();
            this.OfficeRoomSwitch = new System.Windows.Forms.RadioButton();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GuestGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestGrid
            // 
            this.GuestGrid.AllowUserToAddRows = false;
            this.GuestGrid.AllowUserToDeleteRows = false;
            this.GuestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestName,
            this.GuestBalance});
            this.GuestGrid.Location = new System.Drawing.Point(60, 398);
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
            this.RoomGrid.AllowUserToAddRows = false;
            this.RoomGrid.AllowUserToDeleteRows = false;
            this.RoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomType,
            this.RoomNumber,
            this.RoomArea,
            this.RoomMaxGuests,
            this.RoomNumberOfGuests,
            this.RoomFee});
            this.RoomGrid.Location = new System.Drawing.Point(60, 151);
            this.RoomGrid.Name = "RoomGrid";
            this.RoomGrid.RowTemplate.Height = 25;
            this.RoomGrid.Size = new System.Drawing.Size(655, 150);
            this.RoomGrid.TabIndex = 2;
            this.RoomGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGrid_CellClick);
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Type";
            this.RoomType.Name = "RoomType";
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
            this.RoomNumberOfGuests.HeaderText = "Guests";
            this.RoomNumberOfGuests.Name = "RoomNumberOfGuests";
            // 
            // RoomFee
            // 
            this.RoomFee.HeaderText = "Fee";
            this.RoomFee.Name = "RoomFee";
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
            // addRoomNoInput
            // 
            this.addRoomNoInput.Location = new System.Drawing.Point(110, 93);
            this.addRoomNoInput.Name = "addRoomNoInput";
            this.addRoomNoInput.Size = new System.Drawing.Size(67, 23);
            this.addRoomNoInput.TabIndex = 4;
            // 
            // addRoomAreaInput
            // 
            this.addRoomAreaInput.Location = new System.Drawing.Point(207, 93);
            this.addRoomAreaInput.Name = "addRoomAreaInput";
            this.addRoomAreaInput.Size = new System.Drawing.Size(70, 23);
            this.addRoomAreaInput.TabIndex = 5;
            // 
            // addRoomMaxGuestsInput
            // 
            this.addRoomMaxGuestsInput.Location = new System.Drawing.Point(311, 93);
            this.addRoomMaxGuestsInput.Name = "addRoomMaxGuestsInput";
            this.addRoomMaxGuestsInput.Size = new System.Drawing.Size(74, 23);
            this.addRoomMaxGuestsInput.TabIndex = 6;
            // 
            // addGuestButton
            // 
            this.addGuestButton.Location = new System.Drawing.Point(334, 362);
            this.addGuestButton.Name = "addGuestButton";
            this.addGuestButton.Size = new System.Drawing.Size(75, 23);
            this.addGuestButton.TabIndex = 7;
            this.addGuestButton.Text = "Add Guest";
            this.addGuestButton.UseVisualStyleBackColor = true;
            this.addGuestButton.Click += new System.EventHandler(this.addGuestButton_Click);
            // 
            // addGuestNameInput
            // 
            this.addGuestNameInput.Location = new System.Drawing.Point(105, 362);
            this.addGuestNameInput.Name = "addGuestNameInput";
            this.addGuestNameInput.Size = new System.Drawing.Size(72, 23);
            this.addGuestNameInput.TabIndex = 8;
            // 
            // addGuestBalanceInput
            // 
            this.addGuestBalanceInput.Location = new System.Drawing.Point(207, 362);
            this.addGuestBalanceInput.Name = "addGuestBalanceInput";
            this.addGuestBalanceInput.Size = new System.Drawing.Size(70, 23);
            this.addGuestBalanceInput.TabIndex = 9;
            // 
            // displayGuestsButton
            // 
            this.displayGuestsButton.Location = new System.Drawing.Point(781, 209);
            this.displayGuestsButton.Name = "displayGuestsButton";
            this.displayGuestsButton.Size = new System.Drawing.Size(75, 47);
            this.displayGuestsButton.TabIndex = 10;
            this.displayGuestsButton.Text = "Display Guests";
            this.displayGuestsButton.UseVisualStyleBackColor = true;
            this.displayGuestsButton.Click += new System.EventHandler(this.displayGuestsButton_Click);
            // 
            // removeGuestButton
            // 
            this.removeGuestButton.Location = new System.Drawing.Point(366, 472);
            this.removeGuestButton.Name = "removeGuestButton";
            this.removeGuestButton.Size = new System.Drawing.Size(75, 46);
            this.removeGuestButton.TabIndex = 11;
            this.removeGuestButton.Text = "Remove Guest";
            this.removeGuestButton.UseVisualStyleBackColor = true;
            this.removeGuestButton.Click += new System.EventHandler(this.removeGuestButton_Click);
            // 
            // RegularRoomSwitch
            // 
            this.RegularRoomSwitch.AutoSize = true;
            this.RegularRoomSwitch.Location = new System.Drawing.Point(548, 76);
            this.RegularRoomSwitch.Name = "RegularRoomSwitch";
            this.RegularRoomSwitch.Size = new System.Drawing.Size(100, 19);
            this.RegularRoomSwitch.TabIndex = 12;
            this.RegularRoomSwitch.TabStop = true;
            this.RegularRoomSwitch.Text = "Regular Room";
            this.RegularRoomSwitch.UseVisualStyleBackColor = true;
            // 
            // OfficeRoomSwitch
            // 
            this.OfficeRoomSwitch.AutoSize = true;
            this.OfficeRoomSwitch.Location = new System.Drawing.Point(548, 113);
            this.OfficeRoomSwitch.Name = "OfficeRoomSwitch";
            this.OfficeRoomSwitch.Size = new System.Drawing.Size(92, 19);
            this.OfficeRoomSwitch.TabIndex = 13;
            this.OfficeRoomSwitch.TabStop = true;
            this.OfficeRoomSwitch.Text = "Office Room";
            this.OfficeRoomSwitch.UseVisualStyleBackColor = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(307, 21);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.ErrorLabel.TabIndex = 14;
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(781, 151);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 52);
            this.deleteRoomButton.TabIndex = 15;
            this.deleteRoomButton.Text = "Delete Room";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 663);
            this.Controls.Add(this.deleteRoomButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.OfficeRoomSwitch);
            this.Controls.Add(this.RegularRoomSwitch);
            this.Controls.Add(this.removeGuestButton);
            this.Controls.Add(this.displayGuestsButton);
            this.Controls.Add(this.addGuestBalanceInput);
            this.Controls.Add(this.addGuestNameInput);
            this.Controls.Add(this.addGuestButton);
            this.Controls.Add(this.addRoomMaxGuestsInput);
            this.Controls.Add(this.addRoomAreaInput);
            this.Controls.Add(this.addRoomNoInput);
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
        private Button addRoomButton;
        private TextBox addRoomNoInput;
        private TextBox addRoomAreaInput;
        private TextBox addRoomMaxGuestsInput;
        private Button addGuestButton;
        private TextBox addGuestNameInput;
        private TextBox addGuestBalanceInput;
        private Button displayGuestsButton;
        private Button removeGuestButton;
        private RadioButton RegularRoomSwitch;
        private RadioButton OfficeRoomSwitch;
        private Label ErrorLabel;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn RoomArea;
        private DataGridViewTextBoxColumn RoomMaxGuests;
        private DataGridViewTextBoxColumn RoomNumberOfGuests;
        private DataGridViewTextBoxColumn RoomFee;
        private Button deleteRoomButton;
    }
}