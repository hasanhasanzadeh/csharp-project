using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppSoftWares
{
    public class Enters
    {
        public static AccessDataBase Datas;

        public static int InsertEnter(int factor_id, int driver_id, decimal weight, int product_id, string cotash, string bar_number, string description, string date_sh, string date_m)
        {
            Datas = new AccessDataBase();
            string sql = "insert into Enter_Table(factor_id, driver_id, weight, product_id, cotash, bar_number, description, date_sh, date_m) values({0},{1},{2},{3},'{4}','{5}','{6}','{7}','{8}')";
            sql = string.Format(sql, factor_id, driver_id, weight, product_id, cotash, bar_number, description, date_sh, date_m);
            return Datas.NonQuery(sql);
        }


        public static int DeleteEnter(int id)
        {
            Datas = new AccessDataBase();
            string sql = "delete * from Enter_Table where factor_id={0}";
            sql = string.Format(sql, id);
            return Datas.NonQuery(sql);
        }
        public static int ProductIdEnter(int id)
        {
            Datas = new AccessDataBase();
            string sql = "delete product_id from Enter_Table where factor_id={0}";
            sql = string.Format(sql, id);
            return Datas.NonQuery(sql);
        }
        public static int ExistEnter(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Enter_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SclarQuery(sql);
        }
        public static int ExistEnters(int factor_id, int driver_id)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Enter_Table where factor_id={0} and driver_id={1}";
            sql = string.Format(sql, factor_id, driver_id);
            return Datas.SclarQuery(sql);
        }

        public static string SelectEnter(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select weight from Enter_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectQuery(sql);
        }

        public static string SelectEnters(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Enter_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectQuery(sql);
        }

        public static DataTable SelectLikeEnter(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Enter_Table where factor_id like '%{0}%' or cotash like '%{0}%' or bar_number like '%{0}%' or date_sh like '%{0}%' or description like '%{0}%' or date_m like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }
        public static DataTable SelectLikeEnters(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select driver_id from Enter_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectLike(sql);
        }
        public static int SelectLikeEnte(int factor_id, int driver_id)
        {
            Datas = new AccessDataBase();
            string sql = "select id from Enter_Table where factor_id={0} and driver_id={1}";
            sql = string.Format(sql, factor_id, driver_id);
            return Datas.SclarQuery(sql);
        }
        public static decimal SelectEnterWeight(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select weight from Enter_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectdecimalQuery(sql);
        }
        public static decimal SelectEnterWeights(int factor_id,int driver_id)
        {
            Datas = new AccessDataBase();
            string sql = "select weight from Enter_Table where factor_id={0} and driver_id={1}";
            sql = string.Format(sql, factor_id,driver_id);
            return Datas.SelectdecimalQuery(sql);
        }
        
        public static int SelectIdDriver(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select driver_id from Enter_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SclarQuery(sql);
        }
        public static int SelectIdProduct(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select product_id from Enter_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SclarQuery(sql);
        }
        public static int ReturnProductId(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select product_id from Factor_Buy_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SclarQuery(sql);
        }
        public static string SelectLikeEnterWeight(int factor_id, int driver_id)
        {
            Datas = new AccessDataBase();
            string sql = "select weight from Enter_Table where factor_id={0} and driver_id={1}";
            sql = string.Format(sql, factor_id, driver_id);
            return Datas.SelectQuery(sql);
        }

        public static string SelecEnterSumWeight(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select sum(weight) from Enter_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectQuery(sql);
        }
        public static string SelecBuySumWeight(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select weight from Factor_Buy_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectQuery(sql);
        }
        public static DataTable SelectLikeEnterDate(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Enter_Table where date_sh like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }

        public static DataTable SelectLikeEnte(int searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Enter_Table where factor_id like '%{0}%' or date_sh like '%{0}%' ";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }

        public static DataTable SelectLikeEnterD(string searching, string date)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Enter_Table where factor_id like '%{0}%' or date_m like '%{0}%' or description like '%{0}%' or cotash like '%{0}%' or bar_number like '%{0}%' and date_sh in ( select date_sh from Enter_Table where date_sh like '%{1}%')";
            sql = string.Format(sql, searching, date);
            return Datas.SelectLike(sql);
        }

    }
}
