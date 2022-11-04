using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_dmg_exe
{
    public partial class CalculatorForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
);

        public CalculatorForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            SetStyle(ControlStyles.StandardDoubleClick, false);

        }



        bool ismax=false;
         public void bigSize()
        {
            if(!ismax)
            {
                ismax = true;
                Size = new Size(400, 612);
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
                foreach (iosButtons iob in flowLayoutPanel1.Controls)
                {
                    iob.Direction = iosButtons.CollapseDirection.Big;
                }

                btn_zero.Direction = iosButtons.CollapseDirection.wider;
                flowLayoutPanel1.Size = new Size(400, 494);
                panel_result.Size = new Size(400, 122);
                navButtons1.Location = new Point(21, 9);
                CenterToScreen();
            }
            else
            {
                ismax = false;
                //new size :241, 376
                //old size : Size = (241, 389);
                Size = new Size(241, 376);

                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                foreach (iosButtons iob in flowLayoutPanel1.Controls)
                {
                    iob.Direction = iosButtons.CollapseDirection.Normal;
                }
                btn_zero.Direction = iosButtons.CollapseDirection.Wide;
                flowLayoutPanel1.Size = new Size(421,296);

                //new size :241, 78
                //old size : 241,93
                panel_result.Size = new Size(241, 84);

                navButtons1.Location = new Point(8,7);

            }



        }



        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;




        public void panel_result_MouseDown(object sender, MouseEventArgs e)
        {

            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        public void panel_result_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
                nn = false;
            }


        }

        public void panel_result_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            nn = true;
        }

        bool nn = true;

        private void label_result_TextChanged(object sender, EventArgs e)
        {
            if(label_result.Text.Length>10)
                label_result.Font = new System.Drawing.Font(label_result.Font.Name, 18F);
        }

        private void label_result_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label_result.Font+"");
        }

        void changeCOLORS(iosButtons bh, bool X =true )
        {
            
            btn_plus.BackColor = ColorTranslator.FromHtml("#F59E3E");
            btn_minus.BackColor = ColorTranslator.FromHtml("#F59E3E");
            btn_multi.BackColor = ColorTranslator.FromHtml("#F59E3E");
            btn_dividing.BackColor = ColorTranslator.FromHtml("#F59E3E");
            if(X)
            bh.BackColor = SystemColors.ActiveBorder;

        }

        // 0 = no operate
        // 1 = hold first num
        // 2 = SUM


        int   operation_status = 0;
        float num = 0;
        bool doNUM = false;

        private void btn_zero_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (nn)
                if(doNUM)
                label_result.Text += ((iosButtons)sender).Text;

        }

        private void btn_one_MouseUp(object sender, MouseEventArgs e)
        {
            if (nn)
                if (operation_status == 0)
                {
                    label_result.Text = ((iosButtons)sender).Text;
                    operation_status++;
                    doNUM = true;
                }

                else 
                    if(doNUM)
                    label_result.Text += ((iosButtons)sender).Text;
                    else
                    {
                        doNUM = true;
                        label_result.Text = ((iosButtons)sender).Text;
                    }
            changeCOLORS(btn_equal, false);


        }

        private void btn_ac_MouseUp(object sender, MouseEventArgs e)
        {
            if (nn)
            {
                label_result.Text ="0";
                operation_status=0;
                changeCOLORS(btn_equal, false);
            }

        }

        private void btn_plus_MouseUp(object sender, MouseEventArgs e)
        {
            if (nn)
            {
                if(operation_status != 0)
                {
                    btn_plus.BackColor = SystemColors.ActiveBorder;
                    operation_status = 2;
                    num = float.Parse(label_result.Text);
                    doNUM = false;
                }

            }
        }

        private void btn_equal_MouseUp(object sender, MouseEventArgs e)
        {
            if (nn)
            {
                if (operation_status == 2)
                    num = num + float.Parse(label_result.Text);
                else if(operation_status == 3)
                    num = num - float.Parse(label_result.Text);


                changeCOLORS(btn_equal, false);
                operation_status = 1;
                doNUM = false;
                label_result.Text = num.ToString();
            }
        }

        private void btn_minus_MouseUp(object sender, MouseEventArgs e)
        {
            if (nn)
            {
                if (operation_status != 0)
                {
                    changeCOLORS(btn_minus);
                    operation_status = 3;
                    num = float.Parse(label_result.Text);
                    doNUM = false;
                }

            }
        }



        //if (nn)
        //this code inside click action of buttons


    }
}
