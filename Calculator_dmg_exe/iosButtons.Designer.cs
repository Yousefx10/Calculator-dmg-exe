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
            this.lblTXT.AutoSize = true;
            this.lblTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTXT.Location = new System.Drawing.Point(18, 18);
            this.lblTXT.Name = "lblTXT";
            this.lblTXT.Size = new System.Drawing.Size(24, 25);
            this.lblTXT.TabIndex = 0;
            this.lblTXT.Text = "0";
            // 
            // iosButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTXT);
            this.Name = "iosButtons";
            this.Size = new System.Drawing.Size(60, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTXT;
    }
}
