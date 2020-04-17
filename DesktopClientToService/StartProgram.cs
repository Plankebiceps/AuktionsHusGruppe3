using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClientToService
{
   static class StartProgram
   {
        static void Main() 
        {
            //Application.Run(new PresentationLayer.Login());
            Application.Run(new PresentationLayer.TestWinForms());
        }
   }
}
