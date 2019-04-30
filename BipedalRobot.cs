using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guibotomat
{
    class BipedalRobot
    {

        public string tasks(int _task)
        {
            int task = _task;
            string taskString = "";
            switch (task)
            {
                case 1:
                    taskString = "Kill a human";
                    break;
                case 2:
                    taskString = "sweep the house";
                    break;
                case 3:
                    taskString = "do the laundry";
                    break;
                case 4:
                    taskString = "take out the recycling";
                    break;
                case 5:
                    taskString = "Kill a human";
                    break;
                case 6:
                    taskString = "mow the lawn";
                    break;
                case 7:
                    taskString = "rake the leaves";
                    break;
                case 8:
                    taskString = "give the dog a bath";
                    break;
                case 9:
                    taskString = "bake some cookies";
                    break;
                case 10:
                    taskString = "Kill a human";
                    break;
            }
            return taskString;
        }


        public int points(int _task)
        {
            int task = _task;
            string description = "";
            int points = 0;
            switch (task)
            {
                case 1:
                    description = "do the dishes";
                    points = 1000;
                    break;
                case 2:
                    description = "sweep the house";
                    points = 1200;
                    break;
                case 3:
                    description = "do the laundry";
                    points = 800;
                    break;
                case 4:
                    description = "take out the recycling";
                    points = 1500;
                    break;
                case 5:
                    description = "make a sammich";
                    points = 2000;
                    break;
                case 6:
                    description = "mow the lawn";
                    points = 2200;
                    break;
                case 7:
                    description = "rake the leaves";
                    points = 3000;
                    break;
                case 8:
                    description = "give the dog a bath";
                    points = 5000;
                    break;
                case 9:
                    description = "bake some cookies";
                    points = 4200;
                    break;
                case 10:
                    description = "kill a human";
                    points = 100000;
                    break;
            }
            return points;

        }
    }
}
