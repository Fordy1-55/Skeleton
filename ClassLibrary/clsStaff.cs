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
        private string mName
        
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

        public DateTime StartDateProperty { get; set; }
        public string RoleProperty { get; set; }
        public string ShiftTypeProperty { get; set; }
        public int StaffIDProperty { get; set; }
        public string NameProperty { get; set; }
        public bool ManagerStatus { get; set; }
        public bool PerformanceTarget { get; set; }

        public bool Find(int StaffIDProperty)
        {
            //Set private data members to test data value
            mStaffID = 5;
            //always return true
            return true;
        }
    }

    
}
    