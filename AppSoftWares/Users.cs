using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppSoftWares
{
    public class Users
    {
        public static AccessDataBase Datas;

        public static int InsertUser(string username, string password)
        {
            Datas = new AccessDataBase();
            string sql = "insert into User_Table(username,password)values('{0}','{1}')";
            sql = string.Format(sql, username, password);
            return Datas.NonQuery(sql);
        }
        public static int UpdateUser(string username, string password, string password_old)
        {
            Datas = new AccessDataBase();
            string sql = "update User_Table set username='{0}' , password='{1}' where password='{2}'";
            sql = string.Format(sql, username, password, password_old);
            return Datas.NonQuery(sql);
        }
        public static int DeleteUser(string username, string password)
        {
            Datas = new AccessDataBase();
            string sql = "delete * from User_Table where username='{0}' and password='{1}'";
            sql = string.Format(sql, username, password);
            return Datas.NonQuery(sql);
        }
        public static int ExistUser(string username, string password)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from User_Table where username= '{0}' and password= '{1}'";
            sql = string.Format(sql, username, password);
            return Datas.SclarQuery(sql);
        }

        public static int InsertUserActive(string sr, string active)
        {
            Datas = new AccessDataBase();
            string sql = "UPDATE User_Table SET date_sh ='{0}' , actives ='{1}' where id = 2";
            sql = string.Format(sql, sr, active);
            return Datas.NonQuery(sql);
        }

        public static int UpateUserdate(string sr)
        {
            Datas = new AccessDataBase();
            string sql = "UPDATE User_Table SET date_sh ='{0}' where id = 2";
            sql = string.Format(sql, sr);
            return Datas.NonQuery(sql);
        }

        public static int ExistActive()
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from User_Table where actives is null  and date_sh is null";
            return Datas.SclarQuery(sql);
        }

        public static string SelectUserActive()
        {
            Datas = new AccessDataBase();
            string sql = "select actives from User_Table where id =1";
            return Datas.SelectQuery(sql);
        }
        public static int SelectUserDate()
        {
            Datas = new AccessDataBase();
            string sql = "select date_sh from User_Table where id =1";
            return Datas.SelectQuerys(sql);
        }
    }
}
