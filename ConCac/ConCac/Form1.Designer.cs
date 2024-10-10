namespace ConCac
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
            this.components = new System.ComponentModel.Container();
            this.qLSVDataSet = new ConCac.QLSVDataSet();
            this.dSSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSVTableAdapter = new ConCac.QLSVDataSetTableAdapters.DSSVTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.txbMSV = new System.Windows.Forms.TextBox();
            this.txbHoSV = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.dataSV = new System.Windows.Forms.DataGridView();
            this.mãSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.họSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giớiTínhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSV)).BeginInit();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSSVBindingSource
            // 
            this.dSSVBindingSource.DataMember = "DSSV";
            this.dSSVBindingSource.DataSource = this.qLSVDataSet;
            // 
            // dSSVTableAdapter
            // 
            this.dSSVTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên sinh viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mã khoa";
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNam.Location = new System.Drawing.Point(290, 122);
            this.rbtNam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(58, 22);
            this.rbtNam.TabIndex = 9;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // txbMSV
            // 
            this.txbMSV.Location = new System.Drawing.Point(109, 57);
            this.txbMSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbMSV.Name = "txbMSV";
            this.txbMSV.Size = new System.Drawing.Size(87, 21);
            this.txbMSV.TabIndex = 10;
            // 
            // txbHoSV
            // 
            this.txbHoSV.Location = new System.Drawing.Point(317, 58);
            this.txbHoSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbHoSV.Name = "txbHoSV";
            this.txbHoSV.Size = new System.Drawing.Size(110, 21);
            this.txbHoSV.TabIndex = 11;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(541, 57);
            this.txbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(110, 21);
            this.txbName.TabIndex = 12;
            this.txbName.Text = "         ";
            // 
            // date
            // 
            this.date.CustomFormat = "dd/MM/yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(92, 122);
            this.date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(104, 21);
            this.date.TabIndex = 13;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNu.Location = new System.Drawing.Point(362, 121);
            this.rbtNu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(45, 22);
            this.rbtNu.TabIndex = 14;
            this.rbtNu.TabStop = true;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // cboMaKhoa
            // 
            this.cboMaKhoa.FormattingEnabled = true;
            this.cboMaKhoa.Location = new System.Drawing.Point(496, 120);
            this.cboMaKhoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(155, 23);
            this.cboMaKhoa.TabIndex = 15;
            this.cboMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cboMaKhoa_SelectedIndexChanged);
            // 
            // butAdd
            // 
            this.butAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butAdd.Location = new System.Drawing.Point(9, 11);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(120, 35);
            this.butAdd.TabIndex = 16;
            this.butAdd.Text = "Thêm";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butEdit.Location = new System.Drawing.Point(142, 9);
            this.butEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(117, 36);
            this.butEdit.TabIndex = 17;
            this.butEdit.Text = "Sửa";
            this.butEdit.UseVisualStyleBackColor = true;
            // 
            // butDelete
            // 
            this.butDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butDelete.Location = new System.Drawing.Point(285, 9);
            this.butDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(106, 36);
            this.butDelete.TabIndex = 18;
            this.butDelete.Text = "Xóa";
            this.butDelete.UseVisualStyleBackColor = true;
            // 
            // butSave
            // 
            this.butSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butSave.Location = new System.Drawing.Point(415, 7);
            this.butSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(91, 36);
            this.butSave.TabIndex = 19;
            this.butSave.Text = "Lưu";
            this.butSave.UseVisualStyleBackColor = true;
            // 
            // butExit
            // 
            this.butExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butExit.Location = new System.Drawing.Point(548, 7);
            this.butExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(94, 32);
            this.butExit.TabIndex = 20;
            this.butExit.Text = "Thoát";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataSV
            // 
            this.dataSV.AllowUserToOrderColumns = true;
            this.dataSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataSV.AutoGenerateColumns = false;
            this.dataSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãSVDataGridViewTextBoxColumn,
            this.họSVDataGridViewTextBoxColumn,
            this.tênSVDataGridViewTextBoxColumn,
            this.ngàySinhDataGridViewTextBoxColumn,
            this.giớiTínhDataGridViewTextBoxColumn,
            this.mãKhoaDataGridViewTextBoxColumn});
            this.dataSV.DataSource = this.dSSVBindingSource;
            this.dataSV.Location = new System.Drawing.Point(34, 196);
            this.dataSV.Name = "dataSV";
            this.dataSV.Size = new System.Drawing.Size(638, 270);
            this.dataSV.TabIndex = 21;
            // 
            // mãSVDataGridViewTextBoxColumn
            // 
            this.mãSVDataGridViewTextBoxColumn.DataPropertyName = "Mã SV";
            this.mãSVDataGridViewTextBoxColumn.HeaderText = "Mã SV";
            this.mãSVDataGridViewTextBoxColumn.Name = "mãSVDataGridViewTextBoxColumn";
            // 
            // họSVDataGridViewTextBoxColumn
            // 
            this.họSVDataGridViewTextBoxColumn.DataPropertyName = "Họ SV";
            this.họSVDataGridViewTextBoxColumn.HeaderText = "Họ SV";
            this.họSVDataGridViewTextBoxColumn.Name = "họSVDataGridViewTextBoxColumn";
            // 
            // tênSVDataGridViewTextBoxColumn
            // 
            this.tênSVDataGridViewTextBoxColumn.DataPropertyName = "Tên SV";
            this.tênSVDataGridViewTextBoxColumn.HeaderText = "Tên SV";
            this.tênSVDataGridViewTextBoxColumn.Name = "tênSVDataGridViewTextBoxColumn";
            // 
            // ngàySinhDataGridViewTextBoxColumn
            // 
            this.ngàySinhDataGridViewTextBoxColumn.DataPropertyName = "Ngày sinh";
            this.ngàySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngàySinhDataGridViewTextBoxColumn.Name = "ngàySinhDataGridViewTextBoxColumn";
            // 
            // giớiTínhDataGridViewTextBoxColumn
            // 
            this.giớiTínhDataGridViewTextBoxColumn.DataPropertyName = "Giới tính";
            this.giớiTínhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.giớiTínhDataGridViewTextBoxColumn.Name = "giớiTínhDataGridViewTextBoxColumn";
            // 
            // mãKhoaDataGridViewTextBoxColumn
            // 
            this.mãKhoaDataGridViewTextBoxColumn.DataPropertyName = "Mã khoa";
            this.mãKhoaDataGridViewTextBoxColumn.HeaderText = "Mã khoa";
            this.mãKhoaDataGridViewTextBoxColumn.Name = "mãKhoaDataGridViewTextBoxColumn";
            // 
            // grb1
            // 
            this.grb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb1.Controls.Add(this.label1);
            this.grb1.Controls.Add(this.cboMaKhoa);
            this.grb1.Controls.Add(this.rbtNu);
            this.grb1.Controls.Add(this.date);
            this.grb1.Controls.Add(this.txbName);
            this.grb1.Controls.Add(this.txbHoSV);
            this.grb1.Controls.Add(this.txbMSV);
            this.grb1.Controls.Add(this.rbtNam);
            this.grb1.Controls.Add(this.label7);
            this.grb1.Controls.Add(this.label6);
            this.grb1.Controls.Add(this.label5);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Location = new System.Drawing.Point(21, 8);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(673, 172);
            this.grb1.TabIndex = 22;
            this.grb1.TabStop = false;
            this.grb1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN";
            // 
            // grb2
            // 
            this.grb2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grb2.Controls.Add(this.butExit);
            this.grb2.Controls.Add(this.butSave);
            this.grb2.Controls.Add(this.butDelete);
            this.grb2.Controls.Add(this.butEdit);
            this.grb2.Controls.Add(this.butAdd);
            this.grb2.Location = new System.Drawing.Point(21, 489);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(672, 59);
            this.grb2.TabIndex = 23;
            this.grb2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(708, 573);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.dataSV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Chương trình quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSV)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource dSSVBindingSource;
        private QLSVDataSetTableAdapters.DSSVTableAdapter dSSVTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtNam;
        private System.Windows.Forms.TextBox txbMSV;
        private System.Windows.Forms.TextBox txbHoSV;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.RadioButton rbtNu;
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.DataGridView dataSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn họSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giớiTínhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb2;
    }
}

