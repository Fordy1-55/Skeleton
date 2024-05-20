using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //Private data mamber for the staff id property
        private Int32 mStaffID;

        //StaffID public property
        public Int32 StaffID
        {
            get
            {
                //This line sends data out of the property
                return mStaffID;
            }
            set
            {
                //This line allows data into the property
                mStaffID = value;
            }
        }

        //Private data member for the name property
        private string mName;
        //Public accessor
        public string Name
        
        {
            get 
            { 
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        //Private data member for Role property
        private string mRole;
        //Public accessor
        public string Role
        {
            get
            {
                return mRole;
            }
            set
            {
                mRole = value;
            }
        }

        //Private data member for ShiftType property
        private string mShiftType;
        //public accessor
        public string ShiftType
        {
            get
            {
                return mShiftType;
            }
            set
            {
                mShiftType = value;
            }
        }

        private Boolean mPerformanceTarget;
        public bool PerformanceTarget
        {
            get
            {
                return mPerformanceTarget;
            }
            set
            {
                mPerformanceTarget = value;
            }
        }

        private Boolean mManagerStatus;
        public bool ManagerStatus
        {
            get
            {
                return mManagerStatus;
            }
            set
            {
                mManagerStatus = value;
            }
        }

        //Private data member for start date
        private DateTime mStartDate;
        //Public property
        public DateTime StartDate
        {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }

        //public DateTime StartDateProperty { get; set; }
        //public string RoleProperty { get; set; }
        //public string ShiftTypeProperty { get; set; }
        //public int StaffIDProperty { get; set; }
        //public string NameProperty { get; set; }
        //public bool ManagerStatusProperty { get; set; }
        //public bool PerformanceTargetProperty { get; set; }

        public bool Find(int StaffID)
        {
            //Create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for staff id to search for
            DB.AddParameter("@StaffID", StaffID);
            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one recird is found
            if (DB.Count == 1)
            {
                //copy data from database tp private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mShiftType = Convert.ToString(DB.DataTable.Rows[0]["ShiftType"]);
                mPerformanceTarget = Convert.ToBoolean(DB.DataTable.Rows[0]["PerformanceTarget"]);
                mManagerStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["ManagerStatus"]);
                //always return true
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating problem
                return false;
            }
            
        }

        public string Valid(string Name, string Role, string ShiftType, string StartDate)
        {
            //create temp variable to store date values
            DateTime DateTemp;
            //create string variable to store the error
            String Error = "";
            //if name is blank
            if (Name.Length == 0)
            {
                //record error
                Error = Error + "Name may not be blank";
            }
            //if name is greater than 35 characters
            if (Name.Length > 35) 
            {
                //record error
                Error = Error + "Name may not be more than 35 Characters";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the StartDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(StartDate);

                if (DateTemp < DateComp)
                {
                    //record the error
                    Error = Error + "Date cannot be in the past";

                }
                //check to see if date is greater than todays date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "Date cannot be in the future";
                }
            }
            catch 
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is role blank
            if(Role.Length == 0) 
            {
                //record error
                Error = Error + "Role may not be blank";
            }
            //Role too long
            if(Role.Length > 30)
            {
                //record error
                Error = Error + "Role may not be more than 30 characters";

            }
            //is shiftype blank?
            if(ShiftType.Length == 0)
            {
                //record error
                Error = Error + "Shift type may not be blank";
            }
            //is shiftype more than 25 characters
            if (ShiftType.Length > 25)
            {
                //record the error
                Error = Error + "Shift type must be no more than 25 Characters";
            }
            //return any error messages
            return Error;

            
        }


       
        
    }

    
}
    