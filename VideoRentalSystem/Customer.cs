using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalSystem
{
  public class Customer
    {
        Record instance_Object = new Record();

        int Id { get; set; }
        String Name { get; set; }
        String Phone { get; set; }
        String Address { get; set; }

        //constructor of the customer class that is used to pas the value to the global variables
        public Customer(int id,String Name,String Phone,String Address) {
            this.Id = id;
            this.Name = Name;
            this.Phone = Phone;
            this.Address = Address;
        }
        //method to insert the record in the table uisng the constructor method of the class
        public Boolean registerCustomer() {
            String query = "insert into Customer_Record(Cname,Cphone,Caddress)values('" + Name + "','" + Phone + "','" + Address + "')";
            instance_Object.SqlQuery(query);
            return true;
        }
        //this block is used to delete the cutomer record from the database table of the customer using where clause
        public Boolean delCustomer() {
            String query = "select * from Rental_Record where CustomerID="+Convert.ToInt32(Id)+" and VideoReturn='Booked'";
            DataTable tbl = new DataTable();
            tbl= instance_Object.srchRecord(query);
            if (tbl.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                query = "delete from Customer_Record where CustomerID=" + Convert.ToInt32(Id) + "";
                instance_Object.SqlQuery(query);
                return true;
            }
        }
        // this block is used to update  the Record of the Class 
        public Boolean UpdateCustomer() {
            String query="Update Customer_Record set Cname='"+Name+"',Cphone='"+Phone+"',Caddress='"+Address+"' where CustomerID="+Convert.ToInt32(Id)+"";
            instance_Object.SqlQuery(query);
            return true;
        }


        public String tpVideo()
        {
            DataTable tblData = new DataTable();
            tblData = instance_Object.srchRecord("select * from Customer_Record ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = instance_Object.srchRecord("select count(*) from Rental_Record where CustomerID=" + Convert.ToInt32(tblData.Rows[x]["CustomerID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Cname"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            return Title;

        }
    }
}
