using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class MessagePanel:Panel
    {
        
        public System.Windows.Forms.RichTextBox messageContent { get; set; }
        public System.Windows.Forms.Label userName { get; set; }
        public System.Windows.Forms.Label fromLabel { get; set; }
        
        private System.Windows.Forms.Label contactLabel { get; set; }
        //private System.Windows.Forms.Label fromLabel { get; set; }
        public MessagePanel(realProject.Data_models.Message message)
        {
            this.contactLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
  
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(3, 41);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(75, 21);
            this.contactLabel.TabIndex = 1;
            this.contactLabel.Text = "Contact";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(3, 11);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(100, 21);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From:       ";
            // 
            // massagePanel
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.fromLabel);
            this.Location = new System.Drawing.Point(25, 60);
            this.Name = "massagePanel";
            this.Size = new System.Drawing.Size(476, 100);
            this.TabIndex = 0;
            
            this.fromLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.messageContent = new System.Windows.Forms.RichTextBox();

            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(0, 0);
            this.fromLabel.Name = "label1";
            this.fromLabel.Size = new System.Drawing.Size(45, 18);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(51, 0);
            this.userName.Name = "label2";
            this.userName.Size = new System.Drawing.Size(74, 18);
            this.userName.TabIndex = 4;
            // 
            // messageContent
            // 
            this.messageContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageContent.Location = new System.Drawing.Point(0, 21);
            this.messageContent.Name = "richTextBox1";
            this.messageContent.Size = new System.Drawing.Size(408, 100);
            this.messageContent.TabIndex = 5;
            this.messageContent.Enabled = false;
            // 
            // panel4
            // 
            this.Controls.Add(this.messageContent);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.userName);
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "panel4";
            this.Size = new System.Drawing.Size(408, 121);
            this.TabIndex = 0;
            
        }
    }
}
