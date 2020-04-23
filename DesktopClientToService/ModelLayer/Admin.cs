using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClientToService.ModelLayer {
    public class Admin {

        public string Email { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }

        public Admin() {

        }

    }
}

