using realProject.Data_models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class HomePage : Panel
    {
        public Panel panel5{ get; set; }
        public Label statusLabel{ get; set; }
        public Label idLabel{ get; set; }
        public Label nameLabel{ get; set; }
        public Label programLabel{ get; set; }
        public Panel panel6{ get; set; }
        public Label programDisplay{ get; set; }
        public Label statusDisplay{ get; set; }
        public Label nameDisplay{ get; set; }
        public Label idDisplay{ get; set; }
        public Panel timePanel{ get; set; }
        public Label homePageLabel{ get; set; }
        public Label watchLabel{ get; set; }
        public Label label12{ get; set; }
        public Label dateLabel{ get; set; }
        public Label coursesLabel{ get; set; }
        public FlowLayoutPanel coursesFlow{ get; set; }
        public FlowLayoutPanel messagesFlow{ get; set; }
        public Label messagesLabel{ get; set; }
        public PictureBox pictureBox1{ get; set; }
        public HomePage()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.programLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.programDisplay = new System.Windows.Forms.Label();
            this.statusDisplay = new System.Windows.Forms.Label();
            this.nameDisplay = new System.Windows.Forms.Label();
            this.idDisplay = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.watchLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.homePageLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.messagesLabel = new System.Windows.Forms.Label();
            this.messagesFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.coursesFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.timePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.statusLabel);
            this.panel5.Controls.Add(this.idLabel);
            this.panel5.Controls.Add(this.nameLabel);
            this.panel5.Controls.Add(this.programLabel);
            this.panel5.Location = new System.Drawing.Point(418, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 310);
            this.panel5.TabIndex = 10;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(3, 175);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(129, 42);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(3, 5);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(64, 42);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 86);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(186, 42);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Full Name:";
            // 
            // programLabel
            // 
            this.programLabel.AutoSize = true;
            this.programLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLabel.Location = new System.Drawing.Point(3, 266);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(162, 42);
            this.programLabel.TabIndex = 7;
            this.programLabel.Text = "Program:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.programDisplay);
            this.panel6.Controls.Add(this.statusDisplay);
            this.panel6.Controls.Add(this.nameDisplay);
            this.panel6.Controls.Add(this.idDisplay);
            this.panel6.Location = new System.Drawing.Point(616, 69);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(605, 310);
            this.panel6.TabIndex = 11;
            // 
            // programDisplay
            // 
            this.programDisplay.AutoSize = true;
            this.programDisplay.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programDisplay.ForeColor = System.Drawing.Color.Teal;
            this.programDisplay.Location = new System.Drawing.Point(3, 269);
            this.programDisplay.Name = "programDisplay";
            this.programDisplay.Size = new System.Drawing.Size(209, 39);
            this.programDisplay.TabIndex = 11;
            this.programDisplay.Text = "User Program";
            // 
            // statusDisplay
            // 
            this.statusDisplay.AutoSize = true;
            this.statusDisplay.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDisplay.ForeColor = System.Drawing.Color.Teal;
            this.statusDisplay.Location = new System.Drawing.Point(3, 175);
            this.statusDisplay.Name = "statusDisplay";
            this.statusDisplay.Size = new System.Drawing.Size(181, 39);
            this.statusDisplay.TabIndex = 10;
            this.statusDisplay.Text = "User Status";
            // 
            // nameDisplay
            // 
            this.nameDisplay.AutoSize = true;
            this.nameDisplay.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplay.ForeColor = System.Drawing.Color.Teal;
            this.nameDisplay.Location = new System.Drawing.Point(3, 86);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.Size = new System.Drawing.Size(232, 39);
            this.nameDisplay.TabIndex = 9;
            this.nameDisplay.Text = "User Full Name";
            // 
            // idDisplay
            // 
            this.idDisplay.AutoSize = true;
            this.idDisplay.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDisplay.ForeColor = System.Drawing.Color.Teal;
            this.idDisplay.Location = new System.Drawing.Point(3, 5);
            this.idDisplay.Name = "idDisplay";
            this.idDisplay.Size = new System.Drawing.Size(122, 39);
            this.idDisplay.TabIndex = 8;
            this.idDisplay.Text = "User ID";
            // 
            // timePanel
            // 
            this.timePanel.Controls.Add(this.watchLabel);
            this.timePanel.Controls.Add(this.label12);
            this.timePanel.Controls.Add(this.dateLabel);
            this.timePanel.Location = new System.Drawing.Point(1005, 3);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(292, 60);
            this.timePanel.TabIndex = 12;
            // 
            // watchLabel
            // 
            this.watchLabel.AutoSize = true;
            this.watchLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchLabel.Location = new System.Drawing.Point(1, 18);
            this.watchLabel.Name = "watchLabel";
            this.watchLabel.Size = new System.Drawing.Size(116, 26);
            this.watchLabel.TabIndex = 2;
            this.watchLabel.Text = "HH:mm:ss";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(123, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 52);
            this.label12.TabIndex = 3;
            this.label12.Text = "|";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(167, 18);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(120, 26);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "dd/MM/yy";
            // 
            // homePageLabel
            // 
            this.homePageLabel.AutoSize = true;
            this.homePageLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageLabel.Location = new System.Drawing.Point(3, 3);
            this.homePageLabel.Name = "homePageLabel";
            this.homePageLabel.Size = new System.Drawing.Size(198, 42);
            this.homePageLabel.TabIndex = 9;
            this.homePageLabel.Text = "Home Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Size = new System.Drawing.Size(345, 310);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // messagesLabel
            // 
            this.messagesLabel.AutoSize = true;
            this.messagesLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesLabel.Location = new System.Drawing.Point(60, 418);
            this.messagesLabel.Name = "messagesLabel";
            this.messagesLabel.Size = new System.Drawing.Size(175, 42);
            this.messagesLabel.TabIndex = 14;
            this.messagesLabel.Text = "Messages";
            // 
            // messagesFlow
            // 
            this.messagesFlow.Location = new System.Drawing.Point(67, 463);
            this.messagesFlow.Name = "messagesFlow";
            this.messagesFlow.AutoScroll = true;
            this.messagesFlow.BackColor = System.Drawing.Color.AliceBlue;
            this.messagesFlow.Size = new System.Drawing.Size(546, 350);
            this.messagesFlow.TabIndex = 15;
            // 
            // coursesFlow
            // 
            this.coursesFlow.Location = new System.Drawing.Point(675, 463);
            this.coursesFlow.Name = "coursesFlow";
            this.coursesFlow.AutoScroll = true;
            this.coursesFlow.BackColor = System.Drawing.Color.AliceBlue;
            this.coursesFlow.Size = new System.Drawing.Size(546, 350);
            this.coursesFlow.TabIndex = 16;
            // 
            // coursesLabel
            // 
            this.coursesLabel.AutoSize = true;
            this.coursesLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesLabel.Location = new System.Drawing.Point(668, 418);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(146, 42);
            this.coursesLabel.TabIndex = 17;
            this.coursesLabel.Text = "Courses";
            // 
            // MainPanel
            // 
            this.Controls.Add(this.coursesLabel);
            this.Controls.Add(this.coursesFlow);
            this.Controls.Add(this.messagesFlow);
            this.Controls.Add(this.messagesLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.homePageLabel);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(1300, 900);
            this.TabIndex = 13;
        }
        public void displayUser(Person person)
        {
            try
            {
                this.pictureBox1.Image = Image.FromFile(person.getPic());
            } catch(Exception ex)
            {
                Console.WriteLine("user has no profile pic");
            }
            
            this.nameDisplay.Text = person.getName();
            this.idDisplay.Text = person.getId();
            this.statusDisplay.Text = person.GetType().Name;
            if (person.GetType().Name.Equals("Student"))
            {
                Student enteredStudent = (Student)person;
                if(enteredStudent.getProgram() == null)
                {
                    this.programDisplay.Text = "No program";
                } else
                {
                    this.programDisplay.Text = enteredStudent.getProgram().getName();
                }
                
            }

        }
        
        
    }
    }
