using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class CoursesPage:System.Windows.Forms.Panel
    {
        public Label programCoursesLabel{ get; set; }
        public FlowLayoutPanel otherCoursesFlow{ get; set; }
        public FlowLayoutPanel programCoursesFlow{ get; set; }
        public Label otherCoursesLabel{ get; set; }
        public Label coursesPageLabel{ get; set; }

        public CoursesPage()
        {
            this.programCoursesFlow = new FlowLayoutPanel();
            this.otherCoursesFlow = new FlowLayoutPanel();
            this.programCoursesLabel = new Label();
            this.otherCoursesLabel = new Label();
            this.coursesPageLabel = new Label();
            // 
            // panel1
            // 
            this.Controls.Add(this.otherCoursesFlow);
            this.Controls.Add(this.programCoursesFlow);
            this.Controls.Add(this.otherCoursesLabel);
            this.Controls.Add(this.programCoursesLabel);
            this.Controls.Add(this.coursesPageLabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(1300, 900);
            this.TabIndex = 0;
            // 
            // programCoursesLabel
            // 
            this.programCoursesLabel.AutoSize = true;
            this.programCoursesLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programCoursesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.programCoursesLabel.Location = new System.Drawing.Point(199, 144);
            this.programCoursesLabel.Name = "programCoursesLabel";
            this.programCoursesLabel.Size = new System.Drawing.Size(261, 43);
            this.programCoursesLabel.TabIndex = 11;
            this.programCoursesLabel.Text = "Program courses";
            // 
            // coursesPageLabel
            // 
            this.coursesPageLabel.AutoSize = true;
            this.coursesPageLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesPageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.coursesPageLabel.Location = new System.Drawing.Point(3, 0);
            this.coursesPageLabel.Name = "coursesPageLabel";
            this.coursesPageLabel.Size = new System.Drawing.Size(254, 53);
            this.coursesPageLabel.TabIndex = 12;
            this.coursesPageLabel.Text = "Courses Page";
            // 
            // programCoursesFlow
            // 
            this.programCoursesFlow.BackColor = System.Drawing.Color.AliceBlue;
            this.programCoursesFlow.Location = new System.Drawing.Point(207, 190);
            this.programCoursesFlow.Name = "programCoursesFlow";
            this.programCoursesFlow.AutoScroll = true;
            this.programCoursesFlow.Size = new System.Drawing.Size(838, 291);
            this.programCoursesFlow.TabIndex = 13;
            // 
            // otherCoursesFlow
            // 
            this.otherCoursesFlow.BackColor = System.Drawing.Color.AliceBlue;
            this.otherCoursesFlow.Location = new System.Drawing.Point(207, 544);
            this.otherCoursesFlow.Name = "otherCoursesFlow";
            this.otherCoursesFlow.AutoScroll = true;
            this.otherCoursesFlow.Size = new System.Drawing.Size(838, 291);
            this.otherCoursesFlow.TabIndex = 15;
            // 
            // otherCoursesLabel
            // 
            this.otherCoursesLabel.AutoSize = true;
            this.otherCoursesLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherCoursesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.otherCoursesLabel.Location = new System.Drawing.Point(199, 498);
            this.otherCoursesLabel.Name = "otherCoursesLabel";
            this.otherCoursesLabel.Size = new System.Drawing.Size(218, 43);
            this.otherCoursesLabel.TabIndex = 14;
            this.otherCoursesLabel.Text = "Other courses";
        }
    }
}
