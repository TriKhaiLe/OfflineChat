using BaiThucHanh1.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1.Services
{
    public class NavigationControl
    {
        Panel panel;
        UserControl userControl;
        public NavigationControl(Panel panel, UserControl userControl)
        {
            this.panel = panel;
            this.userControl = userControl;
            userControl.Location = panel.Location;

        }

        public void Display(int index)
        {

            switch (index)
            {
                case 0:
                    panel.BringToFront();

                    break;

                case 1:
                    userControl.BringToFront();
                    break;
            }

        }
    }
}

