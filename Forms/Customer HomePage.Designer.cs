namespace Forms
{
    partial class Customer_HomePage
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
            this.tilePayment = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tilePayment
            // 
            this.tilePayment.ActiveControl = null;
            this.tilePayment.Location = new System.Drawing.Point(35, 82);
            this.tilePayment.Name = "tilePayment";
            this.tilePayment.Size = new System.Drawing.Size(203, 164);
            this.tilePayment.Style = MetroFramework.MetroColorStyle.Red;
            this.tilePayment.TabIndex = 30;
            this.tilePayment.Text = "Order";
            this.tilePayment.UseSelectable = true;
            this.tilePayment.Click += new System.EventHandler(this.tilePayment_Click);
            // 
            // Customer_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 510);
            this.Controls.Add(this.tilePayment);
            this.Name = "Customer_HomePage";
            this.Text = "Customer_HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tilePayment;
    }
}