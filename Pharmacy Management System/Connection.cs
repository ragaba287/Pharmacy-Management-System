using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    public class Connection
    {
        string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";
        //string ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Data\Pharmacy.mdf;Initial Catalog=Pharmacy;Integrated Security=True";
        SqlConnection con;

        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }

        public void execute(String Query_) 
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        public int count_empl()
        {
            SqlCommand cmd = new SqlCommand("select count (*) from employees", con);
            return (Int32)cmd.ExecuteScalar();
        }

        public int count_sales()
        {
            SqlCommand cmd = new SqlCommand("select sum(amount) from sales", con);
            Int32 sum = 0;
            object sumObj = cmd.ExecuteScalar();
            if (sumObj == null)
            {
                sum =(Int32) sumObj;
            }
            return sum;
            
        }

        public int count_orders()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from sales", con);
            return (Int32)cmd.ExecuteScalar();
        }


        #region supplier

        public void add_supplier(string name ,string address ,string phone ,string quality ,string capabilities ,int deliver_speed_d,string notes )
        {
            string Query_ = "INSERT INTO suppliers (name,address,phone,quality,capabilities,deliver_speed_d,notes) values ('" + name + "','" + address + "','" + phone + "','" + quality + "','" + capabilities + "','" + deliver_speed_d + "','" + notes + "')";
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        public void delete_Allsupplier()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM suppliers", con);
            cmd.ExecuteNonQuery();
        }

        public void delete_OneSupplier(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM suppliers where id = '" + id + "'", con);
            cmd.ExecuteNonQuery();
        }

        #endregion supplier


        #region storage

        public void add_storage(string name, string address, string phone, string storage_space, string med_type, string notes)
        {
            string Query_ = "INSERT INTO storage (name,address,phone,storage_space,med_type,notes) values ('" + name + "','" + address + "','" + phone + "','" + storage_space + "','" + med_type + "','" + notes + "')";
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        public void delete_Allstorage()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM storage", con);
            cmd.ExecuteNonQuery();
        }

        public void delete_OneStorage(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM storage where id = '" + id + "'", con);
            cmd.ExecuteNonQuery();
        }

        #endregion storage
        


        #region employees

        public void add_employees(string name,string address,string phone,string job_title,string hire_date,int salary) 
        {
            string Query_ = "INSERT INTO employees (name,address,phone,job_title,hire_date,salary) values ('" + name + "','" + address + "','" + phone + "','" + job_title + "','" + hire_date + "','" + salary + "')";
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        public void delete_OneEmploye(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM employees where id = '" + id + "'", con);
            cmd.ExecuteNonQuery();
        }

        #endregion employees



        //public SqlDataReader DataReader(string Query_)
        //{
        //    SqlCommand cmd = new SqlCommand(Query_, con);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    return dr;
        //}


        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            PharmacyDataSet ds = new PharmacyDataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0].DefaultView;
            return dataum;
        }
    }
}
