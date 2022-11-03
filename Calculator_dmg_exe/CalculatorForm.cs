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

                iosButtons17.Direction = iosButtons.CollapseDirection.wider;
                flowLayoutPanel1.Size = new Size(400, 494);
                panel1.Size = new Size(400, 122);
                navButtons1.Location = new Point(21, 9);
                CenterToScreen();
            }
            else
            {
                ismax = false;
                Size = new Size(241, 389);
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                foreach (iosButtons iob in flowLayoutPanel1.Controls)
                {
                    iob.Direction = iosButtons.CollapseDirection.Normal;
                }
                iosButtons17.Direction = iosButtons.CollapseDirection.Wide;
                flowLayoutPanel1.Size = new Size(421,296);
                panel1.Size = new Size(241,93);
                navButtons1.Location = new Point(8,5);

            }



        }
    }
}
