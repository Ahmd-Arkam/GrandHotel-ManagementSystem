namespace GrandHotel_ManagementSystem.controllers
{
    partial class CustomerHistory
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
            this.components = new System.ComponentModel.Container();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(-1, -1);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1131, 593);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Customer History";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // CustomerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox2);
            this.Name = "CustomerHistory";
            this.Size = new System.Drawing.Size(1131, 593);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
