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



        public enum TextAlignSize
        {
            Normal,
            Left,
            Center
        }
        #region Collapse TextSizeAlign

        [Browsable(true), DefaultValue("Normal"), Description("Text center or left")]
        [ListBindable(true), Editor(typeof(ComboBox), typeof(UITypeEditor))]
        public TextAlignSize _textsize = TextAlignSize.Normal;
        public TextAlignSize TextSizeAlign
        {
            get { return _textsize; }
            set
            {
                _textsize = value;
                CalltextPlace();
            }
        }


        public event Action textplace;
        protected void CalltextPlace()
        {
            Action handler = textplace;
            changeTextPlace();
            if (handler != null)
            {
                handler();
            }
        }
        #endregion


        private void changeTextPlace()
        {
            switch (_textsize)
            {
                case TextAlignSize.Normal:
                    lblTXT.Location = new Point(17, 16);
                    break;

                case TextAlignSize.Left:
                    lblTXT.Location = new Point(9, lblTXT.Location.Y);
                    break;

                case TextAlignSize.Center:
                    lblTXT.Location = new Point(46, lblTXT.Location.Y);
                    break;

            }
        }






        public iosButtons()
        {
            InitializeComponent();
        }
    }
}
