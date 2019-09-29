using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalSystem
{
   public class Rental
    {
        //object of the class
        Record instance_Object = new Record();

        public int RentID { get; set; }
        public int VideoID { get; set; }
        public int CustomerID { get; set; }
        public String VideoIssued { get; set; }
        public String VideoReturn { get; set; }
        public Rental(int RentID,int CustomerID,int VideoID,String VideoIssued,String VideoReturn) {

            this.RentID = RentID;
            this.VideoID = VideoID;
            this.CustomerID = CustomerID;
            this.VideoIssued = VideoIssued;
            this.VideoReturn = VideoReturn;

        }

        public int RentalVideo(int copy) {
            String Query = "";
            Query = "select * from Rental_Record where VideoID=" + Convert.ToInt32(VideoID) + " and VideoReturn='Booked'";
            DataTable tbl = new DataTable();
            tbl = instance_Object.srchRecord(Query);
            if (tbl.Rows.Count > copy)
            {
                //this code means all video is booked
                return 1;

            }
            else {

                Query = "";
                Query = "select * from Rental_Record where CustomerID=" + Convert.ToInt32(VideoID) + " and VideoReturn='Booked'";
                DataTable tbl1 = new DataTable();
                tbl1 = instance_Object.srchRecord(Query);
                if (tbl1.Rows.Count < 2)
                {
                    // this code is used to booked the movie on rent and save the record in the datasbase
                    Query = "insert into Rental_Record(CustomerID,VideoID,VideoIssued,VideoReturn) values(" + Convert.ToInt32(CustomerID) + "," + Convert.ToInt32(VideoID) + ",'" + VideoIssued + "','Booked')";
                    instance_Object.SqlQuery(Query);
                    return 0;
                }
                else {
                    return 2;  
                }

            }

                       
        }

        //this block is used to return the video to the Owner and display the charges 
        public int ReturnVideo() {
            int cost = 1;
            String Query = "select * from Video_Record where VideoID="+Convert.ToInt32(VideoID)+"";
            DataTable tbl = new DataTable();
            tbl = instance_Object.srchRecord(Query);
            if (tbl.Rows.Count > 0) {
                cost= Convert.ToInt32(tbl.Rows[0]["Vcost"].ToString());
            }


            DateTime new_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(VideoIssued);


            //get the difference in the days fromat
            String Daysdiff = (new_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));



            int Price = Convert.ToInt32(DaysInterval) * cost;


            String query = "Update Rental_Record set CustomerID="+CustomerID+",VideoID="+VideoID+",VideoIssued='"+VideoIssued+"',VideoReturn='"+VideoReturn+"' where RentID="+RentID+"";
            instance_Object.SqlQuery(query);

            return Price;

        }
        //this mthod is used to delete the record of the unwanted video entery
        public Boolean DeleteVideo() {
            String query = "delete from Rental_Record  where RentID=" + RentID + "";
            instance_Object.SqlQuery(query);

            return true;
        }

    }
}
