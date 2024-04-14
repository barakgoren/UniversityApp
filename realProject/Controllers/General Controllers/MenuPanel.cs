using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class MenuPanel:Panel
    {
        private System.Windows.Forms.Panel userDisplayPanel;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.Label typeDisplay;
        private System.Windows.Forms.Label nameDisplay;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Button messagesButton;
        private System.Windows.Forms.Button coursesButton;
        private System.Windows.Forms.Button adminButton;


        public MenuPanel()
        {
            this.userDisplayPanel = new System.Windows.Forms.Panel();
            this.typeDisplay = new System.Windows.Forms.Label();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.nameDisplay = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.Button();
            this.myProfileButton = new System.Windows.Forms.Button();
            this.messagesButton = new System.Windows.Forms.Button();
            this.coursesButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.myProfileButton);
            this.Controls.Add(this.messagesButton);
            this.Controls.Add(this.coursesButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.userDisplayPanel);
            this.Dock = System.Windows.Forms.DockStyle.Left;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPanel";
            this.Size = new System.Drawing.Size(250, 1285);
            this.TabIndex = 0;
            // 
            // adminButton
            // 
            this.adminButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Image = global::realProject.Properties.Resources.manager;
            this.adminButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminButton.Location = new System.Drawing.Point(0, 533);
            this.adminButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(322, 77);
            this.adminButton.TabIndex = 5;
            this.adminButton.Text = "  Admin Panel";
            this.adminButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adminButton.UseVisualStyleBackColor = true;
            // 
            // myProfileButton
            // 
            this.myProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myProfileButton.FlatAppearance.BorderSize = 0;
            this.myProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfileButton.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myProfileButton.ForeColor = System.Drawing.Color.Black;
            this.myProfileButton.Image = global::realProject.Properties.Resources.myprofile;
            this.myProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myProfileButton.Location = new System.Drawing.Point(0, 446);
            this.myProfileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(322, 77);
            this.myProfileButton.TabIndex = 4;
            this.myProfileButton.Text = "  Settings";
            this.myProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.myProfileButton.UseVisualStyleBackColor = true;
            // 
            // messagesButton
            // 
            this.messagesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.messagesButton.FlatAppearance.BorderSize = 0;
            this.messagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messagesButton.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesButton.ForeColor = System.Drawing.Color.Black;
            this.messagesButton.Image = global::realProject.Properties.Resources.email;
            this.messagesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messagesButton.Location = new System.Drawing.Point(0, 354);
            this.messagesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messagesButton.Name = "messagesButton";
            this.messagesButton.Size = new System.Drawing.Size(322, 77);
            this.messagesButton.TabIndex = 3;
            this.messagesButton.Text = "  Messages";
            this.messagesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messagesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.messagesButton.UseVisualStyleBackColor = true;
            // 
            // coursesButton
            // 
            this.coursesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.coursesButton.FlatAppearance.BorderSize = 0;
            this.coursesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursesButton.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesButton.ForeColor = System.Drawing.Color.Black;
            this.coursesButton.Image = global::realProject.Properties.Resources.courses;
            this.coursesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coursesButton.Location = new System.Drawing.Point(0, 262);
            this.coursesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coursesButton.Name = "coursesButton";
            this.coursesButton.Size = new System.Drawing.Size(322, 77);
            this.coursesButton.TabIndex = 2;
            this.coursesButton.Text = "  Courses";
            this.coursesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coursesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.coursesButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Black;
            this.homeButton.Image = global::realProject.Properties.Resources.home;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 169);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(322, 77);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "  Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // userDisplayPanel
            // 
            this.userDisplayPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.userDisplayPanel.Controls.Add(this.typeDisplay);
            this.userDisplayPanel.Controls.Add(this.userPic);
            this.userDisplayPanel.Controls.Add(this.nameDisplay);
            this.userDisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.userDisplayPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userDisplayPanel.Name = "userDisplayPanel";
            this.userDisplayPanel.Size = new System.Drawing.Size(322, 154);
            this.userDisplayPanel.TabIndex = 0;
            // 
            // typeDisplay
            // 
            this.typeDisplay.AutoSize = true;
            this.typeDisplay.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeDisplay.Location = new System.Drawing.Point(120, 78);
            this.typeDisplay.Name = "typeDisplay";
            this.typeDisplay.Size = new System.Drawing.Size(56, 26);
            this.typeDisplay.TabIndex = 2;
            this.typeDisplay.Text = "Type";
            // 
            // userPic
            // 
            this.userPic.Location = new System.Drawing.Point(15, 29);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(110, 80);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPic.TabIndex = 1;
            this.userPic.TabStop = false;
            // 
            // nameDisplay
            // 
            this.nameDisplay.AutoSize = true;
            this.nameDisplay.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplay.Location = new System.Drawing.Point(120, 50);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.Size = new System.Drawing.Size(88, 34);
            this.nameDisplay.TabIndex = 0;
            this.nameDisplay.Text = "Name";
        }
        public Button getHomeButton() { return  this.homeButton; }
        public Button getAdminButton() { return this.adminButton; }
        public Button getAssesmentsButton() { return this.messagesButton;}
        public Button getProfileButton() { return this.myProfileButton; }
        public Button getCoursesButton() { return this.coursesButton;}
        public Label getNameLabel() { return this.nameDisplay; }
        public Label getTypeLabel() { return this.typeDisplay; }
        public PictureBox getPictureBox() { return this.userPic; }
        
    }
}
