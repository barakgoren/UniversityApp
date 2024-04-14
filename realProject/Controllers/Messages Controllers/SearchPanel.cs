using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class SearchPanel:Panel
    {
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private SortingButton sortingButton1;
        private List<InfoPanel> infoPanels;
        private SearchForUser searchBar;

        public SearchPanel()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.sortingButton1 = new SortingButton();
            this.infoPanels = new List<InfoPanel>();
            this.searchBar = new SearchForUser();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 109);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(463, 339);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Persons Lists";
            //panel
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sortingButton1 );
            this.Controls.Add(this.searchBar);
            this.Location = new System.Drawing.Point(1, 0);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(466, 449);
            this.TabIndex = 2;
        }

        public FlowLayoutPanel getFlowLayoutPanel() { return flowLayoutPanel1; }
        public SearchForUser getSearchBar() { return searchBar; }
        public SortingButton getSortingButton() { return sortingButton1;}
        public List<InfoPanel> getInfoPanels() { return infoPanels;}
    }
}
