using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppSoftWares
{
    public class Exits
    {
        public static AccessDataBase Datas;

        public static int InsertExit(int factor_id, string truck_ir, string truck_irq, string driver_phone,decimal weight,int product_id, string cotash, string bar_number, string date_sh, string date_m, string customer,string description)
        {
            Datas = new AccessDataBase();
            string sql = "insert into Exit_Table(factor_id,truck_ir,truck_irq,driver_phone,weight,product_id,cotash,bar_number,date_sh,date_m,customer,description) values({0},'{1}','{2}','{3}',{4},{5},'{6}','{7}','{8}','{9}','{10}','{11}')";
            sql = string.Format(sql, factor_id, truck_ir, truck_irq, driver_phone, weight, product_id, cotash, bar_number, date_sh, date_m, customer, description);
            return Datas.NonQuery(sql);
        }

       

        public static int DeleteExit(int id)
        {
            Datas = new AccessDataBase();
            string sql = "delete * from Exit_Table where factor_id={0}";
            sql = string.Format(sql, id);
            return Datas.NonQuery(sql);
        }

        public static int ExistExit(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Exit_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SclarQuery(sql);
        }
        public static int ExistEnter(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Enter_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SclarQuery(sql);
        }
        public static int ExistExitidDriver(int driver_id, int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Exit_Table where driver_id={0} and factor_id={1}";
            sql = string.Format(sql, driver_id, factor_id);
            return Datas.SclarQuery(sql);
        }

        public static string SelectExit(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select weight from Exit_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectQuery(sql);
        }

        public static string SelectExits(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Exit_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectQuery(sql);
        }

        public static DataTable SelectLikeExit(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Exit_Table where factor_id like '%{0}%' or cotash like '%{0}%' or bar_number like '%{0}%' or date_sh like '%{0}%' or description like '%{0}%' or date_m like '%{0}%' or customer like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }
        public static DataTable SelectLikeExitD(string searching, string date)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Exit_Table where factor_id like '%{0}%' or date_m like '%{0}%' or description like '%{0}%' or cotash like '%{0}%' or customer like '%{0}%' or bar_number like '%{0}%' and date_sh in ( select date_sh from Exit_Table where date_sh like '%{1}%')";
            sql = string.Format(sql, searching, date);
            return Datas.SelectLike(sql);
        }
    }
}
