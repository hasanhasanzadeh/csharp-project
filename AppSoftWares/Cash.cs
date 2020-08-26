using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppSoftWares
{
    public class Cash
    {
        public static AccessDataBase Datas;

        public static int InsertCash(int factor_id, string cash_name, decimal bestan, decimal bedeh, decimal stock, string date_sh, string date_m, string currency, string description)
        {
            Datas = new AccessDataBase();
            string sql = "insert into Cash_Table(factor_id,  cash_name,  bestan, bedeh, stock, date_sh, date_m, currency,description)values({0},'{1}',{2},{3},{4},'{5}','{6}','{7}','{8}')";
            sql = string.Format(sql, factor_id, cash_name, bestan, bedeh, stock, date_sh, date_m, currency, description);
            return Datas.NonQuery(sql);
        }

        public static int UpdateCash(int cash_id, int id)
        {
            Datas = new AccessDataBase();
            string sql = "update Cash_Table set factor_id ={0} where id={1}";
            sql = string.Format(sql, cash_id, id);
            return Datas.NonQuery(sql);
        }

        public static int DeleteCash(int id)
        {
            Datas = new AccessDataBase();
            string sql = "delete * from Cash_Table where id={0}";
            sql = string.Format(sql, id);
            return Datas.NonQuery(sql);
        }

        public static int ExistCash(int cash_id)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Cash_Table where factor_id={0}";
            sql = string.Format(sql, cash_id);
            return Datas.SclarQuery(sql);
        }

        public static string ReturnCash(int cash_id)
        {
            Datas = new AccessDataBase();
            string sql = "select TOP 1 (stock) from Cash_Table where factor_id={0} order by ID DESC";
            sql = string.Format(sql, cash_id);
            return Datas.SelectQuery(sql);
        }

        public static DataTable SelectLikeCash(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Cash_Table where factor_id like '%{0}%' or date_sh like '%{0}%' or date_m like '%{0}%' or description like '%{0}%' or cash_name like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }
        public static DataTable SelectLikeCashs(string searching,string dates)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Cash_Table where factor_id like '%{0}%' or description like '%{0}%' or cash_name like '%{0}%' and date_sh like '%{1}%'";
            sql = string.Format(sql, searching,dates);
            return Datas.SelectLike(sql);
        }
    }
}
