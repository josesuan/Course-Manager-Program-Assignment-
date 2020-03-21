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
        public int year { get; set; }
        public string moduleName { get; set; }
        public int assignmentNum { get; set; }
        public string assigmentType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime dueDate { get; set; }
        public string location { get; set; }
        public int mark { get; set; }


		//Constructors

		//Default constructors
		public Module()
		{

		}

		//Pending Modules
		public Module(int Year, string Modulename, int AssignmentNum, string AssignmentType, DateTime StartDate, DateTime DueDate, string Location)
		{
			year = Year;
			moduleName = Modulename;
			assignmentNum = AssignmentNum;
			assigmentType = AssignmentType;
			startDate = StartDate;
			dueDate = DueDate;
			location = Location;
		}
		//Finished Modules and construcor for loading files
        public Module(int Year, string Modulename, int AssignmentNum, string AssignmentType, DateTime StartDate, DateTime DueDate, string Location, int grade)
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

			using (fileWriter = new StreamWriter("SaveFile.csv"))//Keeps add new data
			{
				foreach (Module detail in moduleList) //Add all objects of patientList details as values in csv file
				{
					fileWriter.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", detail.year, detail.moduleName, detail.assignmentNum, detail.assigmentType, detail.startDate.ToString("dd/MM/yyyy"), detail.dueDate.ToString("dd/MM/yyyy"),detail.location, detail.mark.ToString());
				}
			}
			fileWriter.Close();
		}


		/// <summary>
		/// Loads the save file
		/// </summary>
		/// <returns>Returns list of module from the save file</returns>
		public List<Module> LoadFile()
		{
			//Temporary modules list
			List<Module> loadModuleList = new List<Module>();
			string[] moduleAttributes = new string[8]; //8 attributes to store

			try
			{
				var linesModule = File.ReadLines("SaveFile.csv");

				//Reads each lines for finding existing patients
				foreach (string lines in linesModule)
				{
					moduleAttributes[0] = lines.Split(',')[0];  //Year
					moduleAttributes[1] = lines.Split(',')[1];  //Module name
					moduleAttributes[2] = lines.Split(',')[2];  //Assignment num
					moduleAttributes[3] = lines.Split(',')[3];  //Assignment type
					moduleAttributes[4] = lines.Split(',')[4];  //Start date
					moduleAttributes[5] = lines.Split(',')[5];  //Due date
					moduleAttributes[6] = lines.Split(',')[6];  //Location
					moduleAttributes[7] = lines.Split(',')[7];  //mark

					//Add all attributes of module into load module list
					loadModuleList.Add(new Module(Convert.ToInt32(moduleAttributes[0]), moduleAttributes[1], Convert.ToInt32(moduleAttributes[2]), moduleAttributes[3], Convert.ToDateTime(moduleAttributes[4]), Convert.ToDateTime(moduleAttributes[5]), moduleAttributes[6], Convert.ToInt32(moduleAttributes[7])));
				}

			}
			catch
			{
				//File cant be found
			}

			return loadModuleList; //Returns saved list modules
		}

	}
}

