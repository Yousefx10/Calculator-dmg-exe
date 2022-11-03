namespace Calculator_dmg_exe
{
    partial class navButtons
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
            this.ico_red = new System.Windows.Forms.PictureBox();
            this.ico_yellow = new System.Windows.Forms.PictureBox();
            this.ico_green = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ico_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_green)).BeginInit();
            this.SuspendLayout();
            // 
            // ico_red
            // 
            this.ico_red.Image = global::Calculator_dmg_exe.Properties.Resources.R1;
            this.ico_red.Location = new System.Drawing.Point(3, 3);
            this.ico_red.Name = "ico_red";
            this.ico_red.Size = new System.Drawing.Size(12, 12);
            this.ico_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ico_red.TabIndex = 0;
            this.ico_red.TabStop = false;
            this.ico_red.Click += new System.EventHandler(this.ico_red_Click);
            this.ico_red.MouseEnter += new System.EventHandler(this.ico_red_MouseEnter);
            this.ico_red.MouseLeave += new System.EventHandler(this.ico_red_MouseLeave);
            // 
            // ico_yellow
            // 
            this.ico_yellow.Image = global::Calculator_dmg_exe.Properties.Resources.Y1;
            this.ico_yellow.Location = new System.Drawing.Point(22, 3);
            this.ico_yellow.Name = "ico_yellow";
            this.ico_yellow.Size = new System.Drawing.Size(12, 12);
            this.ico_yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ico_yellow.TabIndex = 1;
            this.ico_yellow.TabStop = false;
            this.ico_yellow.MouseEnter += new System.EventHandler(this.ico_red_MouseEnter);
            this.ico_yellow.MouseLeave += new System.EventHandler(this.ico_red_MouseLeave);
            // 
            // ico_green
            // 
            this.ico_green.Image = global::Calculator_dmg_exe.Properties.Resources.G1;
            this.ico_green.Location = new System.Drawing.Point(41, 3);
            this.ico_green.Name = "ico_green";
            this.ico_green.Size = new System.Drawing.Size(12, 12);
            this.ico_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ico_green.TabIndex = 2;
            this.ico_green.TabStop = false;
            this.ico_green.Click += new System.EventHandler(this.ico_green_Click);
            this.ico_green.MouseEnter += new System.EventHandler(this.ico_red_MouseEnter);
            this.ico_green.MouseLeave += new System.EventHandler(this.ico_red_MouseLeave);
            // 
            // navButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ico_green);
            this.Controls.Add(this.ico_yellow);
            this.Controls.Add(this.ico_red);
            this.Name = "navButtons";
            this.Size = new System.Drawing.Size(62, 21);
            ((System.ComponentModel.ISupportInitialize)(this.ico_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_green)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ico_red;
        private System.Windows.Forms.PictureBox ico_yellow;
        private System.Windows.Forms.PictureBox ico_green;
    }
}
