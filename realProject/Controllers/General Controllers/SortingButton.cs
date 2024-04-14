using realProject.Data_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject.My_Forms
{
    public class SortingButton:Panel
    {
        private System.Windows.Forms.Button sortById;
        private System.Windows.Forms.Button sortByAge;
        private System.Windows.Forms.Button sortByType;

        public SortingButton()
        {
            this.sortById = new System.Windows.Forms.Button();
            this.sortByAge = new System.Windows.Forms.Button();
            this.sortByType = new System.Windows.Forms.Button();

            // 
            // sortById
            // 
            this.sortById.Location = new System.Drawing.Point(0, 0);
            this.sortById.Name = "sortById";
            this.sortById.Size = new System.Drawing.Size(75, 23);
            this.sortById.TabIndex = 2;
            this.sortById.Text = "Sort by id";
            this.sortById.UseVisualStyleBackColor = true;
            // 
            // sortByAge
            // 
            this.sortByAge.Location = new System.Drawing.Point(180, 0);
            this.sortByAge.Name = "sortByAge";
            this.sortByAge.Size = new System.Drawing.Size(75, 23);
            this.sortByAge.TabIndex = 3;
            this.sortByAge.Text = "Sort by age";
            this.sortByAge.UseVisualStyleBackColor = true;
            // 
            // sortByType
            // 
            this.sortByType.Location = new System.Drawing.Point(359, 0);
            this.sortByType.Name = "sortByType";
            this.sortByType.Size = new System.Drawing.Size(75, 23);
            this.sortByType.TabIndex = 4;
            this.sortByType.Text = "Sort by type";
            this.sortByType.UseVisualStyleBackColor = true;
            //panel
            this.Location = new System.Drawing.Point(12, 82);
            this.Controls.Add(this.sortByType);
            this.Controls.Add(this.sortByAge);
            this.Controls.Add(this.sortById);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(443, 26);
            this.TabIndex = 2;

        }

        public Button getSortById()
        {
            return this.sortById;
        }

        public Button getSortByAge()
        {
            return this.sortByAge;
        }

        public Button getSortByType() 
        {
            return this.sortByType; 
        }

    }
}
