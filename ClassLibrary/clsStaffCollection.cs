﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for this staff
        clsStaff mThisStaff = new clsStaff();


        //constructor for the class
        public clsStaffCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);




        }


        //public property for list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get 
            {
                return mStaffList.Count;
            }
            set
            {
                //come back to this later
            }
        }
        public clsStaff ThisStaff
        {
            get 
            {
                //return private data
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }

        }

        public int Add()
        {
            //adds record to the database based on values within mThisStaff
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@ShiftType", mThisStaff.ShiftType);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@PerformanceTarget", mThisStaff.PerformanceTarget);
            DB.AddParameter("@ManagerStatus", mThisStaff.ManagerStatus);

            //execute query returning primart key value
            return DB.Execute("sproc_tblStaff_Insert");

            ////throw new NotImplementedException();
        }

        public void Delete()
        {
            //deletes record pointed at by ThisStaff
            //Connect to DB
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //EXECUTE STORED PROCEDURE
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByName(string Name)
        {
            //filters all records based on a full or partial name
            //connect to DB
            clsDataConnection DB = new clsDataConnection();
            //send name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute stored procedure
            DB.Execute("sproc_tblStaff_FilterByName");
            //populate array with the data table
            PopulateArray(DB);
        }

        public void Update()
        {
            //Update existing record based on the values of ThisStaff
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@ShiftType", mThisStaff.ShiftType);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@PerformanceTarget", mThisStaff.PerformanceTarget);
            DB.AddParameter("@ManagerStatus", mThisStaff.ManagerStatus);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get record count
            RecordCount = DB.Count;
            //clear private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount) 
            {
                //create blank address
                clsStaff Staff = new clsStaff();
                //read in the fields for the current record
                Staff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                Staff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Staff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                Staff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                Staff.ShiftType = Convert.ToString(DB.DataTable.Rows[Index]["ShiftType"]);
                Staff.PerformanceTarget = Convert.ToBoolean(DB.DataTable.Rows[Index]["PerformanceTarget"]);
                Staff.ManagerStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["ManagerStatus"]);
                //add the record to the private data member
                mStaffList.Add(Staff);
                //point at the next record
                Index++;
            }
        }
    }
}