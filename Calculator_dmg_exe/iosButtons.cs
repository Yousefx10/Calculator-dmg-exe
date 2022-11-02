using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
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
            Wide
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
                    break;

                case CollapseDirection.Big:

                    break;

                case CollapseDirection.Wide:
                    //sum of two buttons size
                    this.Size = new Size(126,Height);
                    break;
            }
        }














        public iosButtons()
        {
            InitializeComponent();
        }
    }
}
