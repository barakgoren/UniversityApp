using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class MainMessagePanel:Panel
    {
        public RichTextBox messageTextBox { get; set; }
        public Label messageFromLabel { get; set; }
        public CheckBox isImportant { get; set; }

        public MainMessagePanel(realProject.Data_models.Message message)
        {
            this.messageTextBox = new RichTextBox();
            this.messageFromLabel = new Label();
            this.isImportant = new CheckBox();
            // 
            // panel1
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.isImportant);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageFromLabel);
            this.Location = new System.Drawing.Point(249, 319);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(643, 242);
            this.TabIndex = 0;
            // 
            // messageFromLabel
            // 
            this.messageFromLabel.AutoSize = true;
            this.messageFromLabel.Location = new System.Drawing.Point(43, 25);
            this.messageFromLabel.Name = "messageFromLabel";
            this.messageFromLabel.Size = new System.Drawing.Size(51, 20);
            this.messageFromLabel.TabIndex = 0;
            this.messageFromLabel.Text = "From: " + message.Sender;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(47, 55);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(556, 152);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Text = message.Content;
            // 
            // isImportant
            // 
            this.isImportant.AutoSize = true;
            this.isImportant.Location = new System.Drawing.Point(490, 25);
            this.isImportant.Name = "isImportant";
            this.isImportant.Size = new System.Drawing.Size(113, 24);
            this.isImportant.TabIndex = 2;
            this.isImportant.Text = "Save message";
            this.isImportant.UseVisualStyleBackColor = true;
            this.isImportant.Tag = message;
        }
    }
}
