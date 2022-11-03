namespace Calculator_dmg_exe
{
    partial class iosButtons
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
            this.lblTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTXT
            // 
            this.lblTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTXT.ForeColor = System.Drawing.Color.White;
            this.lblTXT.Location = new System.Drawing.Point(0, 0);
            this.lblTXT.Name = "lblTXT";
            this.lblTXT.Size = new System.Drawing.Size(62, 62);
            this.lblTXT.TabIndex = 0;
            this.lblTXT.Text = "0";
            this.lblTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iosButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTXT);
            this.Name = "iosButtons";
            this.Size = new System.Drawing.Size(62, 62);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTXT;
    }
}
