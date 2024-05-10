using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public static DateTime StartDateProperty { get; set; }
        public static string RoleProperty { get; set; }
        public static string ShiftTypeProperty { get; set; }
        public static int StaffIDProperty { get; set; }
        public static string NameProperty { get; set; }
        public bool ManagerStatus { get; set; }
        public bool PerformanceTarget { get; set; }

        public bool Find(int staffID)
        {
            //always return true
            return true;
        }
    }

    public class Boonlean
    {
    }
}