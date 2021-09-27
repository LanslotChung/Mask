using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config
{
    public class CustomButton : Button
    {

        public CustomButton()
        {
            this.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            this.MouseEnter += CustomButton_MouseEnter;
            this.MouseLeave += CustomButton_MouseLeave;
        }

        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as CustomButton;
            button.ForeColor = Color.DeepSkyBlue;
        }

        private void CustomButton_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as CustomButton;
            button.ForeColor = Color.White;
        }
    }
}
