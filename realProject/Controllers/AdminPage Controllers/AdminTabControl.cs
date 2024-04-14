using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class AdminTabControl:TabControl
    {
        public System.Windows.Forms.TabPage createNewProgram { get; set; }
        public System.Windows.Forms.TabPage createNewCourse { get; set; }
        public System.Windows.Forms.TabPage setNewAdmin { get; set; }
        public System.Windows.Forms.ComboBox courseComboBox { get; set; }
        public System.Windows.Forms.Label courseLecturerLabel { get; set; }
        public System.Windows.Forms.TextBox courseNameTextBox { get; set; }
        public System.Windows.Forms.Label courseNameLabel { get; set; }
        public System.Windows.Forms.CheckedListBox courseCheckList { get; set; }
        public System.Windows.Forms.Label courseStudentsLabel { get; set; }
        public System.Windows.Forms.Button createCourseButton { get; set; }
        public Label addCourseLabel { get; set; }
        public Label programHeadLabel { get; set; }
        public Label programNameLabel { get; set; }
        public TextBox programNameTextBox { get; set; }
        public ComboBox programHeadCheckBox { get; set; }
        public CheckedListBox coursesList { get; set; }
        public Button createProgramButton { get; set; }
        public AddHeadPanel addHeadPanel { get; set; }

        public AdminTabControl()
        {
            this.createNewProgram = new System.Windows.Forms.TabPage();
            this.createNewCourse = new System.Windows.Forms.TabPage();
            this.setNewAdmin = new System.Windows.Forms.TabPage();
            this.createCourseButton = new System.Windows.Forms.Button();
            this.courseCheckList = new System.Windows.Forms.CheckedListBox();
            this.courseStudentsLabel = new System.Windows.Forms.Label();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.courseLecturerLabel = new System.Windows.Forms.Label();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.addCourseLabel = new System.Windows.Forms.Label();
            this.programHeadLabel = new System.Windows.Forms.Label();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.programNameTextBox = new System.Windows.Forms.TextBox();
            this.programHeadCheckBox = new System.Windows.Forms.ComboBox();
            this.coursesList = new System.Windows.Forms.CheckedListBox();
            this.createProgramButton = new System.Windows.Forms.Button();
            this.addHeadPanel = new AddHeadPanel();
            // 
            // tabControl
            // 
            this.Controls.Add(this.createNewProgram);
            this.Controls.Add(this.createNewCourse);
            this.Controls.Add(this.setNewAdmin);
            this.TabPages[0].BackColor = Color.LightSteelBlue;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "tabControl";
            this.SelectedIndex = 0;
            this.BackColor = Color.LightSteelBlue;
            this.Size = new System.Drawing.Size(982, 600);
            this.TabIndex = 7;
            // 
            // createNewProgram
            // 
            this.createNewProgram.Controls.Add(this.programHeadCheckBox);
            this.createNewProgram.Controls.Add(this.programHeadLabel);
            this.createNewProgram.Controls.Add(this.programNameLabel);
            this.createNewProgram.Controls.Add(this.programNameTextBox);
            this.createNewProgram.Controls.Add(this.createProgramButton);
            this.createNewProgram.Controls.Add(this.coursesList);
            this.createNewProgram.Controls.Add(this.addCourseLabel);
            this.createNewProgram.BorderStyle = BorderStyle.None;
            this.createNewProgram.Location = new System.Drawing.Point(4, 29);
            this.createNewProgram.Name = "createNewProgram";
            this.createNewProgram.BackColor = Color.LightSteelBlue;
            this.createNewProgram.Padding = new System.Windows.Forms.Padding(3);
            this.createNewProgram.Size = new System.Drawing.Size(974, 618);
            this.createNewProgram.TabIndex = 0;
            this.createNewProgram.Text = "Create new program";
            // 
            // setNewAdmin
            // 
            this.setNewAdmin.Controls.Add(addHeadPanel);
            this.setNewAdmin.Location = new System.Drawing.Point(4, 29);
            this.setNewAdmin.Name = "setNewHead";
            this.setNewAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.setNewAdmin.Size = new System.Drawing.Size(974, 618);
            this.setNewAdmin.TabIndex = 0;
            this.setNewAdmin.BackColor = Color.LightSteelBlue;
            this.setNewAdmin.Text = "Set new Head Department";
            // 
            // createNewCourse
            // 
            this.createNewCourse.Controls.Add(this.createCourseButton);
            this.createNewCourse.Controls.Add(this.courseCheckList);
            this.createNewCourse.Controls.Add(this.courseStudentsLabel);
            this.createNewCourse.Controls.Add(this.courseComboBox);
            this.createNewCourse.Controls.Add(this.courseLecturerLabel);
            this.createNewCourse.Controls.Add(this.courseNameTextBox);
            this.createNewCourse.Controls.Add(this.courseNameLabel);
            this.createNewCourse.Location = new System.Drawing.Point(4, 29);
            this.createNewCourse.Name = "createNewCourse";
            this.createNewCourse.BackColor = Color.LightSteelBlue;
            this.createNewCourse.Padding = new System.Windows.Forms.Padding(3);
            this.createNewCourse.Size = new System.Drawing.Size(974, 618);
            this.createNewCourse.TabIndex = 1;
            this.createNewCourse.Text = "Create new course";
            // 
            // addCourseLabel
            // 
            this.addCourseLabel.AutoSize = true;
            this.addCourseLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseLabel.Location = new System.Drawing.Point(520, 12);
            this.addCourseLabel.Name = "addCourseLabel";
            this.addCourseLabel.Size = new System.Drawing.Size(170, 34);
            this.addCourseLabel.TabIndex = 12;
            this.addCourseLabel.Text = "Add courses:";
            // 
            // programHeadLabel
            // 
            this.programHeadLabel.AutoSize = true;
            this.programHeadLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programHeadLabel.Location = new System.Drawing.Point(37, 123);
            this.programHeadLabel.Name = "programHeadLabel";
            this.programHeadLabel.Size = new System.Drawing.Size(189, 34);
            this.programHeadLabel.TabIndex = 13;
            this.programHeadLabel.Text = "Program head:";
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programNameLabel.Location = new System.Drawing.Point(37, 38);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(196, 34);
            this.programNameLabel.TabIndex = 14;
            this.programNameLabel.Text = "Program name:";
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.programNameTextBox.Location = new System.Drawing.Point(239, 42);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.Size = new System.Drawing.Size(239, 30);
            this.programNameTextBox.TabIndex = 15;
            // 
            // programHeadCheckBox
            // 
            this.programHeadCheckBox.FormattingEnabled = true;
            this.programHeadCheckBox.Location = new System.Drawing.Point(239, 129);
            this.programHeadCheckBox.Name = "programHeadCheckBox";
            this.programHeadCheckBox.Size = new System.Drawing.Size(163, 28);
            this.programHeadCheckBox.TabIndex = 16;
            // 
            // coursesList
            // 
            this.coursesList.FormattingEnabled = true;
            this.coursesList.Location = new System.Drawing.Point(526, 49);
            this.coursesList.Name = "coursesList";
            this.coursesList.Size = new System.Drawing.Size(310, 400);
            this.coursesList.TabIndex = 17;
            // 
            // createProgramButton
            // 
            this.createProgramButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.createProgramButton.FlatAppearance.BorderSize = 0;
            this.createProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProgramButton.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.createProgramButton.ForeColor = System.Drawing.Color.White;
            this.createProgramButton.Location = new System.Drawing.Point(43, 267);
            this.createProgramButton.Name = "createProgramButton";
            this.createProgramButton.Size = new System.Drawing.Size(190, 56);
            this.createProgramButton.TabIndex = 14;
            this.createProgramButton.Text = "Create program";
            this.createProgramButton.UseVisualStyleBackColor = false;
            // 
            // createCourseButton
            // 
            this.createCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.createCourseButton.FlatAppearance.BorderSize = 0;
            this.createCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCourseButton.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.createCourseButton.ForeColor = System.Drawing.Color.White;
            this.createCourseButton.Location = new System.Drawing.Point(69, 275);
            this.createCourseButton.Name = "createCourseButton";
            this.createCourseButton.Size = new System.Drawing.Size(167, 56);
            this.createCourseButton.TabIndex = 14;
            this.createCourseButton.Text = "Create course";
            this.createCourseButton.UseVisualStyleBackColor = false;
            // 
            // courseCheckList
            // 
            this.courseCheckList.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCheckList.FormattingEnabled = true;
            this.courseCheckList.Location = new System.Drawing.Point(591, 88);
            this.courseCheckList.Name = "courseCheckList";
            this.courseCheckList.Size = new System.Drawing.Size(268, 484);
            this.courseCheckList.TabIndex = 13;
            // 
            // courseStudentsLabel
            // 
            this.courseStudentsLabel.AutoSize = true;
            this.courseStudentsLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseStudentsLabel.Location = new System.Drawing.Point(585, 50);
            this.courseStudentsLabel.Name = "courseStudentsLabel";
            this.courseStudentsLabel.Size = new System.Drawing.Size(179, 34);
            this.courseStudentsLabel.TabIndex = 12;
            this.courseStudentsLabel.Text = "Add students:";
            // 
            // courseComboBox
            // 
            this.courseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(289, 185);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(214, 33);
            this.courseComboBox.TabIndex = 11;
            // 
            // courseLecturerLabel
            // 
            this.courseLecturerLabel.AutoSize = true;
            this.courseLecturerLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLecturerLabel.Location = new System.Drawing.Point(63, 182);
            this.courseLecturerLabel.Name = "courseLecturerLabel";
            this.courseLecturerLabel.Size = new System.Drawing.Size(220, 34);
            this.courseLecturerLabel.TabIndex = 10;
            this.courseLecturerLabel.Text = "Courses lecturer:";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.courseNameTextBox.Location = new System.Drawing.Point(261, 92);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(263, 30);
            this.courseNameTextBox.TabIndex = 9;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(63, 88);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(192, 34);
            this.courseNameLabel.TabIndex = 8;
            this.courseNameLabel.Text = "Courses name:";
        }
    }
}
