using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem
{
    public partial class Form1 : Form
    {

        Customer Instance_Customer = null;
        Video Instance_Video = null;
        Rental Instance_Rent = null;

        Record Instance_Record = new Record();

        DataTable tblData = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        public void clearAll() {
            Txttitle.Text = "";
            TxtRatting.Text = "";
            TxtYear.Text = "";
            Txtcost.Text = "";
            TxtCopies.Text = "";
            TxtCopies.Text = "";
            TxtPlot.Text = "";
            TxtGenre.Text = "";

            VideoID.Text = "";
            CustomerID.Text = "";
            RentalID.Text = "";

            TxtName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";


        }
        private void addCustomer_Click(object sender, EventArgs e)
        {
            //creating the instance of the object to the pass the data to the cusotmer class and then save in the database
            Instance_Customer= new Customer(0,TxtName.Text.ToString(),MobileNo.Text.ToString(),Address.Text.ToString());
            if (Instance_Customer.registerCustomer())
            {
                MessageBox.Show("Customer is Registered In the Video Rental  App");
            }
            else {
                MessageBox.Show("Check the Record to Insert ");
            }
            clearAll();
        }

        private void delCustomer_Click(object sender, EventArgs e)
        {
            if (!CustomerID.Text.ToString().Equals(""))
            {


                Instance_Customer = new Customer(Convert.ToInt32(CustomerID.Text.ToString()), TxtName.Text.ToString(), MobileNo.Text.ToString(), Address.Text.ToString());
                if (Instance_Customer.delCustomer())
                {
                    MessageBox.Show("Customer is Deleted from the Video Rental  App");
                }
                else
                {
                    MessageBox.Show("Customer can't be delete because already have an video on rent ");
                }
                clearAll();
            }
            else {
                MessageBox.Show("Select the customer to remove ");
            }
        }

        private void Customer_CheckedChanged(object sender, EventArgs e)
        {
            // if the Redio button is checked then the customer record 
            if (Customer.Checked == true) {
                String query = "Select * from Customer_Record";
                tblData=Instance_Record.srchRecord(query);
                Record.DataSource = tblData;
            }

        }

        private void AddVideo_Click(object sender, EventArgs e)
        {
            
            Instance_Video = new Video(0,Txttitle.Text.ToString(),TxtRatting.Text.ToString(),Convert.ToInt32(TxtYear.Text.ToString()),Convert.ToInt32(Txtcost.Text.ToString()),Convert.ToInt32(TxtCopies.Text.ToString()),TxtGenre.Text.ToString(),TxtPlot.Text.ToString());
            if (Instance_Video.RegisterVideo() == true)
            {
                MessageBox.Show("Video is Saved in the App");
            }
            else {
                MessageBox.Show("Video Record is not Saved in the App check the Recrord Once");
            }
            clearAll();
        }

        private void delVideo_Click(object sender, EventArgs e)
        {
            if (!VideoID.Text.ToString().Equals(""))
            {



                Instance_Video = new Video(Convert.ToInt32(VideoID.Text.ToString()), Txttitle.Text.ToString(), TxtRatting.Text.ToString(), Convert.ToInt32(TxtYear.Text.ToString()), Convert.ToInt32(Txtcost.Text.ToString()), Convert.ToInt32(TxtCopies.Text.ToString()), TxtGenre.Text.ToString(), TxtPlot.Text.ToString());
                if (Instance_Video.DeleteVideo() == true)
                {
                    MessageBox.Show("Video is deleted from the App");
                }
                else
                {
                    MessageBox.Show("Video Record is not deleted because the video is one rent Check the record carefully once again");
                }
                clearAll();
            }
            else {
                MessageBox.Show("VIDEO RECORD IS DELETED ");    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateVideo_Click(object sender, EventArgs e)
        {
            if (!VideoID.Text.ToString().Equals(""))
            {


                Instance_Video = new Video(Convert.ToInt32(VideoID.Text.ToString()), Txttitle.Text.ToString(), TxtRatting.Text.ToString(), Convert.ToInt32(TxtYear.Text.ToString()), Convert.ToInt32(Txtcost.Text.ToString()), Convert.ToInt32(TxtCopies.Text.ToString()), TxtGenre.Text.ToString(), TxtPlot.Text.ToString());
                if (Instance_Video.UpdateVideo() == true)
                {
                    MessageBox.Show("Video is Updated from the App");
                }
                else
                {
                    MessageBox.Show("Video Record is not Updated from the App check the Recrord Once");
                }
                clearAll();
            }
            else {
                MessageBox.Show("select the video to delete ");
            }
        }

        private void rentalIssueVideo_Click(object sender, EventArgs e)
        {
            if (!CustomerID.Text.ToString().Equals("") && !VideoID.Text.ToString().Equals(""))
            {


                Instance_Rent = new Rental(0, Convert.ToInt32(CustomerID.Text.ToString()), Convert.ToInt32(VideoID.Text.ToString()), IssueVideo.Text.ToString(), ReturnVideo.Text.ToString());
                //calling the method from the rental class to book the video on rent
                int rslt = Instance_Rent.RentalVideo(Convert.ToInt32(TxtCopies.Text.ToString()));
                // if the method return 1 it means all the video are on rent ,if it return 0 means the video is booked if it return 2 means the customer already have 2 videos on rent so he can't get any more
                if (rslt == 0)
                {
                    MessageBox.Show("Video is Issued on Rent to the Customer ");
                }
                else if (rslt == 1)
                {
                    MessageBox.Show("all video Copies are on rent  ");
                }
                else if (rslt == 0)
                {
                    MessageBox.Show("You already have 2 videos on rent ");
                }
                else
                {
                    MessageBox.Show("Check the record once again ");
                }
                clearAll();
            }
            else { 
                MessageBox.Show("select the video to issue");
            }
        }

        private void rentalVideoDelete_Click(object sender, EventArgs e)
        {
            if (!RentalID.Text.ToString().Equals(""))
            {


                Instance_Rent = new Rental(Convert.ToInt32(RentalID.Text.ToString()), Convert.ToInt32(CustomerID.Text.ToString()), Convert.ToInt32(VideoID.Text.ToString()), IssueVideo.Text.ToString(), ReturnVideo.Text.ToString());
                if (Instance_Rent.DeleteVideo())
                {
                    MessageBox.Show("Rental Video is Deleted from the record ");
                }
                else
                {
                    MessageBox.Show("There is must be an error in the query ");
                }
                clearAll();
            }
            else {
                MessageBox.Show("select the video to delete ");
            }
        }

        private void rentalReturnVideo_Click(object sender, EventArgs e)
        {
            if (!RentalID.Text.ToString().Equals(""))
            {



                Instance_Rent = new Rental(Convert.ToInt32(RentalID.Text.ToString()), Convert.ToInt32(CustomerID.Text.ToString()), Convert.ToInt32(VideoID.Text.ToString()), IssueVideo.Text.ToString(), ReturnVideo.Text.ToString());

                //this code is used to call the method of the returnvideo from the rental class and display the charges
                int cost = Instance_Rent.ReturnVideo();

                MessageBox.Show("Rental Video is Returned and your Charges is=$" + cost);
                clearAll();
            }
            else{
                MessageBox.Show("Select the video to return first ");
            
            }
        }

        private void Video_CheckedChanged(object sender, EventArgs e)
        {
            // if the Redio button is checked then the customer record 
            if (Video.Checked == true)
            {
                String query = "Select * from Video_Record";
                tblData = Instance_Record.srchRecord(query);
                Record.DataSource = tblData;
            }


        }

        private void Rent_CheckedChanged(object sender, EventArgs e)
        {
            // if the Redio button is checked then the customer record 
            if (Rent.Checked == true)
            {
                String query = "Select * from Rental_Record";
                tblData = Instance_Record.srchRecord(query);
                Record.DataSource = tblData;
            }
        }

        private void Record_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Rent.Checked==true) {
                RentalID.Text = Record.CurrentRow.Cells[0].Value.ToString();
                CustomerID.Text = Record.CurrentRow.Cells[1].Value.ToString();
                VideoID.Text= Record.CurrentRow.Cells[2].Value.ToString();
                IssueVideo.Text= Record.CurrentRow.Cells[3].Value.ToString();
                
            }

            if (Video.Checked==true) {
                VideoID.Text= Record.CurrentRow.Cells[0].Value.ToString();
                Txttitle.Text= Record.CurrentRow.Cells[1].Value.ToString();
                TxtRatting.Text= Record.CurrentRow.Cells[2].Value.ToString();
                TxtYear.Text=Record.CurrentRow.Cells[3].Value.ToString();
                Txtcost.Text= Record.CurrentRow.Cells[4].Value.ToString();
                TxtCopies.Text= Record.CurrentRow.Cells[5].Value.ToString();
                TxtGenre.Text= Record.CurrentRow.Cells[6].Value.ToString();
                TxtPlot.Text= Record.CurrentRow.Cells[7].Value.ToString();
            }
            if (Customer.Checked==true) {
                CustomerID.Text = Record.CurrentRow.Cells[0].Value.ToString();
                TxtName.Text= Record.CurrentRow.Cells[1].Value.ToString();
                MobileNo.Text= Record.CurrentRow.Cells[2].Value.ToString();
                Address.Text= Record.CurrentRow.Cells[3].Value.ToString();
            }


        }

        private void TxtYear_TextChanged(object sender, EventArgs e)
        {
            try {

                //dislay the cost of the price of the video after adding the year of the video
                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(TxtYear.Text.ToString());
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    Txtcost.Text = "2";
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    Txtcost.Text = "5";
                }

            }
            catch (Exception ex) {
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            tblData = Instance_Record.srchRecord("select * from Video_Record ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = Instance_Record.srchRecord("select * from Rental_Record where VideoID=" + Convert.ToInt32(tblData.Rows[x]["VideoID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Vtitle"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Top Ratting Video Movie Title is =="+Title);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            tblData = Instance_Record.srchRecord("select * from Customer_Record ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = Instance_Record.srchRecord("select * from Rental_Record where CustomerID=" + Convert.ToInt32(tblData.Rows[x]["CustomerID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Cname"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Top Customer Name is ==" + Title);

        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            if (!CustomerID.Text.ToString().Equals(""))
            {
                Instance_Customer = new Customer(Convert.ToInt32(CustomerID.Text.ToString()), TxtName.Text.ToString(), MobileNo.Text.ToString(), Address.Text.ToString());
                if (Instance_Customer.UpdateCustomer() == true)
                {
                    MessageBox.Show("customer record is updated ");
                    clearAll();
                }
                else {
                    MessageBox.Show("Customer record is not updated ");
                }
            }
            else {
                MessageBox.Show("select the customer to update");
            }
        }
    }
}
