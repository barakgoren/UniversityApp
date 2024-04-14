using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class InfoDisplay:Panel
    {
        public System.Windows.Forms.FlowLayoutPanel infoFlow { get; set; }
        public Label infoLabel { get; set; }
        
        public InfoDisplay(int x, int y)
        {
            this.infoFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoFlow
            // 
            this.infoFlow.AutoScroll = true;
            this.infoFlow.BackColor = System.Drawing.Color.AliceBlue;
            this.infoFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoFlow.Location = new System.Drawing.Point(9, 29);
            this.infoFlow.Name = "infoFlow";
            this.infoFlow.Size = new System.Drawing.Size(440, 200);
            this.infoFlow.TabIndex = 6;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(4, 0);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(48, 26);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = "Info";
            // 
            // InfoDisplay
            // 
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoFlow);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(x, y);
            this.Name = "InfoDisplay";
            this.Size = new System.Drawing.Size(460, 250);
            this.TabIndex = 8;
        }
    }
}
