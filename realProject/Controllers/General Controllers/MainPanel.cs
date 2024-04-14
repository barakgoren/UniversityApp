using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class MainPanel:Panel
    {
        public MainPanel()
        {
            this.Location = new System.Drawing.Point(250, 0);
            this.Size = new System.Drawing.Size(1300, 900);
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TabIndex = 2;
        }
    }
}
