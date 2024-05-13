using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public DateTime StartDateProperty { get; set; }
        public string RoleProperty { get; set; }
        public string ShiftTypeProperty { get; set; }
        public int StaffIDProperty { get; set; }
        public string NameProperty { get; set; }
        public bool ManagerStatus { get; set; }
        public bool PerformanceTarget { get; set; }

        public bool Find(int StaffIDProperty)
        {
            //always return true
            return true;
        }
    }

    
}
    