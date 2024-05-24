namespace QuanLyBanBida
{
    partial class f_AdminBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_AdminBill));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ViewBill = new System.Windows.Forms.Button();
            this.dtpk_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpk_FromDate = new System.Windows.Forms.DateTimePicker();
            this.dtgv_Bill = new System.Windows.Forms.DataGridView();
            this.btn_BackupRestore = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ViewBill);
            this.panel2.Controls.Add(this.dtpk_ToDate);
            this.panel2.Controls.Add(this.dtpk_FromDate);
            this.panel2.Location = new System.Drawing.Point(189, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 38);
            this.panel2.TabIndex = 3;
            // 
            // btn_ViewBill
            // 
            this.btn_ViewBill.BackColor = System.Drawing.Color.Silver;
            this.btn_ViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewBill.ForeColor = System.Drawing.Color.Black;
            this.btn_ViewBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewBill.Image")));
            this.btn_ViewBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewBill.Location = new System.Drawing.Point(224, 0);
            this.btn_ViewBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ViewBill.Name = "btn_ViewBill";
            this.btn_ViewBill.Size = new System.Drawing.Size(97, 38);
            this.btn_ViewBill.TabIndex = 2;
            this.btn_ViewBill.Text = "   Thống kê";
            this.btn_ViewBill.UseVisualStyleBackColor = false;
            this.btn_ViewBill.Click += new System.EventHandler(this.btn_ViewBill_Click);
            // 
            // dtpk_ToDate
            // 
            this.dtpk_ToDate.Location = new System.Drawing.Point(392, 11);
            this.dtpk_ToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpk_ToDate.Name = "dtpk_ToDate";
            this.dtpk_ToDate.Size = new System.Drawing.Size(128, 20);
            this.dtpk_ToDate.TabIndex = 1;
            // 
            // dtpk_FromDate
            // 
            this.dtpk_FromDate.Location = new System.Drawing.Point(10, 11);
            this.dtpk_FromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpk_FromDate.Name = "dtpk_FromDate";
            this.dtpk_FromDate.Size = new System.Drawing.Size(129, 20);
            this.dtpk_FromDate.TabIndex = 0;
            // 
            // dtgv_Bill
            // 
            this.dtgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Bill.Location = new System.Drawing.Point(247, 78);
            this.dtgv_Bill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_Bill.Name = "dtgv_Bill";
            this.dtgv_Bill.RowHeadersWidth = 51;
            this.dtgv_Bill.RowTemplate.Height = 24;
            this.dtgv_Bill.Size = new System.Drawing.Size(415, 384);
            this.dtgv_Bill.TabIndex = 3;
            // 
            // btn_BackupRestore
            // 
            this.btn_BackupRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_BackupRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackupRestore.ForeColor = System.Drawing.Color.White;
            this.btn_BackupRestore.Location = new System.Drawing.Point(681, 468);
            this.btn_BackupRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BackupRestore.Name = "btn_BackupRestore";
            this.btn_BackupRestore.Size = new System.Drawing.Size(141, 30);
            this.btn_BackupRestore.TabIndex = 6;
            this.btn_BackupRestore.Text = "Sao lưu dữ liệu";
            this.btn_BackupRestore.UseVisualStyleBackColor = false;
            this.btn_BackupRestore.Click += new System.EventHandler(this.btn_BackupRestore_Click);
            // 
            // f_AdminBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(858, 509);
            this.Controls.Add(this.btn_BackupRestore);
            this.Controls.Add(this.dtgv_Bill);
            this.Controls.Add(this.panel2);
            this.Name = "f_AdminBill";
            this.Text = "Thông tin hóa đơn";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ViewBill;
        private System.Windows.Forms.DateTimePicker dtpk_ToDate;
        private System.Windows.Forms.DateTimePicker dtpk_FromDate;
        private System.Windows.Forms.DataGridView dtgv_Bill;
        private System.Windows.Forms.Button btn_BackupRestore;
    }
}