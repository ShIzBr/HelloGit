using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Goodbye
    {
        public string text = "Goodbye";

        public string Go(string message)
        {
            return this.text + "__" + message;
        }
    }
}
