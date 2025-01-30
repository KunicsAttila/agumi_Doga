using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agumi_Doga
{
    class TeliGumi : AutoGumi
    {
        public TeliGumi(string nev, string anyag, int ar) : base(nev, anyag, ar)
        {
            this.BackColor = System.Drawing.Color.DarkGray;

            this.ForeColor = System.Drawing.Color.White;
        }
    }
}
