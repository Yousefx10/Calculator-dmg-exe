using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                largeScreenNumber = 10;

                label_result.Height += 18;
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
                largeScreenNumber = 0;
                label_result.Height -= 18;
            }

            //txtNotOver2_TextChanged(sender, e);
            // label_result.TextChanged(sender, e);



            label_result_TextChanged(label_result,null);
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

            }


        }

        public void panel_result_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        bool stooop=false;
        int largeScreenNumber = 0;
        private void label_result_TextChanged(object sender, EventArgs e)
        {

            if(label_result.Text.Length>11)
                label_result.Font = new System.Drawing.Font(label_result.Font.Name, largeScreenNumber+ 20F);
            else if(label_result.Text.Length > 9)
                label_result.Font = new System.Drawing.Font(label_result.Font.Name, largeScreenNumber + 25F);
            else
                label_result.Font = new System.Drawing.Font(label_result.Font.Name, largeScreenNumber + 32);

            if (label_result.Text.Length > 14)
            stooop = true;
            else
                stooop = false;

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
        bool OPclicked = false;//check if [+ - x /] are still pressed or no , useful for DOT button.
        private void btn_zero_MouseUp(object sender, MouseEventArgs e)
        {

            if (!stooop)
                if (doNUM)
                    label_result.Text += "0";
                else if (OPclicked)
                {
                    OPclicked = false;
                    label_result.Text = "0";
                                theDOT = false;
                }



        }

        private void btn_one_MouseUp(object sender, MouseEventArgs e)
        {
            if ( !stooop)
            {
                if (operation_status == 0)
                {
                    label_result.Text = ((iosButtons)sender).Text;
                    operation_status++;
                    doNUM = true;
                }

                else if (doNUM)
                    label_result.Text += ((iosButtons)sender).Text;
                else
                {
                    doNUM = true;
                    theDOT = false;
                    label_result.Text = ((iosButtons)sender).Text;
                }
                changeCOLORS(btn_equal, false);
            }

            OPclicked = false;


        }

        private void btn_ac_MouseUp(object sender, MouseEventArgs e)
        {

                label_result.Text ="0";
                operation_status=0;
                changeCOLORS(btn_equal, false);
                doNUM = false;
                theDOT = false;
                stooop = false;
                OPclicked = false;


        }

        private void btn_plus_MouseUp(object sender, MouseEventArgs e)
        {

                //if(operation_status != 0)
                {
                    changeCOLORS(btn_plus);
                    operation_status = 2;
                    num = float.Parse(label_result.Text);
                    doNUM = false;
                    //theDOT = false;
                    stooop=false;
                    OPclicked = true;
                }


        }
        private void btn_equal_MouseUp(object sender, MouseEventArgs e)
        {

                    if (operation_status == 2)
                        num = num + float.Parse(label_result.Text);
                    else if (operation_status == 3)
                        num = num - float.Parse(label_result.Text);
                    else if (operation_status == 4)
                        num = num * float.Parse(label_result.Text);
                    else if (operation_status == 5)
                        num = num / float.Parse(label_result.Text);
                    else { return; }

                    changeCOLORS(btn_equal, false);
                    operation_status = 1;
                    doNUM = false;
                    theDOT = true;
                    label_result.Text = num.ToString();

        }

        private void btn_minus_MouseUp(object sender, MouseEventArgs e)
        {

             //   if (operation_status != 0)
                {
                    changeCOLORS(btn_minus);
                    operation_status = 3;
                    num = float.Parse(label_result.Text);
                    doNUM = false;
                    //theDOT = false;
                    stooop = false;
                    OPclicked = true;

                }

        }

        private void btn_multi_MouseUp(object sender, MouseEventArgs e)
        {

             //   if (operation_status != 0)
                {
                    changeCOLORS(btn_multi);
                    operation_status = 4;
                    num = float.Parse(label_result.Text);
                    doNUM = false;
                    //theDOT = false;
                    stooop = false;
                    OPclicked = true;

                }

        }

        private void btn_dividing_MouseUp(object sender, MouseEventArgs e)
        {

             //   if (operation_status != 0)
                {
                    changeCOLORS(btn_dividing);
                    operation_status = 5;
                    num = float.Parse(label_result.Text);
                    doNUM = false;
                    //theDOT = false;
                    stooop = false;
                    OPclicked = true;

                }

        }
        bool theDOT = false;
        private void btn_dot_MouseUp(object sender, MouseEventArgs e)
        {

            /*
             
            if (!stooop)
                //label_result.Text = ((iosButtons)sender).Text;
                if (!theDOT)
                {
                    //  if(OPclicked)
                      //label_result.Text = "0.";
                      else
                    
                        if (!OPclicked)
                        {
                            if (!label_result.Text.Contains("E"))
                            {
                                label_result.Text += ".";

                                if (operation_status == 0)
                                    operation_status++;
                            }


                        }
                        else
                        {
                            label_result.Text = "0.";
                            OPclicked = false;
                        }
                        theDOT = true;
                        doNUM = true;
                        changeCOLORS(btn_equal, false);
                    


                }
        */

            if (!stooop)
            {
                if(theDOT==false)
                {
                    if (!label_result.Text.Contains("."))
                    {
                        if (!label_result.Text.Contains("E"))
                        {

                            label_result.Text += ".";
                            doNUM = true;
                            if(operation_status == 0)
                                operation_status=1;
                        }

                    }

                }
                else
                {
                    label_result.Text = "0.";
                    theDOT = false;
                    doNUM = true;
                }

                changeCOLORS(btn_equal, false);
                OPclicked = false;

            }


        }

        private void btn_remainder_MouseUp(object sender, MouseEventArgs e)
        {

                if(float.Parse( label_result.Text) != 0)
                {
                    num = float.Parse(label_result.Text) / 100;
                    label_result.Text = num.ToString();
                }
            if (label_result.Text.Contains("E"))
                stooop = true;

        }

        private void btn_mins_plus_MouseUp(object sender, MouseEventArgs e)
        {

                num = float.Parse(label_result.Text) *(- 1);
                label_result.Text = num.ToString();
        }



        private void CalculatorForm_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string oka="";
            int i;
            if (int.TryParse(e.KeyChar.ToString(), out i))
            {

                if (i == 0)
                {
                    btn_zero_MouseUp("btn_zero", null);
                    btn_zero.anima(true);
                    return;
                }
                oka = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }[i - 1];
                iosButtons ioo = ((iosButtons)flowLayoutPanel1.Controls.Find("btn_" + oka, false)[0]);

                ioo.anima(true);

                btn_one_MouseUp(ioo, null);
                
                //iosButtons ioo = ((iosButtons)flowLayoutPanel1.Controls.Find("btn_"+ oka, false)[0]);
                // MessageBox.Show(oka);


            }
            else if (e.KeyChar == '.')
            {
                btn_dot_MouseUp(null, null);
                btn_dot.anima(true);
            }
            else
            {

                switch(e.KeyChar)
                {
                    case '+':
                        btn_plus_MouseUp(null, null);
                        break;
                    case '-':
                        btn_minus_MouseUp(null, null);
                        break;
                    case '*':
                        btn_multi_MouseUp(null, null);
                        break;
                    case '/':
                        btn_dividing_MouseUp(null, null);
                        break;
                    case (char)13://equal button
                        btn_equal_MouseUp(null, null);
                        break;                    
                    case (char)8://BACKSPACE button
                        if (theDOT == false && label_result.Text.Length > 1)
                        {
                                label_result.Text = label_result.Text.Substring(0, (label_result.Text.Length - 1));
                        }
                        else
                        {
                            btn_ac_MouseUp(null, null);
                        }
                        break;
                }
            }
        }



        //if (nn)
        //this code inside click action of buttons


    }
}
//notes section :
//the font size problem with enable and disable
//the DOT problem when do [ + - x / ] it don't clear the text if first clicked
//the first operate with zero
//Fix [ euler's number - Notation ] with dot error.
//fix dot with after operator problem


//TWO MAIN PROBLEMS :
// WHEN LARGE NUMBER CONTAIN (E) it occur error when add number
//still period problem if didn't click operator number