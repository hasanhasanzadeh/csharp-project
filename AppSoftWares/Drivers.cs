using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppSoftWares
{
    public class Driver
    {
        public static AccessDataBase Datas;

        public static int InsertDriver(string driver_name, string phone_number, string truck_number, string code_meli, string driver_address, string descrip,string number_cart)
        {
            Datas = new AccessDataBase();
            string sql = "insert into Driver_Table(driver_name,driver_phone,truck_number,code_meli,address,description,plus_1)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            sql = string.Format(sql, driver_name, phone_number, truck_number, code_meli, driver_address, descrip,number_cart);
            return Datas.NonQuery(sql);
        }

        public static int UpdateDriver(string driver_name, string phone_number, string truck_number, string driver_address, int id)
        {
            Datas = new AccessDataBase();
            string sql = "update Driver_Table set driver_name ='{0}' , phone_number='{1}' , truck_number='{2}', driver_address='{3}' where id={4}";
            sql = string.Format(sql, driver_name, phone_number, truck_number, driver_address, id);
            return Datas.NonQuery(sql);
        }

        public static int DeleteDriver(int id)
        {
            Datas = new AccessDataBase();
            string sql = "delete * from Driver_Table where id={0}";
            sql = string.Format(sql, id);
            return Datas.NonQuery(sql);
        }

        public static int ExistDriver(string truck_number)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Driver_Table where truck_number='{0}'";
            sql = string.Format(sql, truck_number);
            return Datas.SclarQuery(sql);
        }

        public static int ExistDriverMobile(string diver_mobile)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Driver_Table where driver_phone='{0}'";
            sql = string.Format(sql, diver_mobile);
            return Datas.SclarQuery(sql);
        }

        public static int ExistDrivers(string driver_name)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Driver_Table where driver_name='{0}'";
            sql = string.Format(sql, driver_name);
            return Datas.SclarQuery(sql);
        }

        public static int SelectIdDrivers(string truck_number)
        {
            Datas = new AccessDataBase();
            string sql = "select id from Driver_Table where truck_number='{0}'";
            sql = string.Format(sql, truck_number);
            return Datas.SclarQuery(sql);
        }
        public static string SelectTruckDriver(int id)
        {
            Datas = new AccessDataBase();
            string sql = "select truck_number from Driver_Table where id={0}";
            sql = string.Format(sql, id);
            return Datas.SelectQuery(sql);
        }
        
        public static string SelectPhone(string truck_number)
        {
            Datas = new AccessDataBase();
            string sql = "select driver_phone from Driver_Table where truck_number='{0}'";
            sql = string.Format(sql, truck_number);
            return Datas.SelectQuery(sql);
        }

        public static int ExistPhone(string truck_number)
        {
            Datas = new AccessDataBase();
            string sql = "select count(*) from Driver_Table where truck_number='{0}'";
            sql = string.Format(sql, truck_number);
            return Datas.SclarQuery(sql);
        }
        public static DataTable SelectIdDriverTruck(string truck_number)
        {
            Datas = new AccessDataBase();
            string sql = "select truck_number from Driver_Table where truck_number like '%{0}%'";
            sql = string.Format(sql, truck_number);
            return Datas.SelectLike(sql);
        }
        public static DataTable SelectLikeDriver(string searching)
        {
            Datas = new AccessDataBase();
            string sql = "select * from Driver_Table where driver_name like '%{0}%' or truck_number like '%{0}%' or driver_phone like '%{0}%' or code_meli like '%{0}%'";
            sql = string.Format(sql, searching);
            return Datas.SelectLike(sql);
        }
    }
}
