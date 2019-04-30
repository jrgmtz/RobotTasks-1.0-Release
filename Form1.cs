
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace guibotomat
{
    public partial class Form1 : Form
    {
   

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        Connection c = new Connection();
        Robot robot = new Robot();
        List<Robot> lstRobots = new List<Robot>();
        SqlConnection conn;
        public string name;

        Form2 robotForm;

        string type;
        int i = 0;


        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            c.refreshDataGrid(robotsDataGridView);
        }

        public void btnCreateRobot_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                type = "Unipedal";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                type = "Bipedal";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                type = "Quadrupedal";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                type = "Arachnid";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                type = "Radial";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                type = "Aeronautical";
            }

            robot.type = type;

            robot.name = txtName.Text;

            robotForm = new Form2(robot, true);

            c.refreshDataGrid(robotsDataGridView);

            robotForm.ShowDialog();
        }


        private void btnScoreboards_Click(object sender, EventArgs e)
        {
            Scoreboards score = new Scoreboards();
            score.ShowDialog();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();


        }

        //delete robot
        private void button1_Click(object sender, EventArgs e)
        {
            string idSelected = this.robotsDataGridView.CurrentRow.Cells[0].Value.ToString();


            c.delete(idSelected);
            c.refreshDataGrid(robotsDataGridView);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string itemSelected = this.robotsDataGridView.CurrentRow.Cells[0].Value.ToString();
            string name = this.robotsDataGridView.CurrentRow.Cells[1].Value.ToString();
            string type = this.robotsDataGridView.CurrentRow.Cells[2].Value.ToString();

            UpdateRobotInfo updateRobot = new UpdateRobotInfo(itemSelected, name, type);
            updateRobot.ShowDialog();
            c.refreshDataGrid(robotsDataGridView);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.refreshDataGrid(robotsDataGridView);
        }

        private void robotsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Robot robot = new Robot();
            robot.id =int.Parse( robotsDataGridView.CurrentRow.Cells[0].Value.ToString());
            robot.name = robotsDataGridView.CurrentRow.Cells[1].Value.ToString();
            robot.type = robotsDataGridView.CurrentRow.Cells[2].Value.ToString();
            robot.tasksCompleted = int.Parse(robotsDataGridView.CurrentRow.Cells[3].Value.ToString());
            robot.totalPoints = int.Parse(robotsDataGridView.CurrentRow.Cells[4].Value.ToString());

            robotForm = new Form2(robot, false);
            robotForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(79, 16, 137);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.Transparent;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(79, 16, 137);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(79, 16, 137);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Transparent;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }
    }
}
