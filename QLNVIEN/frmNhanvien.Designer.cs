namespace QLNVIEN
{
    partial class frmNhanvien
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
            this.dgrNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSapxep = new System.Windows.Forms.Button();
            this.txtThemmoinv = new System.Windows.Forms.Button();
            this.txtLoadData = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrNhanVien
            // 
            this.dgrNhanVien.AllowDrop = true;
            this.dgrNhanVien.AllowUserToOrderColumns = true;
            this.dgrNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNhanVien.Location = new System.Drawing.Point(10, 10);
            this.dgrNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgrNhanVien.Name = "dgrNhanVien";
            this.dgrNhanVien.RowTemplate.Height = 24;
            this.dgrNhanVien.Size = new System.Drawing.Size(470, 204);
            this.dgrNhanVien.TabIndex = 0;
            this.dgrNhanVien.AutoSizeColumnsModeChanged += new System.Windows.Forms.DataGridViewAutoSizeColumnsModeEventHandler(this.dgrNhanVien_AutoSizeColumnsModeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSapxep);
            this.groupBox1.Controls.Add(this.txtThemmoinv);
            this.groupBox1.Controls.Add(this.txtLoadData);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 236);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(470, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // txtSapxep
            // 
            this.txtSapxep.Location = new System.Drawing.Point(321, 68);
            this.txtSapxep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSapxep.Name = "txtSapxep";
            this.txtSapxep.Size = new System.Drawing.Size(70, 22);
            this.txtSapxep.TabIndex = 4;
            this.txtSapxep.Text = "Sắp xếp";
            this.txtSapxep.UseVisualStyleBackColor = true;
            // 
            // txtThemmoinv
            // 
            this.txtThemmoinv.Location = new System.Drawing.Point(165, 68);
            this.txtThemmoinv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtThemmoinv.Name = "txtThemmoinv";
            this.txtThemmoinv.Size = new System.Drawing.Size(102, 22);
            this.txtThemmoinv.TabIndex = 3;
            this.txtThemmoinv.Text = "Thêm nhân viên";
            this.txtThemmoinv.UseVisualStyleBackColor = true;
            this.txtThemmoinv.Click += new System.EventHandler(this.txtThemmoinv_Click);
            // 
            // txtLoadData
            // 
            this.txtLoadData.Location = new System.Drawing.Point(16, 68);
            this.txtLoadData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoadData.Name = "txtLoadData";
            this.txtLoadData.Size = new System.Drawing.Size(82, 21);
            this.txtLoadData.TabIndex = 2;
            this.txtLoadData.Text = "Load Data";
            this.txtLoadData.UseVisualStyleBackColor = true;
            this.txtLoadData.Click += new System.EventHandler(this.txtLoadData_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(135, 19);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(164, 24);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            this.txtHoTen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHoTen_KeyUp);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(14, 23);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(98, 17);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Tên nhân viên :";
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrNhanVien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhanvien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtSapxep;
        private System.Windows.Forms.Button txtThemmoinv;
        private System.Windows.Forms.Button txtLoadData;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
    }
}

