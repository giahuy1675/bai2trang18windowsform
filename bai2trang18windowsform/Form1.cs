using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bai2trang18windowsform
{
    public partial class Form1 : Form
    {
        // Khai báo danh sách sinh viên với dữ liệu sẵn có
        List<SinhVien> danhSachSinhVien = new List<SinhVien>
        {
            new SinhVien { MSSV = "SV001", HoTen = "Nguyễn Văn A", Diem = 8.5, GioiTinh = "Nam", ChuyenNganh = "Công nghệ thông tin" },
            new SinhVien { MSSV = "SV002", HoTen = "Trần Thị B", Diem = 9.0, GioiTinh = "Nữ", ChuyenNganh = "Kỹ thuật phần mềm" },
            new SinhVien { MSSV = "SV003", HoTen = "Lê Văn C", Diem = 7.0, GioiTinh = "Nam", ChuyenNganh = "Hệ thống thông tin" },
            new SinhVien { MSSV = "SV004", HoTen = "Phạm Thị D", Diem = 6.5, GioiTinh = "Nữ", ChuyenNganh = "An toàn thông tin" }
        };

        public Form1()
        {
            InitializeComponent();
            ThemChuyenNganhVaoComboBox(); // Thêm chuyên ngành khi khởi tạo Form
            CapNhatDataGridView(); // Hiển thị dữ liệu lên DataGridView
            CapNhatSoLuongSinhVien(); // Cập nhật số lượng sinh viên
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true; // Đánh dấu dòng đã chọn
                dataGridView1_CellContentClick(sender, e); // Gọi lại sự kiện
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachSinhVien.Count)
            {
                // Lấy sinh viên từ danh sách dựa trên chỉ số dòng
                SinhVien sinhVien = danhSachSinhVien[e.RowIndex];

                // Hiển thị thông tin sinh viên lên các TextBox
                txb_MSSV.Text = sinhVien.MSSV;
                txb_HoTen.Text = sinhVien.HoTen;
                txb_Diem.Text = sinhVien.Diem.ToString();

                // Hiển thị giới tính
                cb_Nam.Checked = sinhVien.GioiTinh == "Nam";
                cb_Nu.Checked = sinhVien.GioiTinh == "Nữ";

                // Hiển thị chuyên ngành
                cb_ChuyenNganh.SelectedItem = sinhVien.ChuyenNganh;
            }
        }

        // Sự kiện Thêm sinh viên
        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string mssv = txb_MSSV.Text;
            string hoten = txb_HoTen.Text;
            double diem;

            // Kiểm tra xem MSSV đã tồn tại hay chưa
            if (danhSachSinhVien.Any(sv => sv.MSSV == mssv))
            {
                MessageBox.Show("MSSV đã tồn tại. Vui lòng nhập MSSV khác.");
                return;
            }

            // Kiểm tra và chuyển đổi điểm
            if (!double.TryParse(txb_Diem.Text, out diem))
            {
                MessageBox.Show("Điểm không hợp lệ.");
                return;
            }

            // Xác định giới tính
            string gioitinh = cb_Nam.Checked ? "Nam" : cb_Nu.Checked ? "Nữ" : "";

            // Lấy chuyên ngành từ ComboBox
            string chuyennganh = cb_ChuyenNganh.SelectedItem?.ToString() ?? "";

            // Kiểm tra thông tin nhập vào
            if (!KiemTraThongTinSinhVien(mssv, hoten, diem, chuyennganh, gioitinh))
                return;

            // Thêm sinh viên mới vào danh sách
            SinhVien sinhVienMoi = new SinhVien
            {
                MSSV = mssv,
                HoTen = hoten,
                Diem = diem,
                GioiTinh = gioitinh,
                ChuyenNganh = chuyennganh
            };

            danhSachSinhVien.Add(sinhVienMoi);

            // Cập nhật lại DataGridView
            CapNhatDataGridView();
            CapNhatSoLuongSinhVien();
        }

        // Hàm kiểm tra thông tin sinh viên
        private bool KiemTraThongTinSinhVien(string mssv, string hoten, double diem, string chuyennganh, string gioitinh)
        {
            if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(chuyennganh) || string.IsNullOrEmpty(gioitinh))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return false;
            }
            return true;
        }

        // Hàm cập nhật lại DataGridView
        private void CapNhatDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachSinhVien;
            dataGridView1.Columns["MSSV"].HeaderText = "Mã số sinh viên";
            dataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
            dataGridView1.Columns["Diem"].HeaderText = "Điểm";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới tính";
            dataGridView1.Columns["ChuyenNganh"].HeaderText = "Chuyên ngành";
        }

        // Hàm cập nhật số lượng sinh viên Nam và Nữ
        private void CapNhatSoLuongSinhVien()
        {
            int soLuongNam = danhSachSinhVien.Count(sv => sv.GioiTinh == "Nam");
            int soLuongNu = danhSachSinhVien.Count(sv => sv.GioiTinh == "Nữ");

            txb_TongNam.Text = soLuongNam.ToString();
            txb_TongNu.Text = soLuongNu.ToString();
        }

        // Hàm thêm chuyên ngành vào ComboBox
        private void ThemChuyenNganhVaoComboBox()
        {
            // Xóa các mục cũ (nếu có)
            cb_ChuyenNganh.Items.Clear();

            // Thêm các chuyên ngành mới
            cb_ChuyenNganh.Items.Add("Công nghệ thông tin");
            cb_ChuyenNganh.Items.Add("Kỹ thuật phần mềm");
            cb_ChuyenNganh.Items.Add("Hệ thống thông tin");
            cb_ChuyenNganh.Items.Add("An toàn thông tin");
            cb_ChuyenNganh.Items.Add("Trí tuệ nhân tạo");
            cb_ChuyenNganh.Items.Add("Khoa học dữ liệu");
            cb_ChuyenNganh.Items.Add("Mạng máy tính và truyền thông");

            // Đặt mục mặc định nếu muốn
            if (cb_ChuyenNganh.Items.Count > 0)
            {
                cb_ChuyenNganh.SelectedIndex = 0; // Chọn mục đầu tiên làm mặc định
            }
        }

        // Sự kiện thay đổi trạng thái checkbox Nam
        private void cb_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Nam.Checked)
            {
                cb_Nu.Checked = false; // Bỏ chọn Nữ nếu Nam được chọn
            }
        }

        // Sự kiện thay đổi trạng thái checkbox Nữ
        private void cb_Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Nu.Checked)
            {
                cb_Nam.Checked = false; // Bỏ chọn Nam nếu Nữ được chọn
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Tìm sinh viên cần sửa dựa trên MSSV
            var mssv = txb_MSSV.Text;
            var sinhVienCanSua = danhSachSinhVien.FirstOrDefault(sv => sv.MSSV == mssv);

            if (sinhVienCanSua == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần sửa.");
                return;
            }

            // Cập nhật thông tin sinh viên
            sinhVienCanSua.HoTen = txb_HoTen.Text;
            sinhVienCanSua.Diem = double.TryParse(txb_Diem.Text, out double diem) ? diem : sinhVienCanSua.Diem;
            sinhVienCanSua.GioiTinh = cb_Nam.Checked ? "Nam" : cb_Nu.Checked ? "Nữ" : sinhVienCanSua.GioiTinh;
            sinhVienCanSua.ChuyenNganh = cb_ChuyenNganh.SelectedItem?.ToString() ?? sinhVienCanSua.ChuyenNganh;

            // Cập nhật lại DataGridView
            CapNhatDataGridView();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Tìm sinh viên cần xóa dựa trên MSSV
            var mssv = txb_MSSV.Text;
            var sinhVienCanXoa = danhSachSinhVien.FirstOrDefault(sv => sv.MSSV == mssv);

            if (sinhVienCanXoa != null)
            {
                danhSachSinhVien.Remove(sinhVienCanXoa); // Xóa sinh viên
                CapNhatDataGridView();
                CapNhatSoLuongSinhVien();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên cần xóa.");
            }
        }
    }
}
