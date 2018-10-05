namespace Crystal_Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.btnXuatReport = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.crvDSSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new Crystal_Report.CrystalReport1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn khoa";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(105, 11);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(156, 23);
            this.cbbKhoa.TabIndex = 2;
            // 
            // btnXuatReport
            // 
            this.btnXuatReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatReport.Location = new System.Drawing.Point(283, 7);
            this.btnXuatReport.Name = "btnXuatReport";
            this.btnXuatReport.Size = new System.Drawing.Size(94, 26);
            this.btnXuatReport.TabIndex = 3;
            this.btnXuatReport.Text = "Xuất report";
            this.btnXuatReport.UseVisualStyleBackColor = true;
            this.btnXuatReport.Click += new System.EventHandler(this.btnXuatReport_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(383, 7);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 26);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // crvDSSV
            // 
            this.crvDSSV.ActiveViewIndex = 0;
            this.crvDSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvDSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDSSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDSSV.Location = new System.Drawing.Point(0, 40);
            this.crvDSSV.Name = "crvDSSV";
            this.crvDSSV.ReportSource = this.CrystalReport11;
            this.crvDSSV.Size = new System.Drawing.Size(800, 410);
            this.crvDSSV.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatReport);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crvDSSV);
            this.Name = "Form1";
            this.Text = "Danh sách khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDSSV;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Button btnXuatReport;
        private System.Windows.Forms.Button btnThoat;
    }
}

