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

        private Boolean mPerformanceTarg;
        public bool PerformanceTarg
        {
            get
            {
                return mPerformanceTarg;
            }
            set
            {
                mPerformanceTarg = value;
            }
        }

        private Boolean mManagerStat;
        public bool ManagerStat
        {
            get
            {
                return mManagerStat;
            }
            set
            {
                mManagerStat = value;
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

        public DateTime StartDateProperty { get; set; }
        public string RoleProperty { get; set; }
        public string ShiftTypeProperty { get; set; }
        public int StaffIDProperty { get; set; }
        public string NameProperty { get; set; }
        public bool ManagerStatus { get; set; }
        public bool PerformanceTarget { get; set; }

        public bool Find(int StaffID)
        {
            //Set private data members to test data value
            mStaffID = 7;
            mStartDate = Convert.ToDateTime("13/05/2028");
            mRole = "Test Role";
            mName = "Test Name";
            mShiftType = "Test Shift";
            mPerformanceTarg = true;
            mManagerStat = true;
            //always return true
            return true;
        }
    }

    
}
    