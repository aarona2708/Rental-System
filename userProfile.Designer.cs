
namespace CMPT_291_Project
{
    partial class userProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userProfile));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.moviesSearch = new System.Windows.Forms.Button();
            this.userMoviesDropdown = new System.Windows.Forms.ComboBox();
            this.custCred = new System.Windows.Forms.Label();
            this.custPhone = new System.Windows.Forms.Label();
            this.custZip = new System.Windows.Forms.Label();
            this.custState = new System.Windows.Forms.Label();
            this.custCity = new System.Windows.Forms.Label();
            this.custAddress = new System.Windows.Forms.Label();
            this.custDate = new System.Windows.Forms.Label();
            this.custPlan = new System.Windows.Forms.Label();
            this.custAcctNo = new System.Windows.Forms.Label();
            this.credText = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.Label();
            this.zipText = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.planText = new System.Windows.Forms.Label();
            this.acctNoText = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.userActivity = new System.Windows.Forms.ProgressBar();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.Button();
            this.editDeleteMsg = new System.Windows.Forms.Label();
            this.doneEdit = new System.Windows.Forms.Button();
            this.editUser = new System.Windows.Forms.Button();
            this.userCredEmp = new System.Windows.Forms.Label();
            this.userPhoneEmp = new System.Windows.Forms.Label();
            this.userZipEmp = new System.Windows.Forms.Label();
            this.userStateEmp = new System.Windows.Forms.Label();
            this.userCityEmp = new System.Windows.Forms.Label();
            this.userAddressEmp = new System.Windows.Forms.Label();
            this.userDateEmp = new System.Windows.Forms.Label();
            this.userPlanEmp = new System.Windows.Forms.Label();
            this.userAcctNoEmp = new System.Windows.Forms.Label();
            this.changePlan = new System.Windows.Forms.TextBox();
            this.changeDate = new System.Windows.Forms.DateTimePicker();
            this.changeAddress = new System.Windows.Forms.TextBox();
            this.changeCity = new System.Windows.Forms.TextBox();
            this.changeState = new System.Windows.Forms.TextBox();
            this.changeZip = new System.Windows.Forms.TextBox();
            this.changePhone = new System.Windows.Forms.TextBox();
            this.changeCred = new System.Windows.Forms.TextBox();
            this.changeLast = new System.Windows.Forms.TextBox();
            this.changeFirst = new System.Windows.Forms.TextBox();
            this.userSettings = new System.Windows.Forms.Button();
            this.MovieLists = new System.Windows.Forms.DataGridView();
            this.gridMovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMovieGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMovieCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieLists)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesSearch
            // 
            this.moviesSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesSearch.Location = new System.Drawing.Point(262, 520);
            this.moviesSearch.Name = "moviesSearch";
            this.moviesSearch.Size = new System.Drawing.Size(71, 28);
            this.moviesSearch.TabIndex = 397;
            this.moviesSearch.Text = "Search";
            this.moviesSearch.UseVisualStyleBackColor = true;
            this.moviesSearch.Visible = false;
            this.moviesSearch.Click += new System.EventHandler(this.moviesSearch_Click);
            // 
            // userMoviesDropdown
            // 
            this.userMoviesDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMoviesDropdown.FormattingEnabled = true;
            this.userMoviesDropdown.Location = new System.Drawing.Point(18, 521);
            this.userMoviesDropdown.Name = "userMoviesDropdown";
            this.userMoviesDropdown.Size = new System.Drawing.Size(238, 28);
            this.userMoviesDropdown.TabIndex = 396;
            this.userMoviesDropdown.Visible = false;
            // 
            // custCred
            // 
            this.custCred.AutoSize = true;
            this.custCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.custCred.Location = new System.Drawing.Point(630, 387);
            this.custCred.Name = "custCred";
            this.custCred.Size = new System.Drawing.Size(95, 20);
            this.custCred.TabIndex = 371;
            this.custCred.Text = "Cred. No: ";
            this.custCred.Visible = false;
            // 
            // custPhone
            // 
            this.custPhone.AutoSize = true;
            this.custPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.custPhone.Location = new System.Drawing.Point(630, 354);
            this.custPhone.Name = "custPhone";
            this.custPhone.Size = new System.Drawing.Size(96, 20);
            this.custPhone.TabIndex = 370;
            this.custPhone.Text = "Phone No:";
            this.custPhone.Visible = false;
            // 
            // custZip
            // 
            this.custZip.AutoSize = true;
            this.custZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.custZip.Location = new System.Drawing.Point(630, 321);
            this.custZip.Name = "custZip";
            this.custZip.Size = new System.Drawing.Size(89, 20);
            this.custZip.TabIndex = 369;
            this.custZip.Text = "Zip Code:";
            this.custZip.Visible = false;
            // 
            // custState
            // 
            this.custState.AutoSize = true;
            this.custState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.custState.Location = new System.Drawing.Point(630, 288);
            this.custState.Name = "custState";
            this.custState.Size = new System.Drawing.Size(59, 20);
            this.custState.TabIndex = 368;
            this.custState.Text = "State:";
            this.custState.Visible = false;
            // 
            // custCity
            // 
            this.custCity.AutoSize = true;
            this.custCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.custCity.Location = new System.Drawing.Point(630, 255);
            this.custCity.Name = "custCity";
            this.custCity.Size = new System.Drawing.Size(48, 20);
            this.custCity.TabIndex = 367;
            this.custCity.Text = "City:";
            this.custCity.Visible = false;
            // 
            // custAddress
            // 
            this.custAddress.AutoSize = true;
            this.custAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.custAddress.Location = new System.Drawing.Point(630, 222);
            this.custAddress.Name = "custAddress";
            this.custAddress.Size = new System.Drawing.Size(84, 20);
            this.custAddress.TabIndex = 366;
            this.custAddress.Text = "Address:";
            this.custAddress.Visible = false;
            // 
            // custDate
            // 
            this.custDate.AutoSize = true;
            this.custDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.custDate.Location = new System.Drawing.Point(630, 188);
            this.custDate.Name = "custDate";
            this.custDate.Size = new System.Drawing.Size(127, 20);
            this.custDate.TabIndex = 365;
            this.custDate.Text = "Date Created:";
            this.custDate.Visible = false;
            // 
            // custPlan
            // 
            this.custPlan.AutoSize = true;
            this.custPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.custPlan.Location = new System.Drawing.Point(630, 155);
            this.custPlan.Name = "custPlan";
            this.custPlan.Size = new System.Drawing.Size(52, 20);
            this.custPlan.TabIndex = 364;
            this.custPlan.Text = "Plan:";
            this.custPlan.Visible = false;
            // 
            // custAcctNo
            // 
            this.custAcctNo.AutoSize = true;
            this.custAcctNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.custAcctNo.Location = new System.Drawing.Point(630, 122);
            this.custAcctNo.Name = "custAcctNo";
            this.custAcctNo.Size = new System.Drawing.Size(87, 20);
            this.custAcctNo.TabIndex = 363;
            this.custAcctNo.Text = "Acct. No:";
            this.custAcctNo.Visible = false;
            // 
            // credText
            // 
            this.credText.AutoSize = true;
            this.credText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.credText.Location = new System.Drawing.Point(490, 387);
            this.credText.Name = "credText";
            this.credText.Size = new System.Drawing.Size(95, 20);
            this.credText.TabIndex = 362;
            this.credText.Text = "Cred. No: ";
            this.credText.Visible = false;
            // 
            // phoneText
            // 
            this.phoneText.AutoSize = true;
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.phoneText.Location = new System.Drawing.Point(490, 354);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(96, 20);
            this.phoneText.TabIndex = 361;
            this.phoneText.Text = "Phone No:";
            this.phoneText.Visible = false;
            // 
            // zipText
            // 
            this.zipText.AutoSize = true;
            this.zipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.zipText.Location = new System.Drawing.Point(490, 321);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(89, 20);
            this.zipText.TabIndex = 360;
            this.zipText.Text = "Zip Code:";
            this.zipText.Visible = false;
            // 
            // stateText
            // 
            this.stateText.AutoSize = true;
            this.stateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.stateText.Location = new System.Drawing.Point(490, 288);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(59, 20);
            this.stateText.TabIndex = 359;
            this.stateText.Text = "State:";
            this.stateText.Visible = false;
            // 
            // cityText
            // 
            this.cityText.AutoSize = true;
            this.cityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.cityText.Location = new System.Drawing.Point(490, 255);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(48, 20);
            this.cityText.TabIndex = 358;
            this.cityText.Text = "City:";
            this.cityText.Visible = false;
            // 
            // addressText
            // 
            this.addressText.AutoSize = true;
            this.addressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.addressText.Location = new System.Drawing.Point(490, 222);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(84, 20);
            this.addressText.TabIndex = 357;
            this.addressText.Text = "Address:";
            this.addressText.Visible = false;
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.dateText.Location = new System.Drawing.Point(490, 188);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(127, 20);
            this.dateText.TabIndex = 356;
            this.dateText.Text = "Date Created:";
            this.dateText.Visible = false;
            // 
            // planText
            // 
            this.planText.AutoSize = true;
            this.planText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.planText.Location = new System.Drawing.Point(490, 155);
            this.planText.Name = "planText";
            this.planText.Size = new System.Drawing.Size(52, 20);
            this.planText.TabIndex = 355;
            this.planText.Text = "Plan:";
            this.planText.Visible = false;
            // 
            // acctNoText
            // 
            this.acctNoText.AutoSize = true;
            this.acctNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.acctNoText.Location = new System.Drawing.Point(490, 122);
            this.acctNoText.Name = "acctNoText";
            this.acctNoText.Size = new System.Drawing.Size(87, 20);
            this.acctNoText.TabIndex = 354;
            this.acctNoText.Text = "Acct. No:";
            this.acctNoText.Visible = false;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.customerName.Location = new System.Drawing.Point(477, 75);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(90, 31);
            this.customerName.TabIndex = 353;
            this.customerName.Text = "Name";
            this.customerName.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(896, 41);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(61, 27);
            this.backButton.TabIndex = 347;
            this.backButton.Text = "Log  Out";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // userActivity
            // 
            this.userActivity.Location = new System.Drawing.Point(837, 201);
            this.userActivity.Name = "userActivity";
            this.userActivity.Size = new System.Drawing.Size(120, 15);
            this.userActivity.TabIndex = 346;
            this.userActivity.Value = 50;
            this.userActivity.Visible = false;
            // 
            // userPic
            // 
            this.userPic.Image = ((System.Drawing.Image)(resources.GetObject("userPic.Image")));
            this.userPic.Location = new System.Drawing.Point(837, 75);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(120, 120);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPic.TabIndex = 345;
            this.userPic.TabStop = false;
            this.userPic.Visible = false;
            // 
            // settings
            // 
            this.settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.Location = new System.Drawing.Point(896, 42);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(61, 27);
            this.settings.TabIndex = 344;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Visible = false;
            // 
            // editDeleteMsg
            // 
            this.editDeleteMsg.AutoSize = true;
            this.editDeleteMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDeleteMsg.Location = new System.Drawing.Point(839, 255);
            this.editDeleteMsg.Name = "editDeleteMsg";
            this.editDeleteMsg.Size = new System.Drawing.Size(50, 13);
            this.editDeleteMsg.TabIndex = 394;
            this.editDeleteMsg.Text = "Message";
            this.editDeleteMsg.Visible = false;
            // 
            // doneEdit
            // 
            this.doneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.doneEdit.Location = new System.Drawing.Point(750, 413);
            this.doneEdit.Name = "doneEdit";
            this.doneEdit.Size = new System.Drawing.Size(61, 28);
            this.doneEdit.TabIndex = 393;
            this.doneEdit.Text = "Done";
            this.doneEdit.UseVisualStyleBackColor = true;
            this.doneEdit.Visible = false;
            // 
            // editUser
            // 
            this.editUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUser.Location = new System.Drawing.Point(839, 222);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(55, 28);
            this.editUser.TabIndex = 392;
            this.editUser.Text = "Edit";
            this.editUser.UseVisualStyleBackColor = true;
            this.editUser.Visible = false;
            // 
            // userCredEmp
            // 
            this.userCredEmp.AutoSize = true;
            this.userCredEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.userCredEmp.Location = new System.Drawing.Point(490, 387);
            this.userCredEmp.Name = "userCredEmp";
            this.userCredEmp.Size = new System.Drawing.Size(95, 20);
            this.userCredEmp.TabIndex = 380;
            this.userCredEmp.Text = "Cred. No: ";
            this.userCredEmp.Visible = false;
            // 
            // userPhoneEmp
            // 
            this.userPhoneEmp.AutoSize = true;
            this.userPhoneEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.userPhoneEmp.Location = new System.Drawing.Point(490, 354);
            this.userPhoneEmp.Name = "userPhoneEmp";
            this.userPhoneEmp.Size = new System.Drawing.Size(96, 20);
            this.userPhoneEmp.TabIndex = 379;
            this.userPhoneEmp.Text = "Phone No:";
            this.userPhoneEmp.Visible = false;
            // 
            // userZipEmp
            // 
            this.userZipEmp.AutoSize = true;
            this.userZipEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.userZipEmp.Location = new System.Drawing.Point(490, 321);
            this.userZipEmp.Name = "userZipEmp";
            this.userZipEmp.Size = new System.Drawing.Size(89, 20);
            this.userZipEmp.TabIndex = 378;
            this.userZipEmp.Text = "Zip Code:";
            this.userZipEmp.Visible = false;
            // 
            // userStateEmp
            // 
            this.userStateEmp.AutoSize = true;
            this.userStateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.userStateEmp.Location = new System.Drawing.Point(490, 288);
            this.userStateEmp.Name = "userStateEmp";
            this.userStateEmp.Size = new System.Drawing.Size(59, 20);
            this.userStateEmp.TabIndex = 377;
            this.userStateEmp.Text = "State:";
            this.userStateEmp.Visible = false;
            // 
            // userCityEmp
            // 
            this.userCityEmp.AutoSize = true;
            this.userCityEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.userCityEmp.Location = new System.Drawing.Point(490, 255);
            this.userCityEmp.Name = "userCityEmp";
            this.userCityEmp.Size = new System.Drawing.Size(48, 20);
            this.userCityEmp.TabIndex = 376;
            this.userCityEmp.Text = "City:";
            this.userCityEmp.Visible = false;
            // 
            // userAddressEmp
            // 
            this.userAddressEmp.AutoSize = true;
            this.userAddressEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.userAddressEmp.Location = new System.Drawing.Point(490, 222);
            this.userAddressEmp.Name = "userAddressEmp";
            this.userAddressEmp.Size = new System.Drawing.Size(84, 20);
            this.userAddressEmp.TabIndex = 375;
            this.userAddressEmp.Text = "Address:";
            this.userAddressEmp.Visible = false;
            // 
            // userDateEmp
            // 
            this.userDateEmp.AutoSize = true;
            this.userDateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.userDateEmp.Location = new System.Drawing.Point(490, 188);
            this.userDateEmp.Name = "userDateEmp";
            this.userDateEmp.Size = new System.Drawing.Size(127, 20);
            this.userDateEmp.TabIndex = 374;
            this.userDateEmp.Text = "Date Created:";
            this.userDateEmp.Visible = false;
            // 
            // userPlanEmp
            // 
            this.userPlanEmp.AutoSize = true;
            this.userPlanEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.userPlanEmp.Location = new System.Drawing.Point(490, 155);
            this.userPlanEmp.Name = "userPlanEmp";
            this.userPlanEmp.Size = new System.Drawing.Size(52, 20);
            this.userPlanEmp.TabIndex = 373;
            this.userPlanEmp.Text = "Plan:";
            this.userPlanEmp.Visible = false;
            // 
            // userAcctNoEmp
            // 
            this.userAcctNoEmp.AutoSize = true;
            this.userAcctNoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.userAcctNoEmp.Location = new System.Drawing.Point(490, 122);
            this.userAcctNoEmp.Name = "userAcctNoEmp";
            this.userAcctNoEmp.Size = new System.Drawing.Size(87, 20);
            this.userAcctNoEmp.TabIndex = 372;
            this.userAcctNoEmp.Text = "Acct. No:";
            this.userAcctNoEmp.Visible = false;
            // 
            // changePlan
            // 
            this.changePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePlan.Location = new System.Drawing.Point(625, 154);
            this.changePlan.Name = "changePlan";
            this.changePlan.Size = new System.Drawing.Size(186, 20);
            this.changePlan.TabIndex = 382;
            this.changePlan.Visible = false;
            // 
            // changeDate
            // 
            this.changeDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDate.Location = new System.Drawing.Point(625, 188);
            this.changeDate.Name = "changeDate";
            this.changeDate.Size = new System.Drawing.Size(186, 20);
            this.changeDate.TabIndex = 388;
            this.changeDate.Visible = false;
            // 
            // changeAddress
            // 
            this.changeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAddress.Location = new System.Drawing.Point(625, 221);
            this.changeAddress.Name = "changeAddress";
            this.changeAddress.Size = new System.Drawing.Size(186, 20);
            this.changeAddress.TabIndex = 383;
            this.changeAddress.Visible = false;
            // 
            // changeCity
            // 
            this.changeCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCity.Location = new System.Drawing.Point(625, 254);
            this.changeCity.Name = "changeCity";
            this.changeCity.Size = new System.Drawing.Size(186, 20);
            this.changeCity.TabIndex = 384;
            this.changeCity.Visible = false;
            // 
            // changeState
            // 
            this.changeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeState.Location = new System.Drawing.Point(625, 287);
            this.changeState.Name = "changeState";
            this.changeState.Size = new System.Drawing.Size(186, 20);
            this.changeState.TabIndex = 385;
            this.changeState.Visible = false;
            // 
            // changeZip
            // 
            this.changeZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeZip.Location = new System.Drawing.Point(625, 319);
            this.changeZip.Name = "changeZip";
            this.changeZip.Size = new System.Drawing.Size(186, 20);
            this.changeZip.TabIndex = 386;
            this.changeZip.Visible = false;
            // 
            // changePhone
            // 
            this.changePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePhone.Location = new System.Drawing.Point(625, 353);
            this.changePhone.Name = "changePhone";
            this.changePhone.Size = new System.Drawing.Size(186, 20);
            this.changePhone.TabIndex = 381;
            this.changePhone.Visible = false;
            // 
            // changeCred
            // 
            this.changeCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCred.Location = new System.Drawing.Point(625, 386);
            this.changeCred.Name = "changeCred";
            this.changeCred.Size = new System.Drawing.Size(186, 20);
            this.changeCred.TabIndex = 387;
            this.changeCred.Visible = false;
            // 
            // changeLast
            // 
            this.changeLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLast.Location = new System.Drawing.Point(574, 75);
            this.changeLast.Name = "changeLast";
            this.changeLast.Size = new System.Drawing.Size(127, 38);
            this.changeLast.TabIndex = 390;
            this.changeLast.Text = "Surname";
            this.changeLast.Visible = false;
            // 
            // changeFirst
            // 
            this.changeFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeFirst.Location = new System.Drawing.Point(477, 75);
            this.changeFirst.Name = "changeFirst";
            this.changeFirst.Size = new System.Drawing.Size(91, 38);
            this.changeFirst.TabIndex = 389;
            this.changeFirst.Text = "Name";
            this.changeFirst.Visible = false;
            // 
            // userSettings
            // 
            this.userSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSettings.Location = new System.Drawing.Point(896, 222);
            this.userSettings.Name = "userSettings";
            this.userSettings.Size = new System.Drawing.Size(61, 27);
            this.userSettings.TabIndex = 349;
            this.userSettings.Text = "Settings";
            this.userSettings.UseVisualStyleBackColor = true;
            this.userSettings.Visible = false;
            this.userSettings.Click += new System.EventHandler(this.userSettings_Click);
            // 
            // MovieLists
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MovieLists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.MovieLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridMovieID,
            this.gridMovieTitle,
            this.gridMovieGenre,
            this.gridMovieCopies});
            this.MovieLists.Location = new System.Drawing.Point(18, 65);
            this.MovieLists.Name = "MovieLists";
            this.MovieLists.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.MovieLists.Size = new System.Drawing.Size(453, 420);
            this.MovieLists.TabIndex = 395;
            this.MovieLists.Visible = false;
            // 
            // gridMovieID
            // 
            this.gridMovieID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridMovieID.DefaultCellStyle = dataGridViewCellStyle27;
            this.gridMovieID.HeaderText = "ID";
            this.gridMovieID.Name = "gridMovieID";
            this.gridMovieID.Width = 69;
            // 
            // gridMovieTitle
            // 
            this.gridMovieTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridMovieTitle.DefaultCellStyle = dataGridViewCellStyle28;
            this.gridMovieTitle.HeaderText = "Title";
            this.gridMovieTitle.Name = "gridMovieTitle";
            this.gridMovieTitle.Width = 96;
            // 
            // gridMovieGenre
            // 
            this.gridMovieGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridMovieGenre.DefaultCellStyle = dataGridViewCellStyle29;
            this.gridMovieGenre.HeaderText = "Genre";
            this.gridMovieGenre.Name = "gridMovieGenre";
            this.gridMovieGenre.Width = 119;
            // 
            // gridMovieCopies
            // 
            this.gridMovieCopies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridMovieCopies.DefaultCellStyle = dataGridViewCellStyle30;
            this.gridMovieCopies.HeaderText = "Copies";
            this.gridMovieCopies.Name = "gridMovieCopies";
            this.gridMovieCopies.Width = 130;
            // 
            // deleteUser
            // 
            this.deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUser.Location = new System.Drawing.Point(900, 222);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(59, 28);
            this.deleteUser.TabIndex = 391;
            this.deleteUser.Text = "Delete";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Visible = false;
            // 
            // userProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 561);
            this.Controls.Add(this.moviesSearch);
            this.Controls.Add(this.userMoviesDropdown);
            this.Controls.Add(this.custCred);
            this.Controls.Add(this.custPhone);
            this.Controls.Add(this.custZip);
            this.Controls.Add(this.custState);
            this.Controls.Add(this.custCity);
            this.Controls.Add(this.custAddress);
            this.Controls.Add(this.custDate);
            this.Controls.Add(this.custPlan);
            this.Controls.Add(this.custAcctNo);
            this.Controls.Add(this.credText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.zipText);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.planText);
            this.Controls.Add(this.acctNoText);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.userActivity);
            this.Controls.Add(this.userPic);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.editDeleteMsg);
            this.Controls.Add(this.doneEdit);
            this.Controls.Add(this.editUser);
            this.Controls.Add(this.userCredEmp);
            this.Controls.Add(this.userPhoneEmp);
            this.Controls.Add(this.userZipEmp);
            this.Controls.Add(this.userStateEmp);
            this.Controls.Add(this.userCityEmp);
            this.Controls.Add(this.userAddressEmp);
            this.Controls.Add(this.userDateEmp);
            this.Controls.Add(this.userPlanEmp);
            this.Controls.Add(this.userAcctNoEmp);
            this.Controls.Add(this.changePlan);
            this.Controls.Add(this.changeDate);
            this.Controls.Add(this.changeAddress);
            this.Controls.Add(this.changeCity);
            this.Controls.Add(this.changeState);
            this.Controls.Add(this.changeZip);
            this.Controls.Add(this.changePhone);
            this.Controls.Add(this.changeCred);
            this.Controls.Add(this.changeLast);
            this.Controls.Add(this.changeFirst);
            this.Controls.Add(this.userSettings);
            this.Controls.Add(this.MovieLists);
            this.Controls.Add(this.deleteUser);
            this.Name = "userProfile";
            this.Text = "userProfile";
            this.Load += new System.EventHandler(this.userProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieLists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moviesSearch;
        private System.Windows.Forms.ComboBox userMoviesDropdown;
        private System.Windows.Forms.Label custCred;
        private System.Windows.Forms.Label custPhone;
        private System.Windows.Forms.Label custZip;
        private System.Windows.Forms.Label custState;
        private System.Windows.Forms.Label custCity;
        private System.Windows.Forms.Label custAddress;
        private System.Windows.Forms.Label custDate;
        private System.Windows.Forms.Label custPlan;
        private System.Windows.Forms.Label custAcctNo;
        private System.Windows.Forms.Label credText;
        private System.Windows.Forms.Label phoneText;
        private System.Windows.Forms.Label zipText;
        private System.Windows.Forms.Label stateText;
        private System.Windows.Forms.Label cityText;
        private System.Windows.Forms.Label addressText;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Label planText;
        private System.Windows.Forms.Label acctNoText;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ProgressBar userActivity;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Label editDeleteMsg;
        private System.Windows.Forms.Button doneEdit;
        private System.Windows.Forms.Button editUser;
        private System.Windows.Forms.Label userCredEmp;
        private System.Windows.Forms.Label userPhoneEmp;
        private System.Windows.Forms.Label userZipEmp;
        private System.Windows.Forms.Label userStateEmp;
        private System.Windows.Forms.Label userCityEmp;
        private System.Windows.Forms.Label userAddressEmp;
        private System.Windows.Forms.Label userDateEmp;
        private System.Windows.Forms.Label userPlanEmp;
        private System.Windows.Forms.Label userAcctNoEmp;
        private System.Windows.Forms.TextBox changePlan;
        private System.Windows.Forms.DateTimePicker changeDate;
        private System.Windows.Forms.TextBox changeAddress;
        private System.Windows.Forms.TextBox changeCity;
        private System.Windows.Forms.TextBox changeState;
        private System.Windows.Forms.TextBox changeZip;
        private System.Windows.Forms.TextBox changePhone;
        private System.Windows.Forms.TextBox changeCred;
        private System.Windows.Forms.TextBox changeLast;
        private System.Windows.Forms.TextBox changeFirst;
        private System.Windows.Forms.Button userSettings;
        private System.Windows.Forms.DataGridView MovieLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMovieGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMovieCopies;
        private System.Windows.Forms.Button deleteUser;
    }
}