using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agumi_Doga
{
    public static PictureBox Gumilista;
    public partial class Form1 : Form
    {
        //public static PictureBox AutoPicture();
        public Form1()
        {
            InitializeComponent();
        }
        void Start()
        {
            //List<string> Gumilista = new List<string>();
            Gumilista = new PictureBox()
            {
                this.Controls.Add(Gumilista);
            };
        }
    }
}
