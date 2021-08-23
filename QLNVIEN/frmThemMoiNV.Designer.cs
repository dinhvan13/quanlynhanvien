namespace QLNVIEN
{
    partial class frmThemMoiNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnThemnv = new System.Windows.Forms.Button();
            this.cbLoainv = new System.Windows.Forms.ComboBox();
            this.cbTrinhdo = new System.Windows.Forms.ComboBox();
            this.txtHesoluong = new System.Windows.Forms.TextBox();
            this.txtPhucap = new System.Windows.Forms.TextBox();
            this.txtSotiet = new System.Windows.Forms.TextBox();
            this.txtkhoa = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.qLNHANVIENDataSet = new QLNVIEN.QLNHANVIENDataSet();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QLNVIEN.QLNHANVIENDataSetTableAdapters.NHANVIENTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa/Phòng Ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trình độ/ Chức vụ ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiết dạy/Ngày công";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phụ Cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hệ số lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Loại nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuaylai);
            this.groupBox1.Controls.Add(this.btnThemnv);
            this.groupBox1.Controls.Add(this.cbLoainv);
            this.groupBox1.Controls.Add(this.cbTrinhdo);
            this.groupBox1.Controls.Add(this.txtHesoluong);
            this.groupBox1.Controls.Add(this.txtPhucap);
            this.groupBox1.Controls.Add(this.txtSotiet);
            this.groupBox1.Controls.Add(this.txtkhoa);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(446, 370);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(209, 327);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(90, 32);
            this.btnQuaylai.TabIndex = 15;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnThemnv
            // 
            this.btnThemnv.Location = new System.Drawing.Point(20, 327);
            this.btnThemnv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemnv.Name = "btnThemnv";
            this.btnThemnv.Size = new System.Drawing.Size(96, 32);
            this.btnThemnv.TabIndex = 14;
            this.btnThemnv.Text = "Thêm nhân viên";
            this.btnThemnv.UseVisualStyleBackColor = true;
            this.btnThemnv.Click += new System.EventHandler(this.btnThemnv_Click);
            // 
            // cbLoainv
            // 
            this.cbLoainv.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nHANVIENBindingSource, "LoaiNhanVien", true));
            this.cbLoainv.FormattingEnabled = true;
            this.cbLoainv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbLoainv.Location = new System.Drawing.Point(200, 288);
            this.cbLoainv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoainv.Name = "cbLoainv";
            this.cbLoainv.Size = new System.Drawing.Size(151, 24);
            this.cbLoainv.TabIndex = 13;
            // 
            // cbTrinhdo
            // 
            this.cbTrinhdo.FormattingEnabled = true;
            this.cbTrinhdo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbTrinhdo.Location = new System.Drawing.Point(200, 118);
            this.cbTrinhdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTrinhdo.Name = "cbTrinhdo";
            this.cbTrinhdo.Size = new System.Drawing.Size(92, 24);
            this.cbTrinhdo.TabIndex = 12;
            this.cbTrinhdo.SelectedIndexChanged += new System.EventHandler(this.cbTrinhdo_SelectedIndexChanged);
            // 
            // txtHesoluong
            // 
            this.txtHesoluong.Location = new System.Drawing.Point(200, 246);
            this.txtHesoluong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHesoluong.Name = "txtHesoluong";
            this.txtHesoluong.Size = new System.Drawing.Size(151, 24);
            this.txtHesoluong.TabIndex = 11;
            // 
            // txtPhucap
            // 
            this.txtPhucap.Location = new System.Drawing.Point(200, 208);
            this.txtPhucap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhucap.Name = "txtPhucap";
            this.txtPhucap.Size = new System.Drawing.Size(151, 24);
            this.txtPhucap.TabIndex = 10;
            // 
            // txtSotiet
            // 
            this.txtSotiet.Location = new System.Drawing.Point(200, 164);
            this.txtSotiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSotiet.Name = "txtSotiet";
            this.txtSotiet.Size = new System.Drawing.Size(151, 24);
            this.txtSotiet.TabIndex = 9;
            // 
            // txtkhoa
            // 
            this.txtkhoa.Location = new System.Drawing.Point(200, 70);
            this.txtkhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(151, 24);
            this.txtkhoa.TabIndex = 8;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(200, 26);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(151, 24);
            this.txtHoten.TabIndex = 7;
            // 
            // qLNHANVIENDataSet
            // 
            this.qLNHANVIENDataSet.DataSetName = "QLNHANVIENDataSet";
            this.qLNHANVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLNHANVIENDataSet;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemMoiNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 388);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThemMoiNV";
            this.Text = "frmThemMoiNV";
            this.Load += new System.EventHandler(this.frmThemMoiNV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLoainv;
        private System.Windows.Forms.ComboBox cbTrinhdo;
        private System.Windows.Forms.TextBox txtHesoluong;
        private System.Windows.Forms.TextBox txtPhucap;
        private System.Windows.Forms.TextBox txtSotiet;
        private System.Windows.Forms.TextBox txtkhoa;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnThemnv;
        private QLNHANVIENDataSet qLNHANVIENDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLNHANVIENDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}