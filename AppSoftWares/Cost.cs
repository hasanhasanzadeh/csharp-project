using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppSoftWares
{
    public class Cost
    {
        public static AccessDataBase Datas;

        public static int InsertCashEx(int cash_id, decimal deposit, decimal removal, decimal stock, string date_sh, string date_m, string description)
        {
            Datas = new AccessDataBase();
            string sql = "insert into Cash_Ex_Table(factor_id,deposit,removal,stock,date_sh,date_m,description)values('{0}',{1},{2},{3},'{4}','{5}','{6}')";
            sql = string.Format(sql, cash_id, deposit, removal, stock, date_sh, date_m, description);
            return Datas.NonQuery(sql);
        }

        public static int UpdateCashEx(int cash_id, int id)
        {
            Datas = new AccessDataBase();
            string sql = "update Cash_Ex_Table set factor_id ={0} where id={1}";
            sql = string.Format(sql, cash_id, id);
            return Datas.NonQuery(sql);
        }

        public static int DeleteCashEx(int id)
        {
            Datas = new AccessDataBase();
            string sql = "delete * from Cash_Ex_Table where id={0}";
            sql = string.Format(sql, id);
            return Datas.NonQuery(sql);
        }

        public static int ExistCashEx(int cash_id)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Cash_Ex_Table where factor_id={0}";
            sql = string.Format(sql, cash_id);
            return Datas.SclarQuery(sql);
        }

        public static string ReturnCashEx(int cash_id)
        {
            Datas = new AccessDataBase();
            string sql = "select TOP 1 (stock) from Cash_Ex_Table where factor_id={0} order by ID DESC";
            sql = string.Format(sql, cash_id);
            return Datas.SelectQuery(sql);
        }

        public static DataTable SelectLikeCashEx(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Cash_Ex_Table where factor_id like '%{0}%' or date_sh like '%{0}%' or date_m like '%{0}%' or description like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }
    }
}
