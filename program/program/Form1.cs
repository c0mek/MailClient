using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassMail;

namespace program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Mail m = new Mail();
            m.attachment = "siema";
            Console.WriteLine(m.attachment);
            InitializeComponent();
        }
    }
}
