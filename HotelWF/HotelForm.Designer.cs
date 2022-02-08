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
            ((System.ComponentModel.ISupportInitialize)(this.GuestGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestGrid
            // 
            this.GuestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestGrid.Location = new System.Drawing.Point(115, 136);
            this.GuestGrid.Name = "GuestGrid";
            this.GuestGrid.RowTemplate.Height = 25;
            this.GuestGrid.Size = new System.Drawing.Size(345, 242);
            this.GuestGrid.TabIndex = 0;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 663);
            this.Controls.Add(this.GuestGrid);
            this.Name = "HotelForm";
            this.Text = "HOTEL DATABASE";
            ((System.ComponentModel.ISupportInitialize)(this.GuestGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GuestGrid;
    }
}