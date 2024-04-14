using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace realProject.My_Forms
{
    public class SearchForUser:Panel
    {

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        public SearchForUser()
        {

            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search User:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Location = new System.Drawing.Point(12, 42);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(223, 30);
            this.TabIndex = 5;
        }
        public TextBox getSearch() { return this.textBox1; }
    }
}
