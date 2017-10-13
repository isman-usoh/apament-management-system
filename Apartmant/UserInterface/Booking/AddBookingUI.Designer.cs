namespace Apartment.UserInterface.Booking
{
    partial class AddBookingUI
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblStartStay = new System.Windows.Forms.Label();
            this.lblEndStay = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.cbxCustomerType = new System.Windows.Forms.ComboBox();
            this.customerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.cbxRoomType = new System.Windows.Forms.ComboBox();
            this.fKRoomTypesCustomerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpStarStay = new System.Windows.Forms.DateTimePicker();
            this.dtpEndStay = new System.Windows.Forms.DateTimePicker();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.fKRoomsRoomTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.customerTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter();
            this.roomTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.RoomTypesTableAdapter();
            this.roomsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.RoomsTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomTypesCustomerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomsRoomTypesBindingSource)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(10);
            this.lblHeader.Size = new System.Drawing.Size(634, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "จองห้องใหม่";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 366);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(626, 364);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้จอง";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblFirstname, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblLastname, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblAddress, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblTelephone, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.tbxFirstname, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbxAddress, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbxLastname, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbxTelephone, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.tbxEmail, 4, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblEmail, 3, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblProvince, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.cbxProvince, 2, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(614, 157);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblFirstname
            // 
            this.lblFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstname.Location = new System.Drawing.Point(5, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(119, 25);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "ชื่อ : ";
            this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastname
            // 
            this.lblLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastname.Location = new System.Drawing.Point(310, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(119, 25);
            this.lblLastname.TabIndex = 4;
            this.lblLastname.Text = "นามสกุล : ";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(5, 30);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(119, 50);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "ที่อยู่ : ";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTelephone
            // 
            this.lblTelephone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTelephone.Location = new System.Drawing.Point(5, 115);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(119, 25);
            this.lblTelephone.TabIndex = 2;
            this.lblTelephone.Text = "หมายเลขโทรศัพท์ : ";
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFirstname.Location = new System.Drawing.Point(130, 3);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(174, 20);
            this.tbxFirstname.TabIndex = 7;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAddress.Location = new System.Drawing.Point(130, 33);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(174, 44);
            this.tbxAddress.TabIndex = 8;
            // 
            // tbxLastname
            // 
            this.tbxLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLastname.Location = new System.Drawing.Point(435, 3);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(174, 20);
            this.tbxLastname.TabIndex = 9;
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTelephone.Location = new System.Drawing.Point(130, 118);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(174, 20);
            this.tbxTelephone.TabIndex = 12;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(435, 118);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(174, 20);
            this.tbxEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(310, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(119, 25);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "อีเมล์ : ";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProvince
            // 
            this.lblProvince.Location = new System.Drawing.Point(5, 85);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(119, 25);
            this.lblProvince.TabIndex = 3;
            this.lblProvince.Text = "จังหวัด : ";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxProvince
            // 
            this.cbxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Items.AddRange(new object[] {
            "กรุงเทพมหานคร ",
            "กระบี่ ",
            "กาญจนบุรี ",
            "กาฬสินธุ์ ",
            "กำแพงเพชร ",
            "ขอนแก่น ",
            "จันทบุรี ",
            "ฉะเชิงเทรา ",
            "ชลบุรี ",
            "ชัยนาท ",
            "ชัยภูมิ ",
            "ชุมพร ",
            "เชียงราย ",
            "เชียงใหม่ ",
            "ตรัง ",
            "ตราด ",
            "ตาก ",
            "นครนายก ",
            "นครปฐม ",
            "นครพนม ",
            "นครราชสีมา ",
            "นครศรีธรรมราช ",
            "นครสวรรค์ ",
            "นนทบุรี ",
            "นราธิวาส ",
            "น่าน ",
            "บึงกาฬ ",
            "บุรีรัมย์ ",
            "ปทุมธานี ",
            "ประจวบคีรีขันธ์ ",
            "ปราจีนบุรี ",
            "ปัตตานี ",
            "พระนครศรีอยุธยา ",
            "พังงา ",
            "พัทลุง ",
            "พิจิตร ",
            "พิษณุโลก ",
            "เพชรบุรี ",
            "เพชรบูรณ์ ",
            "แพร่ ",
            "พะเยา ",
            "ภูเก็ต ",
            "มหาสารคาม ",
            "มุกดาหาร ",
            "แม่ฮ่องสอน ",
            "ยะลา ",
            "ยโสธร ",
            "ร้อยเอ็ด ",
            "ระนอง ",
            "ระยอง ",
            "ราชบุรี ",
            "ลพบุรี ",
            "ลำปาง ",
            "ลำพูน ",
            "เลย ",
            "ศรีสะเกษ ",
            "สกลนคร ",
            "สงขลา ",
            "สตูล ",
            "สมุทรปราการ ",
            "สมุทรสงคราม ",
            "สมุทรสาคร ",
            "สระแก้ว ",
            "สระบุรี ",
            "สิงห์บุรี ",
            "สุโขทัย ",
            "สุพรรณบุรี ",
            "สุราษฎร์ธานี ",
            "สุรินทร์ ",
            "หนองคาย ",
            "หนองบัวลำภู ",
            "อ่างทอง ",
            "อุดรธานี ",
            "อุทัยธานี ",
            "อุตรดิตถ์ ",
            "อุบลราชธานี ",
            "อำนาจเจริญ",
            "อื่นๆ"});
            this.cbxProvince.Location = new System.Drawing.Point(130, 88);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(174, 21);
            this.cbxProvince.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลจองห้อง";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblCustomerType, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblRoomType, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblStartStay, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblEndStay, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblStatusLabel, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.cbxCustomerType, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbxRoomType, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpStarStay, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.dtpEndStay, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.cbxRoom, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblPriceLabel, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblPrice, 4, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(614, 157);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerType.Location = new System.Drawing.Point(5, 0);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(119, 25);
            this.lblCustomerType.TabIndex = 0;
            this.lblCustomerType.Text = "ประเภทผู้เช่า : ";
            this.lblCustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomType.Location = new System.Drawing.Point(310, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(119, 25);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "รูปแบบห้อง : ";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartStay
            // 
            this.lblStartStay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartStay.Location = new System.Drawing.Point(5, 30);
            this.lblStartStay.Name = "lblStartStay";
            this.lblStartStay.Size = new System.Drawing.Size(119, 25);
            this.lblStartStay.TabIndex = 2;
            this.lblStartStay.Text = "วันทีย้ายเข้า : ";
            this.lblStartStay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndStay
            // 
            this.lblEndStay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndStay.Location = new System.Drawing.Point(310, 30);
            this.lblEndStay.Name = "lblEndStay";
            this.lblEndStay.Size = new System.Drawing.Size(119, 25);
            this.lblEndStay.TabIndex = 3;
            this.lblEndStay.Text = "วันทีย้ายออก : ";
            this.lblEndStay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusLabel.Location = new System.Drawing.Point(5, 60);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(119, 25);
            this.lblStatusLabel.TabIndex = 4;
            this.lblStatusLabel.Text = "สถานะห้องเช่า : ";
            this.lblStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.DataSource = this.customerTypesBindingSource;
            this.cbxCustomerType.DisplayMember = "CustomerTypeName";
            this.cbxCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.Location = new System.Drawing.Point(130, 3);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(174, 21);
            this.cbxCustomerType.TabIndex = 6;
            this.cbxCustomerType.ValueMember = "CustomerTypeID";
            this.cbxCustomerType.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerType_SelectedIndexChanged);
            // 
            // customerTypesBindingSource
            // 
            this.customerTypesBindingSource.DataMember = "CustomerTypes";
            this.customerTypesBindingSource.DataSource = this.apartmentDataSet;
            // 
            // apartmentDataSet
            // 
            this.apartmentDataSet.DataSetName = "ApartmentDataSet";
            this.apartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxRoomType
            // 
            this.cbxRoomType.DataSource = this.fKRoomTypesCustomerTypesBindingSource;
            this.cbxRoomType.DisplayMember = "RoomTypeName";
            this.cbxRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomType.FormattingEnabled = true;
            this.cbxRoomType.Location = new System.Drawing.Point(435, 3);
            this.cbxRoomType.Name = "cbxRoomType";
            this.cbxRoomType.Size = new System.Drawing.Size(174, 21);
            this.cbxRoomType.TabIndex = 7;
            this.cbxRoomType.ValueMember = "RoomTypeID";
            // 
            // fKRoomTypesCustomerTypesBindingSource
            // 
            this.fKRoomTypesCustomerTypesBindingSource.DataMember = "FK_RoomTypes_CustomerTypes";
            this.fKRoomTypesCustomerTypesBindingSource.DataSource = this.customerTypesBindingSource;
            // 
            // dtpStarStay
            // 
            this.dtpStarStay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStarStay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStarStay.Location = new System.Drawing.Point(130, 33);
            this.dtpStarStay.Name = "dtpStarStay";
            this.dtpStarStay.Size = new System.Drawing.Size(174, 20);
            this.dtpStarStay.TabIndex = 8;
            this.dtpStarStay.ValueChanged += new System.EventHandler(this.dtpStarStay_ValueChanged);
            // 
            // dtpEndStay
            // 
            this.dtpEndStay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEndStay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndStay.Location = new System.Drawing.Point(435, 33);
            this.dtpEndStay.Name = "dtpEndStay";
            this.dtpEndStay.Size = new System.Drawing.Size(174, 20);
            this.dtpEndStay.TabIndex = 9;
            this.dtpEndStay.ValueChanged += new System.EventHandler(this.dtpEndStay_ValueChanged);
            // 
            // cbxRoom
            // 
            this.cbxRoom.DataSource = this.fKRoomsRoomTypesBindingSource;
            this.cbxRoom.DisplayMember = "No";
            this.cbxRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(130, 63);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(174, 21);
            this.cbxRoom.TabIndex = 10;
            this.cbxRoom.ValueMember = "RoomID";
            // 
            // fKRoomsRoomTypesBindingSource
            // 
            this.fKRoomsRoomTypesBindingSource.DataMember = "FK_Rooms_RoomTypes";
            this.fKRoomsRoomTypesBindingSource.DataSource = this.fKRoomTypesCustomerTypesBindingSource;
            // 
            // lblPriceLabel
            // 
            this.lblPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceLabel.Location = new System.Drawing.Point(310, 60);
            this.lblPriceLabel.Name = "lblPriceLabel";
            this.lblPriceLabel.Size = new System.Drawing.Size(119, 25);
            this.lblPriceLabel.TabIndex = 11;
            this.lblPriceLabel.Text = "ราคา : ";
            this.lblPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKRoomTypesCustomerTypesBindingSource, "Prices", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "C2"));
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(435, 60);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(174, 25);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "-";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 425);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(628, 29);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnBooking);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(314, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(314, 29);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(155, 3);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(75, 23);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "จอง";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(314, 29);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // customerTypesTableAdapter
            // 
            this.customerTypesTableAdapter.ClearBeforeFill = true;
            // 
            // roomTypesTableAdapter
            // 
            this.roomTypesTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // AddBookingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookingUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "จองห้องใหม่";
            this.Load += new System.EventHandler(this.BookingUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomTypesCustomerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomsRoomTypesBindingSource)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblStartStay;
        private System.Windows.Forms.Label lblEndStay;
        private System.Windows.Forms.ComboBox cbxCustomerType;
        private System.Windows.Forms.ComboBox cbxRoomType;
        private System.Windows.Forms.DateTimePicker dtpStarStay;
        private System.Windows.Forms.DateTimePicker dtpEndStay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Apartmant.Database.ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource customerTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter customerTypesTableAdapter;
        private System.Windows.Forms.BindingSource fKRoomTypesCustomerTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.RoomTypesTableAdapter roomTypesTableAdapter;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.BindingSource fKRoomsRoomTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.Label lblPriceLabel;
        private System.Windows.Forms.Label lblPrice;
    }
}