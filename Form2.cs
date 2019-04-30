using guibotomat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace guibotomat
{
    public partial class Form2 : Form
    {

        Robot robot = new Robot();
        int[] randomNumbers = new int[5];
        Random rand = new Random();
        BipedalRobot bipedalRobot;

        bool newRobot;
        public int i;

        System.Media.SoundPlayer snd;
        Connection c = new Connection();

        public Form2(Robot _robot, bool _newRobot)
        {
            InitializeComponent();
            robot = _robot;
            newRobot = _newRobot;

            if(newRobot == true) { 
            c.insert(robot);
            }
    
            switch (robot.type)
            {
                case "Unipedal":
                    pictureBox1.Image = Resources.unipedal;
                    break;
                case "Bipedal":
                    pictureBox1.Image = Resources.bipedal1;
                    pictureBox1.Width = 175;
                    bipedalRobot = new BipedalRobot();
                    System.IO.Stream str = Properties.Resources.robot_effect;
                    snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    break;
                case "Quadrupedal":
                    pictureBox1.Image = Resources.quadrupedal2;
                    break;
                case "Arachnid":
                    pictureBox1.Image = Resources.arachnidrobot;
                    break;
                case "Radial":
                    pictureBox1.Image = Resources.radial1;
                    break;
                case "Aeronautical":
                    pictureBox1.Image = Resources.aeronautical2;
                    break;
            }
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Welcome
            label1.Text = "Hi, I am " + robot.name + "\n" +
                robot.type + " robot. \n" + "What do you want me to do today?";

            lblTotalPoints.Text = robot.totalPoints.ToString();
            lblTaskCompleted.Text = robot.tasksCompleted.ToString();

            //Selection of Random Numbers
            randomNumbers = robot.randNumSelection(randomNumbers);


            if (robot.type == "Bipedal")
            {
                lblTask1.Text = bipedalRobot.tasks(randomNumbers[0]);
                lblTask2.Text = bipedalRobot.tasks(randomNumbers[1]);
                lblTask3.Text = bipedalRobot.tasks(randomNumbers[2]);
                lblTask4.Text = bipedalRobot.tasks(randomNumbers[3]);
                lblTask5.Text = bipedalRobot.tasks(randomNumbers[4]);
            }
            else
            {
                lblTask1.Text = robot.tasks(randomNumbers[0]);
                lblTask2.Text = robot.tasks(randomNumbers[1]);
                lblTask3.Text = robot.tasks(randomNumbers[2]);
                lblTask4.Text = robot.tasks(randomNumbers[3]);
                lblTask5.Text = robot.tasks(randomNumbers[4]);
            }

            lblTimer1.Text = robot.timer(randomNumbers[0]);
            lblTimer2.Text = robot.timer(randomNumbers[1]);
            lblTimer3.Text = robot.timer(randomNumbers[2]);
            lblTimer4.Text = robot.timer(randomNumbers[3]);
            lblTimer5.Text = robot.timer(randomNumbers[4]);
        }

        //button #1
        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int timeLeft = int.Parse(lblTimer1.Text);  //getting the last value (the one from the label)
            timeLeft -= 1; //subtracting 1
            lblTimer1.Text = timeLeft.ToString();  //adding it back to the label.
            if(timeLeft == 0)
            {
                timer1.Stop();
                lblTimer1.Text = "TASK COMPETED!";
                btnCompleteTask1.Enabled = false;
                robot.totalPoints += robot.points(randomNumbers[0]);
                lblTotalPoints.Text = robot.totalPoints.ToString();
                robot.tasksCompleted = robot.taskCounter(robot.tasksCompleted);
                lblTaskCompleted.Text = robot.tasksCompleted.ToString();
                c.updatePoints(robot.name, robot.tasksCompleted, robot.totalPoints);
            }
        }

        //button #2
        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timeLeft = int.Parse(lblTimer2.Text);  //getting the last value (the one from the label)
            timeLeft -= 1; //subtracting 1
            lblTimer2.Text = timeLeft.ToString();  //adding it back to the label.
            if (timeLeft == 0)
            {
                timer2.Stop();
                lblTimer2.Text = "TASK COMPETED!";
                button1.Enabled = false;
                robot.totalPoints += robot.points(randomNumbers[1]);
                lblTotalPoints.Text = robot.totalPoints.ToString();
                robot.tasksCompleted = robot.taskCounter(robot.tasksCompleted);
                lblTaskCompleted.Text = robot.tasksCompleted.ToString();
                c.updatePoints(robot.name, robot.tasksCompleted, robot.totalPoints);
            }
        }
        //Button #3
        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int timeLeft = int.Parse(lblTimer3.Text);  //getting the last value (the one from the label)
            timeLeft -= 1; //subtracting 1
            lblTimer3.Text = timeLeft.ToString();  //adding it back to the label.
            if (timeLeft == 0)
            {
                timer3.Stop();
                lblTimer3.Text = "TASK COMPETED!";
                button3.Enabled = false;
                robot.totalPoints += robot.points(randomNumbers[2]);
                lblTotalPoints.Text = robot.totalPoints.ToString();
                robot.tasksCompleted = robot.taskCounter(robot.tasksCompleted);
                lblTaskCompleted.Text = robot.tasksCompleted.ToString();
                c.updatePoints(robot.name, robot.tasksCompleted, robot.totalPoints);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            timer4.Start();
        }
   
        //Button #4
        private void timer4_Tick(object sender, EventArgs e)
        {
            int timeLeft = int.Parse(lblTimer4.Text);  //getting the last value (the one from the label)
            timeLeft -= 1; //subtracting 1
            lblTimer4.Text = timeLeft.ToString();  //adding it back to the label.
            if (timeLeft == 0)
            {
                timer4.Stop();
                lblTimer4.Text = "TASK COMPETED!";
                button2.Enabled = false;
                robot.totalPoints += robot.points(randomNumbers[3]);
                lblTotalPoints.Text = robot.totalPoints.ToString();
                robot.tasksCompleted = robot.taskCounter(robot.tasksCompleted);
                lblTaskCompleted.Text = robot.tasksCompleted.ToString();
                c.updatePoints(robot.name, robot.tasksCompleted, robot.totalPoints);
            }
        }

        //Button #5
        private void button4_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int timeLeft = int.Parse(lblTimer5.Text);  //getting the last value (the one from the label)
            timeLeft -= 1; //subtracting 1
            lblTimer5.Text = timeLeft.ToString();  //adding it back to the label.
            if (timeLeft == 0)
            {
                timer5.Stop();
                lblTimer5.Text = "TASK COMPETED!";
                button4.Enabled = false;
                robot.totalPoints += robot.points(randomNumbers[4]);
                lblTotalPoints.Text = robot.totalPoints.ToString();
                robot.tasksCompleted = robot.taskCounter(robot.tasksCompleted);
                lblTaskCompleted.Text = robot.tasksCompleted.ToString();
                c.updatePoints(robot.name, robot.tasksCompleted, robot.totalPoints);
            }
        }


        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            btnCompleteTask1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            //Selection of Random Numbers
            robot.randNumSelection(randomNumbers);

            if (robot.type == "Bipedal")
            {
                lblTask1.Text = bipedalRobot.tasks(randomNumbers[0]);
                lblTask2.Text = bipedalRobot.tasks(randomNumbers[1]);
                lblTask3.Text = bipedalRobot.tasks(randomNumbers[2]);
                lblTask4.Text = bipedalRobot.tasks(randomNumbers[3]);
                lblTask5.Text = bipedalRobot.tasks(randomNumbers[4]);
            }
            else
            {
                lblTask1.Text = robot.tasks(randomNumbers[0]);
                lblTask2.Text = robot.tasks(randomNumbers[1]);
                lblTask3.Text = robot.tasks(randomNumbers[2]);
                lblTask4.Text = robot.tasks(randomNumbers[3]);
                lblTask5.Text = robot.tasks(randomNumbers[4]);
            }

            lblTimer1.Text = robot.timer(randomNumbers[0]);
            lblTimer2.Text = robot.timer(randomNumbers[1]);
            lblTimer3.Text = robot.timer(randomNumbers[2]);
            lblTimer4.Text = robot.timer(randomNumbers[3]);
            lblTimer5.Text = robot.timer(randomNumbers[4]);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
            if (robot.type == "Bipedal")
            {
                snd.Stop();
            }
        }

    }
    
}
