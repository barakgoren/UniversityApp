using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class CourseInfoPanel:Panel
    {
        public realProject.Data_models.Course Course { get; set; }
        public System.Windows.Forms.Label courseLabel { get; set; }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label rateLabel { get; set; }
        public System.Windows.Forms.ComboBox rateBox { get; set; }
        public System.Windows.Forms.Button sendRate { get; set; }
        public CourseInfoPanel(realProject.Data_models.Course course)
        {
            this.Course = course;
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.ComboBox();
            this.sendRate = new System.Windows.Forms.Button();
            //SendRateButton
            this.sendRate.Location = new System.Drawing.Point(460, 115);
            this.sendRate.Name = "sendRate";
            this.sendRate.Size = new System.Drawing.Size(40, 23);
            this.sendRate.TabIndex = 0;
            this.sendRate.Text = "Send";
            this.sendRate.UseVisualStyleBackColor = true;
            this.sendRate.Tag = this;
            // 
            // comboBox1
            // 
            this.rateBox.FormattingEnabled = true;
            this.rateBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rateBox.Location = new System.Drawing.Point(380, 117);
            this.rateBox.Name = "comboBox1";
            this.rateBox.Size = new System.Drawing.Size(70, 28);
            this.rateBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lecturer: " + course.getCourseLecturer().getName() +"   "+ course.getCourseLecturer().getRate();
            //rateLabel
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(280, 117);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(95, 26);
            this.rateLabel.TabIndex = 2;
            this.rateLabel.Text = "Rate Lecturer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name: " + course.getName();
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(124, 0);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(100, 34);
            this.courseLabel.TabIndex = 0;
            this.courseLabel.Text = "Course";
            //Panel
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.sendRate);
            this.Location = new System.Drawing.Point(409, 498);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Name = "panel3";
            this.Size = new System.Drawing.Size(390, 159);
            this.TabIndex = 5;
        }
    }
}
