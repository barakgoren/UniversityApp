using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class AddHeadPanel:Panel
    {
        public System.Windows.Forms.Button button5{ get; set; }
        public Label lecturersLabel{ get; set; }
        public ComboBox lecturersComboBox{ get; set; }
        public Button addButton{ get; set; }
        public TextBox passwordTextBox{ get; set; }
        public Label passwordLabel{ get; set; }

        public AddHeadPanel()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.lecturersLabel = new System.Windows.Forms.Label();
            this.lecturersComboBox = new System.Windows.Forms.ComboBox();
            // 
            // Panel
            // 
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.lecturersLabel);
            this.Controls.Add(this.lecturersComboBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "panel1";
            this.BackColor = Color.LightSteelBlue;
            this.Size = new System.Drawing.Size(974, 618);
            this.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(128, 287);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(314, 38);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add as Head Department";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordTextBox.Location = new System.Drawing.Point(321, 191);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(176, 30);
            this.passwordTextBox.TabIndex = 16;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.passwordLabel.Location = new System.Drawing.Point(69, 190);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(247, 29);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Enter your password :";
            // 
            // lecturersLabel
            // 
            this.lecturersLabel.AutoSize = true;
            this.lecturersLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.lecturersLabel.Location = new System.Drawing.Point(69, 102);
            this.lecturersLabel.Name = "lecturersLabel";
            this.lecturersLabel.Size = new System.Drawing.Size(202, 29);
            this.lecturersLabel.TabIndex = 14;
            this.lecturersLabel.Text = "Choose Lecturer :";
            // 
            // lecturersComboBox
            // 
            this.lecturersComboBox.FormattingEnabled = true;
            this.lecturersComboBox.Location = new System.Drawing.Point(277, 103);
            this.lecturersComboBox.Name = "lecturersComboBox";
            this.lecturersComboBox.Size = new System.Drawing.Size(165, 28);
            this.lecturersComboBox.TabIndex = 0;
        }
    }
}
