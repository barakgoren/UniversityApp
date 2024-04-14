using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realProject.Data_models
{
    public class ThemeColor
    {
        public System.Drawing.Color mainColor { get; set; }
        public static System.Drawing.Color secondaryColor { get; set; }
        public static System.Drawing.Color thirdColor { get; set; }
        public static System.Drawing.Color buttonsColor { get; set; }

        public ThemeColor() 
        {
            this.mainColor = System.Drawing.Color.AliceBlue;
        }

    }
}
