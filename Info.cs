using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guibotomat
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
           
        }

        private void tnResume_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/jrgmtz");
          
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            byte[] resourceFile = Properties.Resources.Jorge_Cartagena_Resume_;

            string destination = Path.Combine(Path.GetTempPath(), "Jorge_Cartagena_Resume_.pdf");
            System.IO.File.WriteAllBytes(destination, resourceFile);
            Process.Start(destination);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            byte[] resourceFile = Properties.Resources.Jorge_Cartagena___Presentation_Letter;

            string destination = Path.Combine(Path.GetTempPath(), "Jorge_Cartagena___Presentation_Letter.pdf");
            System.IO.File.WriteAllBytes(destination, resourceFile);
            Process.Start(destination);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/jrgmtz");
        }
    }
}
