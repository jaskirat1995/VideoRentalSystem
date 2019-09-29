using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace VideoRentalSystem
{
    public class Video
    {
        //object of the class
        Record instance_Object = new Record();

        //getter setter method to pass the record to the relevent method 
        int Vid { get; set; }
        String Vtitle { get; set; }
        String Vratting { get; set; }
        int Vyear { get; set; }
        int Vcost { get; set; }
        int Vcopies { get; set; }
        String VGenre { get; set; }
        String VPlot { get; set; }

        //consrtuctor of the Class 
        public Video(int Vid,String Vtitle,String Vratting,int Vyear,int Vcost,int Vcopies,String VGenre,String VPlot) {
            this.Vid = Vid;
            this.Vtitle = Vtitle;
            this.Vratting = Vratting;
            this.Vyear = Vyear;
            this.Vcost = Vcost;
            this.Vcopies = Vcopies;

            this.VGenre = VGenre;
            this.VPlot = VPlot;
        }
        //this code is used to insert the details of the video
        public Boolean RegisterVideo() {
            String Query = "insert into Video_Record(Vtitle,Vratting,Vyear,Vcost,Vcopies,VGenre,VPlot)values('"+Vtitle+"','"+Vratting+"',"+Vyear+","+Vcost+","+Vcopies+",'"+VGenre+"','"+VPlot+"')";
            instance_Object.SqlQuery(Query);
            return true;
        }
        
        //this code is used to delete the record of the video 
        public Boolean DeleteVideo() {
            String Query = "select * from Rental_Record where VideoID=" + Convert.ToInt32(Vid) + " and VideoReturn='Booked'";
            DataTable tbl = new DataTable();
            tbl = instance_Object.srchRecord(Query);
            if (tbl.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                Query = "delete from Video_Record where VideoID=" + Vid + "";
                instance_Object.SqlQuery(Query);
                return true;
            }   
        }

        //this code is used to update  the record of the video
        public Boolean UpdateVideo() {
            String Query = "update Video_Record set Vtitle='" + Vtitle + "',Vratting='" + Vratting + "',Vyear=" + Vyear + ",Vcost=" + Vcost + ",Vcopies=" + Vcopies + ",VGenre='" + VGenre + "',VPlot='" + VPlot + "' where VideoID="+Vid+"";
            instance_Object.SqlQuery(Query);
            return true;
        }

        public String tpVideo() {
            DataTable tblData = new DataTable();
            tblData = instance_Object.srchRecord("select * from Video_Record ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = instance_Object.srchRecord("select * from Rental_Record where VideoID=" + Convert.ToInt32(tblData.Rows[x]["VideoID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Vtitle"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            return Title;

        }
    }
}
