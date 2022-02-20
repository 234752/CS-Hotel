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
            this.revenueLabel = new System.Windows.Forms.Label();
            this.costsLabel = new System.Windows.Forms.Label();
            this.countRevenueButton = new System.Windows.Forms.Button();
            this.countCostsButton = new System.Windows.Forms.Button();
            this.PoolCheckbox = new System.Windows.Forms.CheckBox();
            this.ParkingLotCheckbox = new System.Windows.Forms.CheckBox();
            this.UParkingLotCheckbox = new System.Windows.Forms.CheckBox();
            this.AccessPanel = new System.Windows.Forms.Panel();
            this.displayAccessButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GuestGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).BeginInit();
            this.AccessPanel.SuspendLayout();
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
            this.GuestGrid.Location = new System.Drawing.Point(60, 327);
            this.GuestGrid.Name = "GuestGrid";
            this.GuestGrid.RowTemplate.Height = 25;
            this.GuestGrid.Size = new System.Drawing.Size(247, 242);
            this.GuestGrid.TabIndex = 0;
            this.GuestGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GuestGrid_CellClick);
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
            this.RoomGrid.Location = new System.Drawing.Point(60, 56);
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
            this.addRoomButton.Location = new System.Drawing.Point(640, 222);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 3;
            this.addRoomButton.Text = "Add Room";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // addRoomNoInput
            // 
            this.addRoomNoInput.Location = new System.Drawing.Point(227, 222);
            this.addRoomNoInput.Name = "addRoomNoInput";
            this.addRoomNoInput.Size = new System.Drawing.Size(67, 23);
            this.addRoomNoInput.TabIndex = 4;
            // 
            // addRoomAreaInput
            // 
            this.addRoomAreaInput.Location = new System.Drawing.Point(321, 222);
            this.addRoomAreaInput.Name = "addRoomAreaInput";
            this.addRoomAreaInput.Size = new System.Drawing.Size(70, 23);
            this.addRoomAreaInput.TabIndex = 5;
            // 
            // addRoomMaxGuestsInput
            // 
            this.addRoomMaxGuestsInput.Location = new System.Drawing.Point(411, 222);
            this.addRoomMaxGuestsInput.Name = "addRoomMaxGuestsInput";
            this.addRoomMaxGuestsInput.Size = new System.Drawing.Size(74, 23);
            this.addRoomMaxGuestsInput.TabIndex = 6;
            // 
            // addGuestButton
            // 
            this.addGuestButton.Location = new System.Drawing.Point(335, 588);
            this.addGuestButton.Name = "addGuestButton";
            this.addGuestButton.Size = new System.Drawing.Size(75, 23);
            this.addGuestButton.TabIndex = 7;
            this.addGuestButton.Text = "Add Guest";
            this.addGuestButton.UseVisualStyleBackColor = true;
            this.addGuestButton.Click += new System.EventHandler(this.addGuestButton_Click);
            // 
            // addGuestNameInput
            // 
            this.addGuestNameInput.Location = new System.Drawing.Point(134, 589);
            this.addGuestNameInput.Name = "addGuestNameInput";
            this.addGuestNameInput.Size = new System.Drawing.Size(72, 23);
            this.addGuestNameInput.TabIndex = 8;
            // 
            // addGuestBalanceInput
            // 
            this.addGuestBalanceInput.Location = new System.Drawing.Point(227, 589);
            this.addGuestBalanceInput.Name = "addGuestBalanceInput";
            this.addGuestBalanceInput.Size = new System.Drawing.Size(70, 23);
            this.addGuestBalanceInput.TabIndex = 9;
            // 
            // displayGuestsButton
            // 
            this.displayGuestsButton.Location = new System.Drawing.Point(745, 159);
            this.displayGuestsButton.Name = "displayGuestsButton";
            this.displayGuestsButton.Size = new System.Drawing.Size(75, 47);
            this.displayGuestsButton.TabIndex = 10;
            this.displayGuestsButton.Text = "Display Guests";
            this.displayGuestsButton.UseVisualStyleBackColor = true;
            this.displayGuestsButton.Click += new System.EventHandler(this.displayGuestsButton_Click);
            // 
            // removeGuestButton
            // 
            this.removeGuestButton.Location = new System.Drawing.Point(335, 523);
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
            this.RegularRoomSwitch.Location = new System.Drawing.Point(520, 212);
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
            this.OfficeRoomSwitch.Location = new System.Drawing.Point(520, 237);
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
            this.deleteRoomButton.Location = new System.Drawing.Point(745, 91);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 52);
            this.deleteRoomButton.TabIndex = 15;
            this.deleteRoomButton.Text = "Delete Room";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.deleteRoomButton_Click);
            // 
            // revenueLabel
            // 
            this.revenueLabel.AutoSize = true;
            this.revenueLabel.Location = new System.Drawing.Point(1084, 60);
            this.revenueLabel.Name = "revenueLabel";
            this.revenueLabel.Size = new System.Drawing.Size(38, 15);
            this.revenueLabel.TabIndex = 16;
            this.revenueLabel.Text = "label1";
            // 
            // costsLabel
            // 
            this.costsLabel.AutoSize = true;
            this.costsLabel.Location = new System.Drawing.Point(1084, 95);
            this.costsLabel.Name = "costsLabel";
            this.costsLabel.Size = new System.Drawing.Size(38, 15);
            this.costsLabel.TabIndex = 17;
            this.costsLabel.Text = "label1";
            // 
            // countRevenueButton
            // 
            this.countRevenueButton.Location = new System.Drawing.Point(984, 56);
            this.countRevenueButton.Name = "countRevenueButton";
            this.countRevenueButton.Size = new System.Drawing.Size(75, 23);
            this.countRevenueButton.TabIndex = 18;
            this.countRevenueButton.Text = "Revenue";
            this.countRevenueButton.UseVisualStyleBackColor = true;
            this.countRevenueButton.Click += new System.EventHandler(this.countRevenueButton_Click);
            // 
            // countCostsButton
            // 
            this.countCostsButton.Location = new System.Drawing.Point(984, 91);
            this.countCostsButton.Name = "countCostsButton";
            this.countCostsButton.Size = new System.Drawing.Size(75, 23);
            this.countCostsButton.TabIndex = 19;
            this.countCostsButton.Text = "Costs";
            this.countCostsButton.UseVisualStyleBackColor = true;
            this.countCostsButton.Click += new System.EventHandler(this.countCostsButton_Click);
            // 
            // PoolCheckbox
            // 
            this.PoolCheckbox.AutoSize = true;
            this.PoolCheckbox.Location = new System.Drawing.Point(3, 12);
            this.PoolCheckbox.Name = "PoolCheckbox";
            this.PoolCheckbox.Size = new System.Drawing.Size(89, 19);
            this.PoolCheckbox.TabIndex = 20;
            this.PoolCheckbox.Text = "Pool Access";
            this.PoolCheckbox.UseVisualStyleBackColor = true;
            this.PoolCheckbox.CheckedChanged += new System.EventHandler(this.PoolCheckbox_CheckedChanged);
            // 
            // ParkingLotCheckbox
            // 
            this.ParkingLotCheckbox.AutoSize = true;
            this.ParkingLotCheckbox.Location = new System.Drawing.Point(3, 37);
            this.ParkingLotCheckbox.Name = "ParkingLotCheckbox";
            this.ParkingLotCheckbox.Size = new System.Drawing.Size(105, 19);
            this.ParkingLotCheckbox.TabIndex = 21;
            this.ParkingLotCheckbox.Text = "Parking Access";
            this.ParkingLotCheckbox.UseVisualStyleBackColor = true;
            this.ParkingLotCheckbox.CheckedChanged += new System.EventHandler(this.ParkingLotCheckbox_CheckedChanged);
            // 
            // UParkingLotCheckbox
            // 
            this.UParkingLotCheckbox.AutoSize = true;
            this.UParkingLotCheckbox.Location = new System.Drawing.Point(3, 62);
            this.UParkingLotCheckbox.Name = "UParkingLotCheckbox";
            this.UParkingLotCheckbox.Size = new System.Drawing.Size(179, 19);
            this.UParkingLotCheckbox.TabIndex = 22;
            this.UParkingLotCheckbox.Text = "Underground Parking Access";
            this.UParkingLotCheckbox.UseVisualStyleBackColor = true;
            this.UParkingLotCheckbox.CheckedChanged += new System.EventHandler(this.UParkingLotCheckbox_CheckedChanged);
            // 
            // AccessPanel
            // 
            this.AccessPanel.Controls.Add(this.PoolCheckbox);
            this.AccessPanel.Controls.Add(this.ParkingLotCheckbox);
            this.AccessPanel.Controls.Add(this.UParkingLotCheckbox);
            this.AccessPanel.Location = new System.Drawing.Point(500, 390);
            this.AccessPanel.Name = "AccessPanel";
            this.AccessPanel.Size = new System.Drawing.Size(200, 100);
            this.AccessPanel.TabIndex = 23;
            // 
            // displayAccessButton
            // 
            this.displayAccessButton.Location = new System.Drawing.Point(745, 414);
            this.displayAccessButton.Name = "displayAccessButton";
            this.displayAccessButton.Size = new System.Drawing.Size(75, 43);
            this.displayAccessButton.TabIndex = 24;
            this.displayAccessButton.Text = "Display Access";
            this.displayAccessButton.UseVisualStyleBackColor = true;
            this.displayAccessButton.Click += new System.EventHandler(this.displayAccessButton_Click);
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 663);
            this.Controls.Add(this.displayAccessButton);
            this.Controls.Add(this.AccessPanel);
            this.Controls.Add(this.countCostsButton);
            this.Controls.Add(this.countRevenueButton);
            this.Controls.Add(this.costsLabel);
            this.Controls.Add(this.revenueLabel);
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
            this.AccessPanel.ResumeLayout(false);
            this.AccessPanel.PerformLayout();
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
        private Label revenueLabel;
        private Label costsLabel;
        private Button countRevenueButton;
        private Button countCostsButton;
        private CheckBox PoolCheckbox;
        private CheckBox ParkingLotCheckbox;
        private CheckBox UParkingLotCheckbox;
        private Panel AccessPanel;
        private Button displayAccessButton;
    }
}