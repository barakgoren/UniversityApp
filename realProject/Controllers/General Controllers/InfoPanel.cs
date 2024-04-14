using realProject.Data_models;
using realProject.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class InfoPanel:Panel
    {

        public System.Windows.Forms.Label typeLabel{ get; set; }
        public System.Windows.Forms.RichTextBox facultyTextBox{ get; set; }
        public System.Windows.Forms.RichTextBox ageTextBox{ get; set; }
        public System.Windows.Forms.RichTextBox nameTextBox{ get; set; }
        public System.Windows.Forms.RichTextBox idTextBox{ get; set; }
        public System.Windows.Forms.Label facultyLabel{ get; set; }
        public System.Windows.Forms.Label ageLabel{ get; set; }
        public System.Windows.Forms.Label nameLabel{ get; set; }
        public System.Windows.Forms.Label idLabel{ get; set; }
        public System.Windows.Forms.Button sendMessage{ get; set; }

        public InfoPanel()
        {
            this.typeLabel = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.RichTextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.ageTextBox = new System.Windows.Forms.RichTextBox();
            this.facultyTextBox = new System.Windows.Forms.RichTextBox();
            this.sendMessage = new System.Windows.Forms.Button();
            
           
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 31);
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(35, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 57);
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(6, 90);
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(35, 13);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Location = new System.Drawing.Point(285, 31);
            this.facultyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyLabel.Name = "facultyOrSubjectLabel";
            this.facultyLabel.Size = new System.Drawing.Size(35, 13);
            this.facultyLabel.TabIndex = 3;
            this.facultyLabel.Text = "Faculty:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(47, 29);
            this.idTextBox.BorderStyle = BorderStyle.None;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 21);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.Text = "";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(47, 54);
            this.nameTextBox.BorderStyle = BorderStyle.None;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.Text = "";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(47, 87);
            this.ageTextBox.BorderStyle = BorderStyle.None;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(34, 21);
            this.ageTextBox.TabIndex = 6;
            this.ageTextBox.Text = "";
            // 
            // facultyTextBox
            // 
            this.facultyTextBox.Location = new System.Drawing.Point(330, 28);
            this.facultyTextBox.BorderStyle = BorderStyle.None;
            this.facultyTextBox.Name = "facultyTextBox";
            this.facultyTextBox.Size = new System.Drawing.Size(100, 21);
            this.facultyTextBox.TabIndex = 7;
            this.facultyTextBox.Text = "";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(201, 10);
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(35, 13);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "typeLabel";
            // sendMessage
            this.sendMessage.FlatAppearance.BorderSize = 0;
            this.sendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMessage.Image = Image.FromFile("..\\..\\email.png");
            this.sendMessage.Location = new System.Drawing.Point(285, 61);
            this.sendMessage.Name = "button6";
            this.sendMessage.Size = new System.Drawing.Size(39, 31);
            this.sendMessage.TabIndex = 9;
            this.sendMessage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.facultyTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.BorderStyle = BorderStyle.None;
            this.Location = new System.Drawing.Point();
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(440, 114);
            this.TabIndex = 0;
        }

        public void display(Person person)
        {
            if(person.GetType().Name == typeof(Student).Name)
            {
                Student student = (Student)person;
                idTextBox.Text = student.getId().ToString();
                nameTextBox.Text = student.getName();
                ageTextBox.Text = student.getAge().ToString();
                idTextBox.Enabled = false;
                nameTextBox.Enabled = false;
                ageTextBox.Enabled = false;
                facultyTextBox.Enabled = false;
                typeLabel.Text = "Student";
                this.sendMessage.Tag = person.getId();
                this.BackColor = System.Drawing.Color.FromArgb(0,191,255);
            }
            if(person.GetType().Name == typeof(Lecturer).Name) 
            {
                Lecturer lecturer = (Lecturer)person;
                idTextBox.Text = lecturer.getId().ToString();
                nameTextBox.Text = lecturer.getName();
                ageTextBox.Text = lecturer.getAge().ToString();
                facultyTextBox.Text = lecturer.getSubject();
                idTextBox.Enabled=false;
                nameTextBox.Enabled=false;
                ageTextBox.Enabled=false;
                facultyTextBox.Enabled=false;
                typeLabel.Text = "Lecturer";
                this.sendMessage.Tag = person.getId();
                this.BackColor = System.Drawing.Color.FromArgb(0,149,200);

            }

        }
        public Button getSendMessage()
        {
            return this.sendMessage;
        }
        public void setWidth(int width)
        {
            this.Width += width;
            this.typeLabel.Location = new System.Drawing.Point((this.typeLabel.Location.X + width)/2, this.typeLabel.Location.Y);
            this.facultyTextBox.Location = new System.Drawing.Point(this.facultyTextBox.Location.X + width, this.facultyTextBox.Location.Y);
            this.facultyLabel.Location = new System.Drawing.Point(this.facultyLabel.Location.X + width, this.facultyLabel.Location.Y);
        }
    }
}
