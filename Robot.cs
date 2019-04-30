using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guibotomat
{
    public class Robot
    {
        public int id;
        public string name;
        public string type;
        public int tasksCompleted;
        public int totalPoints;
        bool randomNumbersSelected = false;

        public Robot()
        {
        }


        public Robot(int _id, string _name, string _type, int _tasks, int _points)
        {
            id = _id;
            name = _name;
            type = _type;
            tasksCompleted = _tasks;
            totalPoints = _points;
        }


        public string tasks(int _task)
        {
            int task = _task;
            string taskString = "";
            switch (task)
            {
                case 1:
                    taskString = "do the dishes";
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
                    taskString = "make a sammich";
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
                    taskString = "wash the car";
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
                    description = "wash the car";
                    points = 10000;
                    break;
            }
            return points;

        }





        public string timer(int _task)
        {
            int task = _task;
            string description = "";
            int timer = 0;
            switch (task)
            {
                case 1:
                    description = "do the dishes";
                    timer = 1;
                    break;
                case 2:
                    description = "sweep the house";
                    timer = 3;
                    break;
                case 3:
                    description = "do the laundry";
                    timer = 10;
                    break;
                case 4:
                    description = "take out the recycling";
                    timer = 4;
                    break;
                case 5:
                    description = "make a sammich";
                    timer = 7;
                    break;
                case 6:
                    description = "mow the lawn";
                    timer = 20;
                    break;
                case 7:
                    description = "rake the leaves";
                    timer = 18;
                    break;
                case 8:
                    description = "give the dog a bath";
                    timer = 14;
                    break;
                case 9:
                    description = "bake some cookies";
                    timer = 8;
                    break;
                case 10:
                    description = "wash the car";
                    timer = 20;
                    break;
            }
            return timer.ToString();

        }


        public int taskCounter(int i)
        {
            i += 1;
            return i;
        }



        public int[] randNumSelection(int[] randomNumbers)
        {

            Random rand = new Random();
            //Selection of 5 random numbers
            for (int i = 0; i < 5; i++)
            {
                bool check; //variable to check or number is already used
                int n; //variable to store the number in
                do
                {
                    n = rand.Next(1, 11);
                    //check or number is already used:
                    check = true;
                    for (int j = 0; j < i; j++)
                        if (n == randomNumbers[j]) //if number is already used
                        {
                            check = false; //set check to false
                            break; //no need to check the other elements of value[]
                        }
                } while (!check); //loop until new, unique number is found
                randomNumbers[i] = n; //store the generated number in the array
            }

            return randomNumbers;
        }
    }
}
