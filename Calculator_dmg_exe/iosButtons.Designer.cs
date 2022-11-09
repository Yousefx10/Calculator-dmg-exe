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
            this.components = new System.ComponentModel.Container();
            this.lblTXT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer_STOPS = new System.Windows.Forms.Timer(this.components);
            this.timer_animation = new System.Windows.Forms.Timer(this.components);
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
            this.lblTXT.Click += new System.EventHandler(this.Control_Click);
            this.lblTXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTXT_MouseDown);
            this.lblTXT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTXT_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 62);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(52, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 62);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(42, 10);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(42, 10);
            this.panel4.TabIndex = 4;
            this.panel4.Visible = false;
            // 
            // timer_STOPS
            // 
            this.timer_STOPS.Interval = 200;
            this.timer_STOPS.Tick += new System.EventHandler(this.timer_STOPS_Tick);
            // 
            // timer_animation
            // 
            this.timer_animation.Interval = 40;
            this.timer_animation.Tick += new System.EventHandler(this.timer_animation_Tick);
            // 
            // iosButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTXT);
            this.Name = "iosButtons";
            this.Size = new System.Drawing.Size(62, 62);
            this.Click += new System.EventHandler(this.iosButtons_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTXT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer_STOPS;
        private System.Windows.Forms.Timer timer_animation;
    }
}
