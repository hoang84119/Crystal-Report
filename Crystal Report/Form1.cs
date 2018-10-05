using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crystal_Report
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        DataTable dtKhoa;
        DataTable dtSinhVien;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=SANG-LAPTOP\SQLEXPRESS;Initial Catalog=QLSINHVIEN4;Integrated Security=True");

            dataAdapter = new SqlDataAdapter("SELECT * FROM KHOA", connection);
            dtKhoa = new DataTable();
            dataAdapter.Fill(dtKhoa);

            dataAdapter.SelectCommand.CommandText = "SELECT SINHVIEN.MaLop, SINHVIEN.NgaySinh, SINHVIEN.HoTen, SINHVIEN.MaSV, LOP.MaLop AS Expr1, KHOA.MaKhoa, KHOA.TenKhoa"
                                                    + " FROM SINHVIEN INNER JOIN"
                                                    + " LOP ON SINHVIEN.MaLop = LOP.MaLop INNER JOIN"
                                                    + " KHOA ON LOP.MaKhoa = KHOA.MaKhoa" ;
            dtSinhVien = new DataTable();
            dataAdapter.Fill(dtSinhVien);

            cbbKhoa.DataSource = dtKhoa;
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
            cbbKhoa.SelectedIndex = -1;

            CrystalReport11.SetDataSource(dtSinhVien);
            crvDSSV.ReportSource = CrystalReport11;
        }

        private void btnXuatReport_Click(object sender, EventArgs e)
        {
            dtSinhVien.DefaultView.RowFilter = "MaKhoa= '" + cbbKhoa.SelectedValue.ToString() +"'";
            CrystalReport11.SetDataSource(dtSinhVien.DefaultView);
            crvDSSV.ReportSource = CrystalReport11;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
