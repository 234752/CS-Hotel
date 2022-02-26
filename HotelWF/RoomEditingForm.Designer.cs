namespace HotelWF
{
    partial class RoomEditingForm
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.maxGuestsTextBox = new System.Windows.Forms.TextBox();
            this.guestsTextBox = new System.Windows.Forms.TextBox();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.noLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.maxGuestsLabel = new System.Windows.Forms.Label();
            this.guestsLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(508, 76);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(22, 76);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(75, 23);
            this.typeTextBox.TabIndex = 1;
            // 
            // noTextBox
            // 
            this.noTextBox.Location = new System.Drawing.Point(103, 76);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(75, 23);
            this.noTextBox.TabIndex = 2;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(184, 76);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(75, 23);
            this.areaTextBox.TabIndex = 3;
            // 
            // maxGuestsTextBox
            // 
            this.maxGuestsTextBox.Location = new System.Drawing.Point(265, 76);
            this.maxGuestsTextBox.Name = "maxGuestsTextBox";
            this.maxGuestsTextBox.Size = new System.Drawing.Size(75, 23);
            this.maxGuestsTextBox.TabIndex = 4;
            // 
            // guestsTextBox
            // 
            this.guestsTextBox.Location = new System.Drawing.Point(346, 76);
            this.guestsTextBox.Name = "guestsTextBox";
            this.guestsTextBox.ReadOnly = true;
            this.guestsTextBox.Size = new System.Drawing.Size(75, 23);
            this.guestsTextBox.TabIndex = 5;
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(427, 76);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.ReadOnly = true;
            this.feeTextBox.Size = new System.Drawing.Size(75, 23);
            this.feeTextBox.TabIndex = 6;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(22, 58);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 15);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Type";
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.Location = new System.Drawing.Point(103, 58);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(23, 15);
            this.noLabel.TabIndex = 8;
            this.noLabel.Text = "No";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(184, 58);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(31, 15);
            this.areaLabel.TabIndex = 9;
            this.areaLabel.Text = "Area";
            // 
            // maxGuestsLabel
            // 
            this.maxGuestsLabel.AutoSize = true;
            this.maxGuestsLabel.Location = new System.Drawing.Point(265, 58);
            this.maxGuestsLabel.Name = "maxGuestsLabel";
            this.maxGuestsLabel.Size = new System.Drawing.Size(68, 15);
            this.maxGuestsLabel.TabIndex = 10;
            this.maxGuestsLabel.Text = "Max Guests";
            // 
            // guestsLabel
            // 
            this.guestsLabel.AutoSize = true;
            this.guestsLabel.Location = new System.Drawing.Point(346, 58);
            this.guestsLabel.Name = "guestsLabel";
            this.guestsLabel.Size = new System.Drawing.Size(42, 15);
            this.guestsLabel.TabIndex = 11;
            this.guestsLabel.Text = "Guests";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(427, 58);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(25, 15);
            this.feeLabel.TabIndex = 12;
            this.feeLabel.Text = "Fee";
            // 
            // RoomEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 137);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.guestsLabel);
            this.Controls.Add(this.maxGuestsLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.noLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.feeTextBox);
            this.Controls.Add(this.guestsTextBox);
            this.Controls.Add(this.maxGuestsTextBox);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.confirmButton);
            this.Name = "RoomEditingForm";
            this.Text = "Edit Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button confirmButton;
        private TextBox typeTextBox;
        private TextBox noTextBox;
        private TextBox areaTextBox;
        private TextBox maxGuestsTextBox;
        private TextBox guestsTextBox;
        private TextBox feeTextBox;
        private Label typeLabel;
        private Label noLabel;
        private Label areaLabel;
        private Label maxGuestsLabel;
        private Label guestsLabel;
        private Label feeLabel;
    }
}