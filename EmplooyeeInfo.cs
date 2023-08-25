
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFormApp
{
    internal class EmployeeInfo
    {
        public int Id { get; set; }
        public string surName { get; set; }
        public string otherNames { get; set; }
        public string dateOfEmployment { get; set; }
        public string department { get; set; }
        public string role { get; set; }

        ///CRUD create Read Update Delete

        ///Create a connString to SQLite DB
        ///
        private const string  connString = "Data Source=employeeDB.db";

        public  int employeeCreate(EmployeeInfo empInfo)
        {
            try
            {
                using (SQLiteConnection conn =new SQLiteConnection(connString))
                {
                    conn.Open();
                    string query = "Insert into employeeInfoTbl(surName,otherNames,dateOfEmployment,department,role) " +
                        "Values(@surName,@otherNames,@dateOfEmployment,@department,@role)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@surName", empInfo.surName);
                        cmd.Parameters.AddWithValue("@otherNames", empInfo.otherNames);
                        cmd.Parameters.AddWithValue("@dateOfEmployment", empInfo.dateOfEmployment);
                        cmd.Parameters.AddWithValue("@department", empInfo.department);
                        cmd.Parameters.AddWithValue("@role", empInfo.role);

                       int result= cmd.ExecuteNonQuery();

                       return result;  
                    }
                }

            }
            catch (Exception ex)
            {

               
            }
            return -1;
        }

        public int employeeUpdate(EmployeeInfo empInfo)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string query = "Update employeeInfoTbl set surName=@surName,otherNames=@otherNames,dateOfEmployment=@dateOfEmployment,department=@department,role=@role where Id=@Id";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", empInfo.Id);
                        cmd.Parameters.AddWithValue("@surName", empInfo.surName);
                        cmd.Parameters.AddWithValue("@otherNames", empInfo.otherNames);
                        cmd.Parameters.AddWithValue("@dateOfEmployment", empInfo.dateOfEmployment);
                        cmd.Parameters.AddWithValue("@department", empInfo.department);
                        cmd.Parameters.AddWithValue("@role", empInfo.role);

                        int result = cmd.ExecuteNonQuery();

                        return result;
                    }
                }

            }
            catch (Exception ex)
            {


            }
            return -1;
        }

    }


}
