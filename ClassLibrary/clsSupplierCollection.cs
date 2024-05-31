using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {

            }
        }
        public clsSupplier ThisSupplier 
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public clsSupplierCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsSupplier ASupplier = new clsSupplier();
                ASupplier.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                ASupplier.SupplierContactEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierContactEmail"]);
                ASupplier.SupplierContactPhone = Convert.ToString(DB.DataTable.Rows[Index]["SupplierContactPhone"]);
                ASupplier.SupplierCity = Convert.ToString(DB.DataTable.Rows[Index]["SupplierCity"]);
                ASupplier.SupplierAddDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["SupplierAddDate"]);
                mSupplierList.Add(ASupplier);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierContactEmail", mThisSupplier.SupplierContactEmail);
            DB.AddParameter("@Availability", mThisSupplier.Availability);
            DB.AddParameter("@SupplierAdddate", mThisSupplier.SupplierAddDate);
            DB.AddParameter("@SupplierContactPhone", mThisSupplier.SupplierContactPhone);
            DB.AddParameter("@SupplierCity", mThisSupplier.SupplierCity);

            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierContactEmail", mThisSupplier.SupplierContactEmail);
            DB.AddParameter("@Availability", mThisSupplier.Availability);
            DB.AddParameter("@SupplierAdddate", mThisSupplier.SupplierAddDate);
            DB.AddParameter("@SupplierContactPhone", mThisSupplier.SupplierContactPhone);
            DB.AddParameter("@SupplierCity", mThisSupplier.SupplierCity);
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}