using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_dmg_exe
{
    public partial class iosButtons : UserControl
    {

        public enum CollapseDirection
        {
            Normal,
            Big,
            Wide,
            wider
        }
        #region Collapse Direction

        [Browsable(true), DefaultValue("Normal"), Description("Buttons's size")]
        [ListBindable(true), Editor(typeof(ComboBox), typeof(UITypeEditor))]
        public CollapseDirection _direction = CollapseDirection.Normal;
        public CollapseDirection Direction
        {
            get { return _direction; }
            set
            {
                _direction = value;
                callCollapseDirectionChanged();
            }
        }


        public event Action CollapseDirectionChanged;
        protected void callCollapseDirectionChanged()
        {
            Action handler = CollapseDirectionChanged;
            DisplayButtons();
            if (handler != null)
            {
                handler();
            }
        }
        #endregion


        private void DisplayButtons()
        {
            switch (_direction)
            {
                case CollapseDirection.Normal:
                    this.Size = new Size(60,60);
                   lblTXT.Font = new System.Drawing.Font(lblTXT.Font.Name, 18F);
                    break;

                case CollapseDirection.Big:
                    this.Size = new Size(100, 100);
                    lblTXT.Font = new System.Drawing.Font(lblTXT.Font.Name, 35F);

                    break;

                case CollapseDirection.Wide:
                    //sum of two buttons size
                    this.Size = new Size(120, Height);
                    lblTXT.Font = new System.Drawing.Font(lblTXT.Font.Name, 18F);
                    break;

                case CollapseDirection.wider:
                    //sum of two buttons size
                    this.Size = new Size(200, Height);
                    lblTXT.Font = new System.Drawing.Font(lblTXT.Font.Name, 40F);

                    //just for the wide button zero in case the maximum screen
                    lblTXT.Location = new Point(66, lblTXT.Location.Y);

                    break;
            }
        }



        //EditButton Content :
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public override string Text
        {
            get
            {
                return lblTXT.Text;
            }

            set
            {
                lblTXT.Text = value;
            }
        }



        public iosButtons()
        {
            InitializeComponent();
        }





        private void Control_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblTXT_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp(e);

            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Show();

            timer_animation.Start();
            timer1.Start();
        }

        private void iosButtons_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hey from btn");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_animation.Stop();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();

            panel1.Width = 10;
            panel2.Width = 10;
            panel3.Height = 10;
            panel4.Height = 10;

            timer1.Stop();
        }

        private void timer_animation_Tick(object sender, EventArgs e)
        {
            panel1.Width  -= 2;
            panel2.Width  -= 2;
            panel3.Height -= 2;
            panel4.Height -= 2;
        }
    }
}
