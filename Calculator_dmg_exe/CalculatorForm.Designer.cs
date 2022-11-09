namespace Calculator_dmg_exe
{
    partial class CalculatorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_result = new System.Windows.Forms.Panel();
            this.label_result = new System.Windows.Forms.Label();
            this.timer_mini = new System.Windows.Forms.Timer(this.components);
            this.navButtons1 = new Calculator_dmg_exe.navButtons();
            this.btn_ac = new Calculator_dmg_exe.iosButtons();
            this.btn_mins_plus = new Calculator_dmg_exe.iosButtons();
            this.btn_remainder = new Calculator_dmg_exe.iosButtons();
            this.btn_dividing = new Calculator_dmg_exe.iosButtons();
            this.btn_seven = new Calculator_dmg_exe.iosButtons();
            this.btn_eight = new Calculator_dmg_exe.iosButtons();
            this.btn_nine = new Calculator_dmg_exe.iosButtons();
            this.btn_multi = new Calculator_dmg_exe.iosButtons();
            this.btn_four = new Calculator_dmg_exe.iosButtons();
            this.btn_five = new Calculator_dmg_exe.iosButtons();
            this.btn_six = new Calculator_dmg_exe.iosButtons();
            this.btn_minus = new Calculator_dmg_exe.iosButtons();
            this.btn_one = new Calculator_dmg_exe.iosButtons();
            this.btn_two = new Calculator_dmg_exe.iosButtons();
            this.btn_three = new Calculator_dmg_exe.iosButtons();
            this.btn_plus = new Calculator_dmg_exe.iosButtons();
            this.btn_zero = new Calculator_dmg_exe.iosButtons();
            this.btn_dot = new Calculator_dmg_exe.iosButtons();
            this.btn_equal = new Calculator_dmg_exe.iosButtons();
            this.timer_stops = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_ac);
            this.flowLayoutPanel1.Controls.Add(this.btn_mins_plus);
            this.flowLayoutPanel1.Controls.Add(this.btn_remainder);
            this.flowLayoutPanel1.Controls.Add(this.btn_dividing);
            this.flowLayoutPanel1.Controls.Add(this.btn_seven);
            this.flowLayoutPanel1.Controls.Add(this.btn_eight);
            this.flowLayoutPanel1.Controls.Add(this.btn_nine);
            this.flowLayoutPanel1.Controls.Add(this.btn_multi);
            this.flowLayoutPanel1.Controls.Add(this.btn_four);
            this.flowLayoutPanel1.Controls.Add(this.btn_five);
            this.flowLayoutPanel1.Controls.Add(this.btn_six);
            this.flowLayoutPanel1.Controls.Add(this.btn_minus);
            this.flowLayoutPanel1.Controls.Add(this.btn_one);
            this.flowLayoutPanel1.Controls.Add(this.btn_two);
            this.flowLayoutPanel1.Controls.Add(this.btn_three);
            this.flowLayoutPanel1.Controls.Add(this.btn_plus);
            this.flowLayoutPanel1.Controls.Add(this.btn_zero);
            this.flowLayoutPanel1.Controls.Add(this.btn_dot);
            this.flowLayoutPanel1.Controls.Add(this.btn_equal);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(241, 296);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel_result
            // 
            this.panel_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.panel_result.Controls.Add(this.navButtons1);
            this.panel_result.Controls.Add(this.label_result);
            this.panel_result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_result.Location = new System.Drawing.Point(0, -4);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(241, 84);
            this.panel_result.TabIndex = 1;
            this.panel_result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_result_MouseDown);
            this.panel_result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_result_MouseMove);
            this.panel_result.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_result_MouseUp);
            // 
            // label_result
            // 
            this.label_result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label_result.ForeColor = System.Drawing.Color.White;
            this.label_result.Location = new System.Drawing.Point(0, 33);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(241, 51);
            this.label_result.TabIndex = 0;
            this.label_result.Text = "0";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_result.TextChanged += new System.EventHandler(this.label_result_TextChanged);
            this.label_result.Click += new System.EventHandler(this.label_result_Click);
            this.label_result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_result_MouseDown);
            this.label_result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_result_MouseMove);
            this.label_result.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_result_MouseUp);
            // 
            // timer_mini
            // 
            this.timer_mini.Interval = 10;
            this.timer_mini.Tick += new System.EventHandler(this.timer_mini_Tick);
            // 
            // navButtons1
            // 
            this.navButtons1.Location = new System.Drawing.Point(8, 7);
            this.navButtons1.Name = "navButtons1";
            this.navButtons1.Size = new System.Drawing.Size(75, 23);
            this.navButtons1.TabIndex = 1;
            // 
            // btn_ac
            // 
            this.btn_ac.Animation = false;
            this.btn_ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.btn_ac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_ac.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_ac.Location = new System.Drawing.Point(0, 0);
            this.btn_ac.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ac.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(60, 60);
            this.btn_ac.TabIndex = 0;
            this.btn_ac.Text = "AC";
            this.btn_ac.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ac_MouseUp);
            // 
            // btn_mins_plus
            // 
            this.btn_mins_plus.Animation = false;
            this.btn_mins_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.btn_mins_plus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_mins_plus.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_mins_plus.Location = new System.Drawing.Point(60, 0);
            this.btn_mins_plus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_mins_plus.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_mins_plus.Name = "btn_mins_plus";
            this.btn_mins_plus.Size = new System.Drawing.Size(60, 60);
            this.btn_mins_plus.TabIndex = 1;
            this.btn_mins_plus.Text = "+/-";
            this.btn_mins_plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_mins_plus_MouseUp);
            // 
            // btn_remainder
            // 
            this.btn_remainder.Animation = false;
            this.btn_remainder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.btn_remainder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_remainder.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_remainder.Location = new System.Drawing.Point(120, 0);
            this.btn_remainder.Margin = new System.Windows.Forms.Padding(0);
            this.btn_remainder.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_remainder.Name = "btn_remainder";
            this.btn_remainder.Size = new System.Drawing.Size(60, 60);
            this.btn_remainder.TabIndex = 2;
            this.btn_remainder.Text = "%";
            this.btn_remainder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_remainder_MouseUp);
            // 
            // btn_dividing
            // 
            this.btn_dividing.Animation = false;
            this.btn_dividing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(62)))));
            this.btn_dividing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_dividing.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.flowLayoutPanel1.SetFlowBreak(this.btn_dividing, true);
            this.btn_dividing.Location = new System.Drawing.Point(180, 0);
            this.btn_dividing.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dividing.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_dividing.Name = "btn_dividing";
            this.btn_dividing.Size = new System.Drawing.Size(60, 60);
            this.btn_dividing.TabIndex = 3;
            this.btn_dividing.Text = "÷";
            this.btn_dividing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_dividing_MouseUp);
            // 
            // btn_seven
            // 
            this.btn_seven.Animation = true;
            this.btn_seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_seven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_seven.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_seven.Location = new System.Drawing.Point(0, 60);
            this.btn_seven.Margin = new System.Windows.Forms.Padding(0);
            this.btn_seven.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(60, 60);
            this.btn_seven.TabIndex = 4;
            this.btn_seven.Text = "7";
            this.btn_seven.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_one_MouseUp);
            // 
            // btn_eight
            // 
            this.btn_eight.Animation = true;
            this.btn_eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_eight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_eight.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_eight.Location = new System.Drawing.Point(60, 60);
            this.btn_eight.Margin = new System.Windows.Forms.Padding(0);
            this.btn_eight.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(60, 60);
            this.btn_eight.TabIndex = 5;
            this.btn_eight.Text = "8";
            this.btn_eight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_one_MouseUp);
            // 
            // btn_nine
            // 
            this.btn_nine.Animation = true;
            this.btn_nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_nine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_nine.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_nine.Location = new System.Drawing.Point(120, 60);
            this.btn_nine.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nine.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(60, 60);
            this.btn_nine.TabIndex = 6;
            this.btn_nine.Text = "9";
            this.btn_nine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_one_MouseUp);
            // 
            // btn_multi
            // 
            this.btn_multi.Animation = false;
            this.btn_multi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(62)))));
            this.btn_multi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_multi.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.flowLayoutPanel1.SetFlowBreak(this.btn_multi, true);
            this.btn_multi.Location = new System.Drawing.Point(180, 60);
            this.btn_multi.Margin = new System.Windows.Forms.Padding(0);
            this.btn_multi.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(60, 60);
            this.btn_multi.TabIndex = 7;
            this.btn_multi.Text = "×";
            this.btn_multi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_multi_MouseUp);
            // 
            // btn_four
            // 
            this.btn_four.Animation = true;
            this.btn_four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_four.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_four.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_four.Location = new System.Drawing.Point(0, 120);
            this.btn_four.Margin = new System.Windows.Forms.Padding(0);
            this.btn_four.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(60, 60);
            this.btn_four.TabIndex = 8;
            this.btn_four.Text = "4";
            this.btn_four.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_one_MouseUp);
            // 
            // btn_five
            // 
            this.btn_five.Animation = true;
            this.btn_five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_five.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_five.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_five.Location = new System.Drawing.Point(60, 120);
            this.btn_five.Margin = new System.Windows.Forms.Padding(0);
            this.btn_five.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(60, 60);
            this.btn_five.TabIndex = 9;
            this.btn_five.Text = "5";
            this.btn_five.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_one_MouseUp);
            // 
            // btn_six
            // 
            this.btn_six.Animation = true;
            this.btn_six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_six.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_six.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_six.Location = new System.Drawing.Point(120, 120);
            this.btn_six.Margin = new System.Windows.Forms.Padding(0);
            this.btn_six.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(60, 60);
            this.btn_six.TabIndex = 10;
            this.btn_six.Text = "6";
            this.btn_six.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_one_MouseUp);
            // 
            // btn_minus
            // 
            this.btn_minus.Animation = false;
            this.btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(62)))));
            this.btn_minus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_minus.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.flowLayoutPanel1.SetFlowBreak(this.btn_minus, true);
            this.btn_minus.Location = new System.Drawing.Point(180, 120);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_minus.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(60, 60);
            this.btn_minus.TabIndex = 11;
            this.btn_minus.Text = "—";
            this.btn_minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_minus_MouseUp);
            // 
            // btn_one
            // 
            this.btn_one.Animation = true;
            this.btn_one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_one.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_one.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_one.Location = new System.Drawing.Point(0, 180);
            this.btn_one.Margin = new System.Windows.Forms.Padding(0);
            this.btn_one.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(60, 60);
            this.btn_one.TabIndex = 12;
            this.btn_one.Text = "1";
            this.btn_one.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_one_MouseUp);
            // 
            // btn_two
            // 
            this.btn_two.Animation = true;
            this.btn_two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_two.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_two.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_two.Location = new System.Drawing.Point(60, 180);
            this.btn_two.Margin = new System.Windows.Forms.Padding(0);
            this.btn_two.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(60, 60);
            this.btn_two.TabIndex = 13;
            this.btn_two.Text = "2";
            this.btn_two.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_one_MouseUp);
            // 
            // btn_three
            // 
            this.btn_three.Animation = true;
            this.btn_three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_three.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_three.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_three.Location = new System.Drawing.Point(120, 180);
            this.btn_three.Margin = new System.Windows.Forms.Padding(0);
            this.btn_three.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(60, 60);
            this.btn_three.TabIndex = 14;
            this.btn_three.Text = "3";
            this.btn_three.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_one_MouseUp);
            // 
            // btn_plus
            // 
            this.btn_plus.Animation = false;
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(62)))));
            this.btn_plus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_plus.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.flowLayoutPanel1.SetFlowBreak(this.btn_plus, true);
            this.btn_plus.Location = new System.Drawing.Point(180, 180);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_plus.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(60, 60);
            this.btn_plus.TabIndex = 15;
            this.btn_plus.Text = "+";
            this.btn_plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_plus_MouseUp);
            // 
            // btn_zero
            // 
            this.btn_zero.Animation = true;
            this.btn_zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_zero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_zero.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Wide;
            this.btn_zero.Location = new System.Drawing.Point(0, 240);
            this.btn_zero.Margin = new System.Windows.Forms.Padding(0);
            this.btn_zero.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(120, 60);
            this.btn_zero.TabIndex = 16;
            this.btn_zero.Text = "0";
            this.btn_zero.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_zero_MouseUp);
            // 
            // btn_dot
            // 
            this.btn_dot.Animation = true;
            this.btn_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btn_dot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_dot.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.btn_dot.Location = new System.Drawing.Point(120, 240);
            this.btn_dot.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dot.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(60, 60);
            this.btn_dot.TabIndex = 17;
            this.btn_dot.Text = "•";
            this.btn_dot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_dot_MouseUp);
            // 
            // btn_equal
            // 
            this.btn_equal.Animation = false;
            this.btn_equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(62)))));
            this.btn_equal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_equal.Direction = Calculator_dmg_exe.iosButtons.CollapseDirection.Normal;
            this.flowLayoutPanel1.SetFlowBreak(this.btn_equal, true);
            this.btn_equal.Location = new System.Drawing.Point(180, 240);
            this.btn_equal.Margin = new System.Windows.Forms.Padding(0);
            this.btn_equal.MinimumSize = new System.Drawing.Size(60, 60);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(60, 60);
            this.btn_equal.TabIndex = 18;
            this.btn_equal.Text = "=";
            this.btn_equal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_equal_MouseUp);
            // 
            // timer_stops
            // 
            this.timer_stops.Interval = 50;
            this.timer_stops.Tick += new System.EventHandler(this.timer_stops_Tick);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 376);
            this.ControlBox = false;
            this.Controls.Add(this.panel_result);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorForm_KeyPress_1);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_result.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private iosButtons btn_ac;
        private iosButtons btn_mins_plus;
        private iosButtons btn_remainder;
        private iosButtons btn_dividing;
        private iosButtons btn_seven;
        private iosButtons btn_eight;
        private iosButtons btn_nine;
        private iosButtons btn_multi;
        private iosButtons btn_four;
        private iosButtons btn_five;
        private iosButtons btn_six;
        private iosButtons btn_minus;
        private iosButtons btn_one;
        private iosButtons btn_two;
        private iosButtons btn_three;
        private iosButtons btn_plus;
        private iosButtons btn_zero;
        private iosButtons btn_dot;
        private iosButtons btn_equal;
        private System.Windows.Forms.Panel panel_result;
        private System.Windows.Forms.Label label_result;
        private navButtons navButtons1;
        private System.Windows.Forms.Timer timer_mini;
        private System.Windows.Forms.Timer timer_stops;
    }
}

