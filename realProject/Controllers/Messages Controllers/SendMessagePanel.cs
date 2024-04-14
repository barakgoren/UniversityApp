using realProject.Data_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class SendMessagePanel:Panel
    {
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button sendButton;
        private Person destination;
        public SendMessagePanel(Person destination)
        {
            this.destination = destination;
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.SuspendLayout();

            // 
            // 
            // 
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.backButton);
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "";
            this.Size = new System.Drawing.Size(339, 394);
            this.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 1;
            // Display just the first name
            string[] destinationAtt = destination.getName().Split(' ');
            this.label1.Text = $"Send message to {destinationAtt[0]}:";
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::realProject.Properties.Resources.arrows;
            this.backButton.Location = new System.Drawing.Point(1, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(28, 29);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(this.Width-25, 300);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // sendButton
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(80, 350);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(167, 29);
            this.sendButton.TabIndex = 14;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = false;
        }
        public Button getBackButton() { return this.backButton; }  
        public Button getSendButton() { return this.sendButton; }
        public Person getDestination() { return this.destination; }
        public RichTextBox getContent() { return  this.richTextBox1; }
    }
}
