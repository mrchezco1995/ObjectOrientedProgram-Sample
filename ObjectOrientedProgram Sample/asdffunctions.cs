using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedProgram_Sample
{
    public class asdffunctions
    {
        public static void messagepop()
        {
            MessageBox.Show("Hello World");
        }

        public static void Calcheight(String height)
        {
            MessageBox.Show("Your Height is " + height + " CM");
        }

        public static double ConvHeight(int cm)
        {
            double inch = cm * 0.393701;
            return inch;
        }
    }
}
