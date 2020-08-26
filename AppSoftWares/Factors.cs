using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppSoftWares
{
    public class Factors
    {
        public static AccessDataBase Datas;

        public static int InsertFactorBuy(int factor_id, string customer, string currency, int product_id, decimal weight, decimal price, decimal price_sum, string date_sh, string date_m, string description)
        {
            Datas = new AccessDataBase();
            string sql = "insert into Factor_Buy_Table(factor_id,  customer,  currency, product_id,  weight,  price,  price_sum,  date_sh,  date_m,  description) values({0},'{1}','{2}',{3},{4},{5},{6},'{7}','{8}','{9}')";
            sql = string.Format(sql, factor_id, customer, currency, product_id, weight, price, price_sum, date_sh, date_m, description);
            return Datas.NonQuery(sql);
        }

        public static int UpdateFactorBuy(int factor_id, string customer, string currency, int product_id, decimal weight, decimal price, decimal price_sum, string date_sh, string date_m, string description, int id)
        {
            Datas = new AccessDataBase();
            string sql = "update Factor_Buy_Table set factor_id={0} , customer='{1}', currency='{2}' , product_id={3} , weight={4} ,price={5} , price_sum={6} , date_sh='{7}' ,date_m='{8}' , description='{9}' where id={10}";
            sql = string.Format(sql, factor_id, customer, currency, product_id, weight, price, price_sum, date_sh, date_m, description, id);
            return Datas.NonQuery(sql);
        }

        public static int DeleteFactorBuy(int id)
        {
            Datas = new AccessDataBase();
            string sql = "delete * from Factor_Buy_Table where factor_id={0}";
            sql = string.Format(sql, id);
            return Datas.NonQuery(sql);
        }

        public static int ExistFactorBuy(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Factor_Buy_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SclarQuery(sql);
        }

        public static string SelectFactorBuyWeight(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select weight from Factor_Buy_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectQuery(sql);
        }
        public static string SelectFactorBuyPrice(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select price from Factor_Buy_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectQuery(sql);
        }
        public static string SelectFactorSellWeight(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select sum(weight) from Factor_Sell_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectQuery(sql);
        }

        public static string SelectFactorBuyProduct(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select product_id from Factor_Buy_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SelectQuery(sql);
        }


        public static DataTable SelectLikeFactorBuy(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Factor_Buy_Table where factor_id like '%{0}%' or currency like '%{0}%' description like '%{0}%' or date_sh like '%{0}%' or customer like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }

        public static int InsertFactorSell(int factor_id, string customer, string currency, int product_id, decimal weight, decimal price, decimal price_sum, string date_sh, string date_m, string description)
        {
            Datas = new AccessDataBase();
            string sql = "insert into Factor_Sell_Table(factor_id,  customer,  currency, product_id,  weight,  date_sh,  date_m,  description, price, price_total)values({0},'{1}','{2}',{3},{4},'{5}','{6}','{7}',{8},{9})";
            sql = string.Format(sql, factor_id, customer, currency, product_id, weight, date_sh, date_m, description, price, price_sum);
            return Datas.NonQuery(sql);
        }

        public static int UpdateFactorSell(int factor_id, string customer, string currency, int product_id, decimal weight, decimal price, decimal price_sum, string date_sh, string date_m, string description, int id)
        {
            Datas = new AccessDataBase();
            string sql = "update Factor_Sell_Table set factor_id={0} , customer='{1}', currency='{2}' , product_id={3} , weight={4} ,price={5} , price_total={6} , date_sh='{7}' ,date_m='{8}' , description='{9}' where id={10}";
            sql = string.Format(sql, factor_id, customer, currency, product_id, weight, price, price_sum, date_sh, date_m, description, id);
            return Datas.NonQuery(sql);
        }

        public static int DeleteFactorSell(int id)
        {
            Datas = new AccessDataBase();
            string sql = "delete * from Factor_Sell_Table where factor_id={0}";
            sql = string.Format(sql, id);
            return Datas.NonQuery(sql);
        }

        public static int ExistFactorSell(int factor_id)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Factor_Sell_Table where factor_id={0}";
            sql = string.Format(sql, factor_id);
            return Datas.SclarQuery(sql);
        }

        public static DataTable SelectLikeFactorSell(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Factor_Sell_Table where factor_id like '%{0}%' description like '%{0}%' or currency like '%{0}%' or date_sh like '%{0}%' or customer like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }
        
        public static DataTable SelectLikeFactorSellDate(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Factor_Sell_Table where date_sh like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }
        public static DataTable SelectLikeFactorBuyDate(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Factor_Buy_Table where date_sh like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }
        
        public static DataTable SelectLikeFactorBuyD(string searching,string date)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Factor_Buy_Table where factor_id like '%{0}%' or description like '%{0}%' or currency like '%{0}%' or customer like '%{0}%' and date_sh in ( select date_sh from Factor_Buy_Table where date_sh like '%{1}%')";
            sql = string.Format(sql, searching, date);
            return Datas.SelectLike(sql);
        }
        public static DataTable SelectLikeFactorSellD(string searching, string date)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Factor_Sell_Table where factor_id like '%{0}%' or description like '%{0}%' or currency like '%{0}%' or customer like '%{0}%' and date_sh in ( select date_sh from Factor_Sell_Table where date_sh like '%{1}%')";
            sql = string.Format(sql, searching, date);
            return Datas.SelectLike(sql);
        }
        public static string SelectCompany()
        {
            Datas = new AccessDataBase();
            string sql = "select company_name from Company_Table";
            return Datas.SelectQuery(sql);
        }
    }
}
