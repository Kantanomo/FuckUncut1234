using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuckUncut1234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://halo2pc.com");
            File.WriteAllText(Application.StartupPath + "Nerd.txt", request.GetResponse().GetResponseStream().ToString());
        }
    }
}
