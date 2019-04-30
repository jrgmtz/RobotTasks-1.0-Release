using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace guibotomat
{
    public partial class Scoreboards : Form
    {

        Connection c = new Connection();


        public Scoreboards()
        {
            InitializeComponent();

            c.scoreboards(robotsDataGridView);
        }


    }
}
