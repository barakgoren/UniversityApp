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
    public class MainMessagesPage:Panel
    {

        public Button sendButton { get; set; }
        public Button MessageBySearch { get; set; }
        public Label messagesPanelLabel { get; set; }
        public TabControl tabControl1 { get; set; }
        public TabPage tabPage1 { get; set; }
        public TabPage tabPage2 { get; set; }
        public Label savedMessagesLabel { get; set; }
        public FlowLayoutPanel savedMessagesFlow { get; set; }
        public Label allMessagesLabel { get; set; }
        public FlowLayoutPanel allMessagesFlow { get; set; }
        public ComboBox comboBox1 { get; set; }
        public RichTextBox contentTextBox { get; set; }
        public Label sendMessageLabel { get; set; }
        public TextBox subjectTextBox { get; set; }
        public Label subjectLabel { get; set; }
        public TextBox toTextBox { get; set; }
        public Label toLabel { get; set; }

        public MainMessagesPage()
        {
            this.MessageBySearch = new Button();
            this.messagesPanelLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.savedMessagesLabel = new System.Windows.Forms.Label();
            this.savedMessagesFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.allMessagesLabel = new System.Windows.Forms.Label();
            this.allMessagesFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.sendMessageLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            
            //
            this.MessageBySearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MessageBySearch.FlatAppearance.BorderSize = 0;
            this.MessageBySearch.Image = Resources.search;
            this.MessageBySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageBySearch.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.MessageBySearch.ForeColor = System.Drawing.Color.White;
            this.MessageBySearch.Location = new System.Drawing.Point(900, 5);
            this.MessageBySearch.Name = "sendButton";
            this.MessageBySearch.Size = new System.Drawing.Size(70, 70);
            this.MessageBySearch.TabIndex = 14;
            this.MessageBySearch.UseVisualStyleBackColor = false;
            // 
            // mainMessagesPanel
            // 
            this.Controls.Add(this.MessageBySearch);
            this.Controls.Add(this.messagesPanelLabel);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "mainMessagesPanel";
            this.Size = new System.Drawing.Size(1348, 938);
            this.TabIndex = 2;
            // 
            // messagesPanelLabel
            // 
            this.messagesPanelLabel.AutoSize = true;
            this.messagesPanelLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesPanelLabel.Location = new System.Drawing.Point(0, 0);
            this.messagesPanelLabel.Name = "messagesPanelLabel";
            this.messagesPanelLabel.Size = new System.Drawing.Size(256, 42);
            this.messagesPanelLabel.TabIndex = 0;
            this.messagesPanelLabel.Text = "Message menu";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 795);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.savedMessagesLabel);
            this.tabPage1.Controls.Add(this.savedMessagesFlow);
            this.tabPage1.Controls.Add(this.allMessagesLabel);
            this.tabPage1.Controls.Add(this.allMessagesFlow);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1340, 850);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Messages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 34);
            this.comboBox1.TabIndex = 4;
            // 
            // savedMessagesLabel
            // 
            this.savedMessagesLabel.AutoSize = true;
            this.savedMessagesLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedMessagesLabel.Location = new System.Drawing.Point(450, 63);
            this.savedMessagesLabel.Name = "savedMessagesLabel";
            this.savedMessagesLabel.Size = new System.Drawing.Size(246, 36);
            this.savedMessagesLabel.TabIndex = 3;
            this.savedMessagesLabel.Text = "Saved messages";
            // 
            // savedMessagesFlow
            // 
            this.savedMessagesFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savedMessagesFlow.Location = new System.Drawing.Point(450, 104);
            this.savedMessagesFlow.Name = "savedMessagesFlow";
            this.savedMessagesFlow.AutoScroll = true;
            this.savedMessagesFlow.Size = new System.Drawing.Size(400, 500);
            this.savedMessagesFlow.TabIndex = 2;
            // 
            // allMessagesLabel
            // 
            this.allMessagesLabel.AutoSize = true;
            this.allMessagesLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allMessagesLabel.Location = new System.Drawing.Point(-6, 65);
            this.allMessagesLabel.Name = "allMessagesLabel";
            this.allMessagesLabel.Size = new System.Drawing.Size(196, 36);
            this.allMessagesLabel.TabIndex = 1;
            this.allMessagesLabel.Text = "All messages";
            // 
            // allMessagesFlow
            // 
            this.allMessagesFlow.AutoScroll = true;
            this.allMessagesFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allMessagesFlow.Location = new System.Drawing.Point(0, 104);
            this.allMessagesFlow.Name = "allMessagesFlow";
            this.allMessagesFlow.Size = new System.Drawing.Size(400, 500);
            this.allMessagesFlow.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.contentTextBox);
            this.tabPage2.Controls.Add(this.sendMessageLabel);
            this.tabPage2.Controls.Add(this.subjectTextBox);
            this.tabPage2.Controls.Add(this.subjectLabel);
            this.tabPage2.Controls.Add(this.toTextBox);
            this.tabPage2.Controls.Add(this.toLabel);
            this.tabPage2.Controls.Add(this.sendButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1340, 850);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Send message";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contentTextBox
            // 
            this.contentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentTextBox.Location = new System.Drawing.Point(60, 233);
            this.contentTextBox.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(650, 400);
            this.contentTextBox.TabIndex = 20;
            this.contentTextBox.Text = "";
            // 
            // sendMessageLabel
            // 
            this.sendMessageLabel.AutoSize = true;
            this.sendMessageLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageLabel.Location = new System.Drawing.Point(53, 188);
            this.sendMessageLabel.Name = "sendMessageLabel";
            this.sendMessageLabel.Size = new System.Drawing.Size(168, 42);
            this.sendMessageLabel.TabIndex = 19;
            this.sendMessageLabel.Text = "Message:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.subjectTextBox.Location = new System.Drawing.Point(200, 109);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(448, 35);
            this.subjectTextBox.TabIndex = 18;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(53, 103);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(148, 42);
            this.subjectLabel.TabIndex = 17;
            this.subjectLabel.Text = "Subject:";
            // 
            // toTextBox
            // 
            this.toTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toTextBox.Location = new System.Drawing.Point(124, 43);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(285, 35);
            this.toTextBox.TabIndex = 16;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(53, 37);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(65, 42);
            this.toLabel.TabIndex = 15;
            this.toLabel.Text = "To:";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(800, 600);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(142, 56);
            this.sendButton.TabIndex = 14;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
        }
    }
}
