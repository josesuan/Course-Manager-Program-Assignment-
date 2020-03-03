using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseManager
{
    public class Module
    {

		//Properties
        public string year { get; set; }
        public string moduleName { get; set; }
        public int assignmentNum { get; set; }
        public string assigmentType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime dueDate { get; set; }
        public string location { get; set; }
        public int mark { get; set; }


		//Constructors
		public Module()
		{

		}

		//Pending Modules
		public Module(string Year, string Modulename, int AssignmentNum, string AssignmentType, DateTime StartDate, DateTime DueDate, string Location)
		{
			year = Year;
			moduleName = Modulename;
			assignmentNum = AssignmentNum;
			assigmentType = AssignmentType;
			startDate = StartDate;
			dueDate = DueDate;
			location = Location;
		}
		//Finished Modules
        public Module(string Year, string Modulename, int AssignmentNum, string AssignmentType, DateTime StartDate, DateTime DueDate, string Location, int grade)
        {
            year = Year;
            moduleName = Modulename;
            assignmentNum = AssignmentNum;
            assigmentType = AssignmentType;
            startDate = StartDate;
            dueDate = DueDate;
            location = Location;
            mark = grade;
        }




        public int TimeRemaining()
        {
            DateTime currentDate;
            currentDate = DateTime.Today;
            int timeRemaining;

            timeRemaining = dueDate.DayOfYear - currentDate.DayOfYear;

            return timeRemaining;
        }


		/// <summary>
		/// This method is used to save all module list in the CSV file
		/// </summary>
		/// <param name="moduleList"></param>
		public void SaveFile(List<Module> moduleList)
		{
			StreamWriter fileWriter;

			using (fileWriter = new StreamWriter("SaveFile.csv", append: true))//Keeps add new data
			{
				foreach (Module detail in moduleList) //Add all objects of patientList details as values in csv file
				{
					fileWriter.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", detail.year, detail.moduleName, detail.assignmentNum, detail.assigmentType, detail.startDate.ToString("dd/MM/yyyy"), detail.dueDate.ToString("dd/MM/yyyy"),detail.location, detail.mark.ToString());
				}
			}
			fileWriter.Close();
		}


		public void LoadFile()
		{

		}

	}
}

