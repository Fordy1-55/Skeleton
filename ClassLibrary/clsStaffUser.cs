using System;

namespace ClassLibrary
{
    public class clsStaffUser
    {
        //private data member for user id property
        private Int32 mUserID;
        //private data member for username property
        private String mUserName;
        //private data member for password property
        private String mPassword;
        //private data member for department property
        private string mDepartment;


        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }

        }
                
        public string UserName 
        {
            get 
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }
        public string Password 
        {
            get 
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public string Department 
        {
            get 
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameters for username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (should be one or none)
            if (DB.Count == 1) 
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm all is ok
                return true;
            }
            else 
            {
                return false;
            }
            
        }
    }
}