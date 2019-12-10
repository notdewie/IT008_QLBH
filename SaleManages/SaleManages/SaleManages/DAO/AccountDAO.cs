using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SaleManages.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }
        private AccountDAO(){}

        public bool LoginCheck(string userName,string passWord)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE TAIKHOAN = N'"+userName+"' AND MATKHAU = '"+passWord+"' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count>0;
        }
    }
}
