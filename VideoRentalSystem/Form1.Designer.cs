namespace VideoRentalSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RentalID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.delVideo = new System.Windows.Forms.Button();
            this.updateVideo = new System.Windows.Forms.Button();
            this.AddVideo = new System.Windows.Forms.Button();
            this.TxtGenre = new System.Windows.Forms.TextBox();
            this.TxtPlot = new System.Windows.Forms.TextBox();
            this.TxtCopies = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.TxtRatting = new System.Windows.Forms.TextBox();
            this.Txttitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.VideoID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.ReturnVideo = new System.Windows.Forms.DateTimePicker();
            this.IssueVideo = new System.Windows.Forms.DateTimePicker();
            this.rentalVideoDelete = new System.Windows.Forms.Button();
            this.rentalReturnVideo = new System.Windows.Forms.Button();
            this.rentalIssueVideo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.MobileNo = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Record = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.RadioButton();
            this.Video = new System.Windows.Forms.RadioButton();
            this.Rent = new System.Windows.Forms.RadioButton();
            this.Txtcost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Record)).BeginInit();
            this.SuspendLayout();
            // 
            // RentalID
            // 
            this.RentalID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalID.Location = new System.Drawing.Point(447, 473);
            this.RentalID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentalID.Name = "RentalID";
            this.RentalID.Size = new System.Drawing.Size(204, 38);
            this.RentalID.TabIndex = 148;
            this.RentalID.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(496, 26);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 32);
            this.label18.TabIndex = 147;
            this.label18.Text = "Video Zone";
            // 
            // delVideo
            // 
            this.delVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delVideo.Location = new System.Drawing.Point(648, 415);
            this.delVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delVideo.Name = "delVideo";
            this.delVideo.Size = new System.Drawing.Size(113, 39);
            this.delVideo.TabIndex = 146;
            this.delVideo.Text = "Delete";
            this.delVideo.UseVisualStyleBackColor = true;
            this.delVideo.Click += new System.EventHandler(this.delVideo_Click);
            // 
            // updateVideo
            // 
            this.updateVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVideo.Location = new System.Drawing.Point(527, 415);
            this.updateVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateVideo.Name = "updateVideo";
            this.updateVideo.Size = new System.Drawing.Size(113, 39);
            this.updateVideo.TabIndex = 145;
            this.updateVideo.Text = "Update";
            this.updateVideo.UseVisualStyleBackColor = true;
            this.updateVideo.Click += new System.EventHandler(this.updateVideo_Click);
            // 
            // AddVideo
            // 
            this.AddVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideo.Location = new System.Drawing.Point(405, 415);
            this.AddVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(113, 39);
            this.AddVideo.TabIndex = 144;
            this.AddVideo.Text = "Add";
            this.AddVideo.UseVisualStyleBackColor = true;
            this.AddVideo.Click += new System.EventHandler(this.AddVideo_Click);
            // 
            // TxtGenre
            // 
            this.TxtGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenre.Location = new System.Drawing.Point(563, 346);
            this.TxtGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtGenre.Name = "TxtGenre";
            this.TxtGenre.Size = new System.Drawing.Size(204, 38);
            this.TxtGenre.TabIndex = 143;
            // 
            // TxtPlot
            // 
            this.TxtPlot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlot.Location = new System.Drawing.Point(563, 302);
            this.TxtPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPlot.Name = "TxtPlot";
            this.TxtPlot.Size = new System.Drawing.Size(204, 38);
            this.TxtPlot.TabIndex = 142;
            // 
            // TxtCopies
            // 
            this.TxtCopies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCopies.Location = new System.Drawing.Point(563, 255);
            this.TxtCopies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCopies.Name = "TxtCopies";
            this.TxtCopies.Size = new System.Drawing.Size(204, 38);
            this.TxtCopies.TabIndex = 141;
            // 
            // TxtYear
            // 
            this.TxtYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYear.Location = new System.Drawing.Point(563, 164);
            this.TxtYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(204, 38);
            this.TxtYear.TabIndex = 139;
            this.TxtYear.TextChanged += new System.EventHandler(this.TxtYear_TextChanged);
            // 
            // TxtRatting
            // 
            this.TxtRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRatting.Location = new System.Drawing.Point(563, 117);
            this.TxtRatting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRatting.Name = "TxtRatting";
            this.TxtRatting.Size = new System.Drawing.Size(204, 38);
            this.TxtRatting.TabIndex = 138;
            // 
            // Txttitle
            // 
            this.Txttitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttitle.Location = new System.Drawing.Point(563, 70);
            this.Txttitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txttitle.Name = "Txttitle";
            this.Txttitle.Size = new System.Drawing.Size(204, 38);
            this.Txttitle.TabIndex = 137;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(428, 357);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 32);
            this.label7.TabIndex = 136;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(428, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 32);
            this.label6.TabIndex = 135;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(429, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 134;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(428, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 32);
            this.label4.TabIndex = 133;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(428, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 132;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(428, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 131;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(428, 70);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 32);
            this.label16.TabIndex = 130;
            this.label16.Text = "Title";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(73, 311);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(164, 32);
            this.label17.TabIndex = 129;
            this.label17.Text = "Rental Zone";
            // 
            // VideoID
            // 
            this.VideoID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoID.Location = new System.Drawing.Point(196, 401);
            this.VideoID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VideoID.Name = "VideoID";
            this.VideoID.Size = new System.Drawing.Size(204, 38);
            this.VideoID.TabIndex = 128;
            // 
            // CustomerID
            // 
            this.CustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(196, 345);
            this.CustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(204, 38);
            this.CustomerID.TabIndex = 127;
            // 
            // ReturnVideo
            // 
            this.ReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnVideo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnVideo.Location = new System.Drawing.Point(196, 500);
            this.ReturnVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnVideo.Name = "ReturnVideo";
            this.ReturnVideo.Size = new System.Drawing.Size(204, 38);
            this.ReturnVideo.TabIndex = 126;
            // 
            // IssueVideo
            // 
            this.IssueVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueVideo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssueVideo.Location = new System.Drawing.Point(196, 454);
            this.IssueVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IssueVideo.Name = "IssueVideo";
            this.IssueVideo.Size = new System.Drawing.Size(204, 38);
            this.IssueVideo.TabIndex = 125;
            // 
            // rentalVideoDelete
            // 
            this.rentalVideoDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalVideoDelete.Location = new System.Drawing.Point(19, 596);
            this.rentalVideoDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rentalVideoDelete.Name = "rentalVideoDelete";
            this.rentalVideoDelete.Size = new System.Drawing.Size(365, 46);
            this.rentalVideoDelete.TabIndex = 124;
            this.rentalVideoDelete.Text = "Delete";
            this.rentalVideoDelete.UseVisualStyleBackColor = true;
            this.rentalVideoDelete.Click += new System.EventHandler(this.rentalVideoDelete_Click);
            // 
            // rentalReturnVideo
            // 
            this.rentalReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalReturnVideo.Location = new System.Drawing.Point(179, 549);
            this.rentalReturnVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rentalReturnVideo.Name = "rentalReturnVideo";
            this.rentalReturnVideo.Size = new System.Drawing.Size(205, 39);
            this.rentalReturnVideo.TabIndex = 123;
            this.rentalReturnVideo.Text = "Return";
            this.rentalReturnVideo.UseVisualStyleBackColor = true;
            this.rentalReturnVideo.Click += new System.EventHandler(this.rentalReturnVideo_Click);
            // 
            // rentalIssueVideo
            // 
            this.rentalIssueVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalIssueVideo.Location = new System.Drawing.Point(16, 549);
            this.rentalIssueVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rentalIssueVideo.Name = "rentalIssueVideo";
            this.rentalIssueVideo.Size = new System.Drawing.Size(135, 39);
            this.rentalIssueVideo.TabIndex = 122;
            this.rentalIssueVideo.Text = "Issue";
            this.rentalIssueVideo.UseVisualStyleBackColor = true;
            this.rentalIssueVideo.Click += new System.EventHandler(this.rentalIssueVideo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-1, 497);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 32);
            this.label12.TabIndex = 121;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(-1, 452);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 32);
            this.label13.TabIndex = 120;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(11, 405);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 32);
            this.label14.TabIndex = 119;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 354);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 32);
            this.label15.TabIndex = 118;
            this.label15.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 117;
            this.label1.Text = "Customer Zone";
            // 
            // delCustomer
            // 
            this.delCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCustomer.Location = new System.Drawing.Point(13, 255);
            this.delCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delCustomer.Name = "delCustomer";
            this.delCustomer.Size = new System.Drawing.Size(365, 46);
            this.delCustomer.TabIndex = 116;
            this.delCustomer.Text = "Delete";
            this.delCustomer.UseVisualStyleBackColor = true;
            this.delCustomer.Click += new System.EventHandler(this.delCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomer.Location = new System.Drawing.Point(173, 208);
            this.updateCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(205, 39);
            this.updateCustomer.TabIndex = 115;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(11, 208);
            this.addCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(135, 39);
            this.addCustomer.TabIndex = 112;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(173, 154);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(204, 38);
            this.Address.TabIndex = 114;
            // 
            // MobileNo
            // 
            this.MobileNo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNo.Location = new System.Drawing.Point(173, 106);
            this.MobileNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(204, 38);
            this.MobileNo.TabIndex = 113;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(173, 59);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(204, 38);
            this.TxtName.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 32);
            this.label8.TabIndex = 110;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 32);
            this.label9.TabIndex = 109;
            this.label9.Text = "Phone No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 59);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 32);
            this.label11.TabIndex = 108;
            this.label11.Text = " Name";
            // 
            // Record
            // 
            this.Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Record.Location = new System.Drawing.Point(776, 133);
            this.Record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Record.Name = "Record";
            this.Record.RowHeadersWidth = 51;
            this.Record.Size = new System.Drawing.Size(577, 314);
            this.Record.TabIndex = 149;
            this.Record.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Record_CellClick);
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.BackColor = System.Drawing.Color.Black;
            this.Customer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.ForeColor = System.Drawing.Color.White;
            this.Customer.Location = new System.Drawing.Point(809, 95);
            this.Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(140, 35);
            this.Customer.TabIndex = 150;
            this.Customer.TabStop = true;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = false;
            this.Customer.CheckedChanged += new System.EventHandler(this.Customer_CheckedChanged);
            // 
            // Video
            // 
            this.Video.AutoSize = true;
            this.Video.BackColor = System.Drawing.Color.Black;
            this.Video.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video.ForeColor = System.Drawing.Color.White;
            this.Video.Location = new System.Drawing.Point(964, 95);
            this.Video.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(99, 35);
            this.Video.TabIndex = 151;
            this.Video.TabStop = true;
            this.Video.Text = "Video";
            this.Video.UseVisualStyleBackColor = false;
            this.Video.CheckedChanged += new System.EventHandler(this.Video_CheckedChanged);
            // 
            // Rent
            // 
            this.Rent.AutoSize = true;
            this.Rent.BackColor = System.Drawing.Color.Black;
            this.Rent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.ForeColor = System.Drawing.Color.White;
            this.Rent.Location = new System.Drawing.Point(1076, 95);
            this.Rent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(107, 35);
            this.Rent.TabIndex = 152;
            this.Rent.TabStop = true;
            this.Rent.Text = "Rental";
            this.Rent.UseVisualStyleBackColor = false;
            this.Rent.CheckedChanged += new System.EventHandler(this.Rent_CheckedChanged);
            // 
            // Txtcost
            // 
            this.Txtcost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcost.Location = new System.Drawing.Point(563, 209);
            this.Txtcost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txtcost.Name = "Txtcost";
            this.Txtcost.Size = new System.Drawing.Size(204, 38);
            this.Txtcost.TabIndex = 153;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 46);
            this.button1.TabIndex = 154;
            this.button1.Text = "Video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1025, 473);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 46);
            this.button2.TabIndex = 155;
            this.button2.Text = "Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1395, 660);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txtcost);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.RentalID);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.delVideo);
            this.Controls.Add(this.updateVideo);
            this.Controls.Add(this.AddVideo);
            this.Controls.Add(this.TxtGenre);
            this.Controls.Add(this.TxtPlot);
            this.Controls.Add(this.TxtCopies);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtRatting);
            this.Controls.Add(this.Txttitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.VideoID);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.ReturnVideo);
            this.Controls.Add(this.IssueVideo);
            this.Controls.Add(this.rentalVideoDelete);
            this.Controls.Add(this.rentalReturnVideo);
            this.Controls.Add(this.rentalIssueVideo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delCustomer);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.MobileNo);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Record)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RentalID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button delVideo;
        private System.Windows.Forms.Button updateVideo;
        private System.Windows.Forms.Button AddVideo;
        private System.Windows.Forms.TextBox TxtGenre;
        private System.Windows.Forms.TextBox TxtPlot;
        private System.Windows.Forms.TextBox TxtCopies;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtRatting;
        private System.Windows.Forms.TextBox Txttitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox VideoID;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.DateTimePicker ReturnVideo;
        private System.Windows.Forms.DateTimePicker IssueVideo;
        private System.Windows.Forms.Button rentalVideoDelete;
        private System.Windows.Forms.Button rentalReturnVideo;
        private System.Windows.Forms.Button rentalIssueVideo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox MobileNo;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView Record;
        private System.Windows.Forms.RadioButton Customer;
        private System.Windows.Forms.RadioButton Video;
        private System.Windows.Forms.RadioButton Rent;
        private System.Windows.Forms.TextBox Txtcost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

