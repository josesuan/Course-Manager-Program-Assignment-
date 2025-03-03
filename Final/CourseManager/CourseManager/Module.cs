﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager
{
	//This is a class 
    class Module
    {
		//Attributes and properties
        public string year { get; set; }
        public string moduleName { get; set; }
        public int assignmentNum { get; set; }
        public string assigmentType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime dueDate { get; set; }
        public string location { get; set; }


		//Method(s)
        public int TimeRemaining()
        {
            DateTime currentDate;
            currentDate = DateTime.Today;
            int timeRemaining;

            timeRemaining = dueDate.DayOfYear - currentDate.DayOfYear;

            return timeRemaining;
        }
    }
}

