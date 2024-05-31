using System;
using System.IO;

namespace ClassLibrary
{
    public class clsStockUser
    {

        //private data member for    property
        private Int32 mUserID;
        //private data member for    property
        private string mUserName;
        //private data member for    property
        private string mPassword;
        //private data member for    property
        private string mDepartment;


        public int UserID 
        {
            get 
            {
                //return the private
                return mUserID;
            }
            set
            {
                //set the private data
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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //excute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNameStPW");
            //if one record is found (there should bbe either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the atabase to te  private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}