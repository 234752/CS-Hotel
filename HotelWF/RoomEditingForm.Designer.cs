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
            this.maxGuestTextBox = new System.Windows.Forms.TextBox();
            this.guestsTexBox = new System.Windows.Forms.TextBox();
            this.feeTextBox = new System.Windows.Forms.TextBox();
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
            // maxGuestTextBox
            // 
            this.maxGuestTextBox.Location = new System.Drawing.Point(265, 76);
            this.maxGuestTextBox.Name = "maxGuestTextBox";
            this.maxGuestTextBox.Size = new System.Drawing.Size(75, 23);
            this.maxGuestTextBox.TabIndex = 4;
            // 
            // guestsTexBox
            // 
            this.guestsTexBox.Location = new System.Drawing.Point(346, 76);
            this.guestsTexBox.Name = "guestsTexBox";
            this.guestsTexBox.ReadOnly = true;
            this.guestsTexBox.Size = new System.Drawing.Size(75, 23);
            this.guestsTexBox.TabIndex = 5;
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(427, 76);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.ReadOnly = true;
            this.feeTextBox.Size = new System.Drawing.Size(75, 23);
            this.feeTextBox.TabIndex = 6;
            // 
            // RoomEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 137);
            this.Controls.Add(this.feeTextBox);
            this.Controls.Add(this.guestsTexBox);
            this.Controls.Add(this.maxGuestTextBox);
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
        private TextBox maxGuestTextBox;
        private TextBox guestsTexBox;
        private TextBox feeTextBox;
    }
}