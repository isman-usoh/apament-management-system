
using System;
namespace Apartment.UserInterface.Room
{
    partial class RoomManageUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRoomManager = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fKRoomTypesCustomerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.statusDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.flowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.builderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKRoomsRoomTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.cbxCustomertype = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cbxRoomType = new System.Windows.Forms.ComboBox();
            this.customerTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter();
            this.roomTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.RoomTypesTableAdapter();
            this.roomsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.RoomsTableAdapter();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomTypesCustomerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomsRoomTypesBindingSource)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 50);
            this.panel2.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(10);
            this.lblHeader.Size = new System.Drawing.Size(534, 50);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "จัดการห้องเช่า";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 376);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(534, 35);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnRoomManager);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(261, 29);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // btnRoomManager
            // 
            this.btnRoomManager.Location = new System.Drawing.Point(3, 3);
            this.btnRoomManager.Name = "btnRoomManager";
            this.btnRoomManager.Size = new System.Drawing.Size(117, 23);
            this.btnRoomManager.TabIndex = 0;
            this.btnRoomManager.Text = "จัดการประเภทห้อง";
            this.btnRoomManager.UseVisualStyleBackColor = true;
            this.btnRoomManager.Click += new System.EventHandler(this.btnRoomManager_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnClose);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(270, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(261, 29);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(183, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ปิด";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 320);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dgvRoomList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(526, 318);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddRoom);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 286);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 29);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(3, 3);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(80, 23);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "เพิ่มห้อง";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AllowUserToAddRows = false;
            this.dgvRoomList.AllowUserToDeleteRows = false;
            this.dgvRoomList.AutoGenerateColumns = false;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.roomTypeIDDataGridViewComboBoxColumn,
            this.statusDataGridViewComboBoxColumn,
            this.flowDataGridViewTextBoxColumn,
            this.builderDataGridViewTextBoxColumn});
            this.dgvRoomList.DataSource = this.fKRoomsRoomTypesBindingSource;
            this.dgvRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomList.Location = new System.Drawing.Point(3, 38);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.ReadOnly = true;
            this.dgvRoomList.Size = new System.Drawing.Size(520, 242);
            this.dgvRoomList.TabIndex = 1;
            this.dgvRoomList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoomList_CellMouseDoubleClick);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "หมายเลข";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeIDDataGridViewComboBoxColumn
            // 
            this.roomTypeIDDataGridViewComboBoxColumn.DataPropertyName = "RoomTypeID";
            this.roomTypeIDDataGridViewComboBoxColumn.DataSource = this.fKRoomTypesCustomerTypesBindingSource;
            this.roomTypeIDDataGridViewComboBoxColumn.DisplayMember = "RoomTypeName";
            this.roomTypeIDDataGridViewComboBoxColumn.HeaderText = "ประเภทห้อง";
            this.roomTypeIDDataGridViewComboBoxColumn.Name = "roomTypeIDDataGridViewComboBoxColumn";
            this.roomTypeIDDataGridViewComboBoxColumn.ReadOnly = true;
            this.roomTypeIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomTypeIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roomTypeIDDataGridViewComboBoxColumn.ValueMember = "RoomTypeID";
            // 
            // fKRoomTypesCustomerTypesBindingSource
            // 
            this.fKRoomTypesCustomerTypesBindingSource.DataMember = "FK_RoomTypes_CustomerTypes";
            this.fKRoomTypesCustomerTypesBindingSource.DataSource = this.customerTypesBindingSource;
            // 
            // customerTypesBindingSource
            // 
            this.customerTypesBindingSource.DataMember = "CustomerTypes";
            this.customerTypesBindingSource.DataSource = this.apartmentDataSet;
            // 
            // apartmentDataSet
            // 
            this.apartmentDataSet.DataSetName = "ApartmentDataSet";
            this.apartmentDataSet.Locale = new System.Globalization.CultureInfo("th");
            this.apartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusDataGridViewComboBoxColumn
            // 
            this.statusDataGridViewComboBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewComboBoxColumn.HeaderText = "สถานะ";
            this.statusDataGridViewComboBoxColumn.Name = "statusDataGridViewComboBoxColumn";
            this.statusDataGridViewComboBoxColumn.ReadOnly = true;
            this.statusDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // flowDataGridViewTextBoxColumn
            // 
            this.flowDataGridViewTextBoxColumn.DataPropertyName = "Flow";
            this.flowDataGridViewTextBoxColumn.HeaderText = "ชั้น";
            this.flowDataGridViewTextBoxColumn.Name = "flowDataGridViewTextBoxColumn";
            this.flowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // builderDataGridViewTextBoxColumn
            // 
            this.builderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.builderDataGridViewTextBoxColumn.DataPropertyName = "Builder";
            this.builderDataGridViewTextBoxColumn.HeaderText = "อาคาร";
            this.builderDataGridViewTextBoxColumn.Name = "builderDataGridViewTextBoxColumn";
            this.builderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKRoomsRoomTypesBindingSource
            // 
            this.fKRoomsRoomTypesBindingSource.DataMember = "FK_Rooms_RoomTypes";
            this.fKRoomsRoomTypesBindingSource.DataSource = this.fKRoomTypesCustomerTypesBindingSource;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblCustomerType);
            this.flowLayoutPanel3.Controls.Add(this.cbxCustomertype);
            this.flowLayoutPanel3.Controls.Add(this.lblRoomType);
            this.flowLayoutPanel3.Controls.Add(this.cbxRoomType);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(520, 29);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomerType.Location = new System.Drawing.Point(3, 0);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(90, 25);
            this.lblCustomerType.TabIndex = 0;
            this.lblCustomerType.Text = "ประเภทผู้เช่า : ";
            this.lblCustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCustomertype
            // 
            this.cbxCustomertype.DataSource = this.customerTypesBindingSource;
            this.cbxCustomertype.DisplayMember = "CustomerTypeName";
            this.cbxCustomertype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCustomertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomertype.FormattingEnabled = true;
            this.cbxCustomertype.Location = new System.Drawing.Point(99, 3);
            this.cbxCustomertype.Name = "cbxCustomertype";
            this.cbxCustomertype.Size = new System.Drawing.Size(120, 21);
            this.cbxCustomertype.TabIndex = 1;
            this.cbxCustomertype.ValueMember = "CustomerTypeName";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomType.Location = new System.Drawing.Point(225, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(86, 25);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "รูปแบบห้องเช่า : ";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRoomType
            // 
            this.cbxRoomType.DataSource = this.fKRoomTypesCustomerTypesBindingSource;
            this.cbxRoomType.DisplayMember = "RoomTypeName";
            this.cbxRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomType.FormattingEnabled = true;
            this.cbxRoomType.Location = new System.Drawing.Point(317, 3);
            this.cbxRoomType.Name = "cbxRoomType";
            this.cbxRoomType.Size = new System.Drawing.Size(120, 21);
            this.cbxRoomType.TabIndex = 3;
            this.cbxRoomType.ValueMember = "RoomTypeID";
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
            // RoomManageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "RoomManageUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "จัดการห้องเช่า";
            this.Load += new System.EventHandler(this.RoomManageUI_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomTypesCustomerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomsRoomTypesBindingSource)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.ComboBox cbxCustomertype;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cbxRoomType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnRoomManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddRoom;
        private Apartmant.Database.ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource customerTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter customerTypesTableAdapter;
        private System.Windows.Forms.BindingSource fKRoomTypesCustomerTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.RoomTypesTableAdapter roomTypesTableAdapter;
        private System.Windows.Forms.BindingSource fKRoomsRoomTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn roomTypeIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn builderDataGridViewTextBoxColumn;

    }
}