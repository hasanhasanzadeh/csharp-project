using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppSoftWares
{
    public class Products
    {
        public static AccessDataBase Datas;

        public static int InsertProduct(string product_name,string product_type)
        {
            Datas = new AccessDataBase();
            string sql = "insert into Product_Table(product_name,product_type)values('{0}','{1}')";
            sql = string.Format(sql, product_name,product_type);
            return Datas.NonQuery(sql);
        }

        public static int UpdateProduct(string product_name, int id)
        {
            Datas = new AccessDataBase();
            string sql = "update Product_Table set product_name ='{0}' where id={1}";
            sql = string.Format(sql, product_name, id);
            return Datas.NonQuery(sql);
        }

        public static int DeleteProduct(int id)
        {
            Datas = new AccessDataBase();
            string sql = "delete * from Product_Table where id={0}";
            sql = string.Format(sql, id);
            return Datas.NonQuery(sql);
        }

        public static int ExistProduct(string product_name)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Product_Table where product_name='{0}'";
            sql = string.Format(sql, product_name);
            return Datas.SclarQuery(sql);
        }


        public static int SelectCountProduct()
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Product_Table";
            sql = string.Format(sql);
            return Datas.SclarQuery(sql);
        }

        public static string SelectProduct(int id)
        {
            Datas = new AccessDataBase();
            string sql = "select product_name from Product_Table where id={0}";
            sql = string.Format(sql, id);
            return Datas.SelectQuery(sql);
        }
        public static string SelectProducts(int id)
        {
            Datas = new AccessDataBase();
            string sql = "select product_type from Product_Table where id={0}";
            sql = string.Format(sql, id);
            return Datas.SelectQuery(sql);
        }
        public static int SelectIdProduct(string product_name)
        {
            Datas = new AccessDataBase();
            string sql = "select id from Product_Table where product_name='{0}'";
            sql = string.Format(sql, product_name);
            return Datas.SclarQuery(sql);
        }

        public static DataTable SelectLikeProduct(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Product_Table where product_name like '%{0}%' or product_type like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }
    }
}
