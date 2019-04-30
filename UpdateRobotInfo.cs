using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guibotomat
{
    public partial class UpdateRobotInfo : Form
    {

        Connection c = new Connection();
        string robotid;
        string name;
        string type;
        public UpdateRobotInfo(string _robotid, string _name, string _type)
        {
            InitializeComponent();
            robotid = _robotid;
            name = _name;
            type = _type;
            comboBox1.Enabled = false;
            comboBox1.SelectedItem = type.ToString();
        }

        private void UpdateRobotInfo_Load(object sender, EventArgs e)
        {
            label2.Text = "Enter new name for: \n" + name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            c.update(robotid, txtName.Text, comboBox1.SelectedItem.ToString());
            this.Close();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }
    }
}
