using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class AdminPage:Panel
    {
        public AdminTabControl adminTabControl { get; set; }
        public InfoDisplay messagesDisplay { get; set; }
        public InfoDisplay coursesDisplay { get; set; }

        public AdminPage()
        {
            adminTabControl = new AdminTabControl();
            messagesDisplay = new InfoDisplay(0, 600);
            coursesDisplay = new InfoDisplay(460, 600);
            // 
            // panel1
            // 
            this.Location = new System.Drawing.Point(0, 0);
            this.Controls.Add(adminTabControl);
            this.Controls.Add(messagesDisplay);
            this.Controls.Add(coursesDisplay);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(1819, 1313);
            this.TabIndex = 2;
        }
        public List<Button> getAllButtons()
        {
            List<Button> buttons = new List<Button>();
            buttons.Add(adminTabControl.createCourseButton);
            buttons.Add(adminTabControl.createProgramButton);
            return buttons;
        }
    }
}
