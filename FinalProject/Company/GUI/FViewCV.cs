using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using FinalProject.UC;
using NPOI.HSSF.Record.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Company.GUI
{
    public partial class FViewCV : UCForm
    {
        private CvBUS _cvBus = new CvBUS();
        private UngVienBUS _uvBus = new UngVienBUS();
        private UngTuyenBUS _utBUS = new UngTuyenBUS();
        private UngTuyenGetAllInput input = new UngTuyenGetAllInput();
        private int id;
        private UngVien _uv;
        private CV _cv;
        private UngTuyenDTO _ut ;
        private int result;
        public int IdCV
        {
            get => id; 
            set
            {
                id = value;
                _cv = _cvBus.GetById(id);
                this.LoadData();
            }
        }
        public int IdUV
        {
            get => id; set
            {
                id = value;
                _uv = _uvBus.GetById(id);
                this.LoadData();
            }
        }
        public int IdUT
        {
            get => id; set
            {
                id = value;
                _ut = _utBUS.GetById(id);
            }
        }

        public FViewCV()
        {
            InitializeComponent();
        }

        private void FViewCV_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (_uv != null)
            {
                textBox_HovaTen.Text = _uv.HoTen;
                textBox_Email.Text = _uv.Email;
                textBox_SoDienThoai.Text = _uv.SDT;
                textBox_DiaChi.Text = _uv.DiaChi;
                textBox_NgaySinh.Text = _uv.NgaySinh.ToString();
                textBox_GioiTinh.Text = _uv.GioiTinh;
            }

            if (_cv != null)
            {
                textBox_TenCv.Text = _cv.Ten;
                textBox_ViTriUT.Text = _cv.ViTriUngTuyen;
                textBox_KyNang.Text = _cv.KyNang;
                textBox_NgoaiNgu.Text = _cv.NgoaiNgu;
                textBox_TinHoc.Text = _cv.TinHoc;
                textBox_HocVan.Text = _cv.HocVan;
                textBox_HoatDong.Text = _cv.HoatDong;
                textBox_ChungChi.Text = _cv.ChungChi;
                richTextBox_MucTieu.Text = _cv.MucTieu;
                richTextBox_KinhNghiem.Text = _cv.KinhNghiem;
            }

            if (_ut != null)
            {
                label_TenCongViec.Text = _ut.TenCongViec;
                dateTimePicker_ThoiGianPV.Value = _ut.ThoiGianPhongVan ?? DateTime.Now;
                richTextBox_DiaDiemPV.Text = _ut.DiaDiemPhongVan;
                richTextBox_NguoiPV.Text = _ut.NguoiPhongVan;
                richTextBox_KetQuaPV.Text = _ut.KetQuaPhongVan;
                label_TrangThaiUngTuyen.Text = TrangThaiUngTuyen.GetValue(_ut.TrangThai);

                if (_ut.TrangThai == TrangThaiUngTuyen.Submitted)
                {
                    button_TuyenDung.Enabled = false;
                }
                else if (_ut.TrangThai == TrangThaiUngTuyen.Approved)
                {
                    button_Duyet.Enabled = false;
                    dateTimePicker_ThoiGianPV.Enabled = false;
                    richTextBox_DiaDiemPV.Enabled = false;
                    richTextBox_NguoiPV.Enabled = false;
                }
                else if (_ut.TrangThai == TrangThaiUngTuyen.Rejected)
                {
                    tableLayoutPanel_Buttons.Enabled = false;
                    tableLayoutPanel_ThongTinPV.Enabled = false;
                }
                else if (_ut.TrangThai == TrangThaiUngTuyen.Cancelled)
                {
                    tableLayoutPanel_Buttons.Enabled = false;
                    tableLayoutPanel_ThongTinPV.Enabled = false;
                }
                else if (_ut.TrangThai == TrangThaiUngTuyen.Recruitmented)
                {
                    tableLayoutPanel_Buttons.Enabled = false;
                    tableLayoutPanel_ThongTinPV.Enabled = false;
                }
            }
        }

        private void button_Duyet_Click(object sender, EventArgs e)
        {
            var trangThai = _ut.TrangThai;
            if (_ut.TrangThai == TrangThaiUngTuyen.Rejected)
            {
                UCMessageBox.Show("Hồ sơ đã bị loại bỏ");
                return;
            }
            else if (_ut.TrangThai == TrangThaiUngTuyen.Approved)
            {
                UCMessageBox.Show("Hồ sơ đã được duyệt");
                return;
            }
            else
            {
                trangThai = TrangThaiUngTuyen.Approved;
            }
            if (string.IsNullOrEmpty(richTextBox_DiaDiemPV.Text))
            {
                tabControl_ThongTin.SelectedTab = tabPage_ThongTinPhongVan;
                richTextBox_DiaDiemPV.Focus();
                UCMessageBox.Show("Vui lòng nhập địa điểm phỏng vấn!");
                return;
            }
            if (string.IsNullOrEmpty(richTextBox_NguoiPV.Text))
            {
                tabControl_ThongTin.SelectedTab = tabPage_ThongTinPhongVan;
                richTextBox_NguoiPV.Focus();
                UCMessageBox.Show("Vui lòng nhập thông tin người phỏng vấn!");
                return;
            }
            if (string.IsNullOrEmpty(richTextBox_DiaDiemPV.Text))
            {
                tabControl_ThongTin.SelectedTab = tabPage_ThongTinPhongVan;
                richTextBox_DiaDiemPV.Focus();
                UCMessageBox.Show("Vui lòng nhập thông tin địa điểm phỏng vấn!");
                return;
            }
            //result = _utBUS.UpdateTrangThai(ID, trangThai);

            _ut.ThoiGianPhongVan = dateTimePicker_ThoiGianPV.Value;
            _ut.DiaDiemPhongVan = richTextBox_DiaDiemPV.Text;
            _ut.NguoiPhongVan = richTextBox_NguoiPV.Text;

            var ungTuyen = new UngTuyen
            {
                Id = _ut.Id,
                TrangThai = trangThai,
                ThoiGianPhongVan = dateTimePicker_ThoiGianPV.Value,
                DiaDiemPhongVan = richTextBox_DiaDiemPV.Text,
                NguoiPhongVan = richTextBox_NguoiPV.Text,
            };
            result = _utBUS.Update(ungTuyen);
            if(result > 0)
            {
                var output = ungTuyen.SendEmailPhongVan(_ut);
                if (output.IsSuccess)
                {
                    UCMessageBox.Show("Duyệt thành công");
                    this.Close();
                }
                else
                {
                    UCMessageBox.Show("Có lỗi phát sinh khi gửi email.");
                }
            }
            else
            {
                UCMessageBox.Show("Duyệt không thành công");
            }
        }

        private void button_Loai_Click(object sender, EventArgs e)
        {
            var trangThai = _ut.TrangThai;
            if (_ut.TrangThai == TrangThaiUngTuyen.Rejected)
            {
                UCMessageBox.Show("Hồ sơ đã được loại bỏ");
                return;
            }
            else
            {
                trangThai = TrangThaiUngTuyen.Rejected;
            }
            if (string.IsNullOrEmpty(richTextBox_KetQuaPV.Text))
            {
                tabControl_ThongTin.SelectedTab = tabPage_ThongTinPhongVan;
                richTextBox_KetQuaPV.Focus();
                UCMessageBox.Show("Vui lòng nhập thông tin kết quả phỏng vấn!");
                return;
            }
            _ut.KetQuaPhongVan = richTextBox_KetQuaPV.Text;

            //result = _utBUS.UpdateTrangThai(ID, trangThai);
            var ungTuyen = new UngTuyen
            {
                Id = _ut.Id,
                TrangThai = trangThai,
                KetQuaPhongVan = richTextBox_KetQuaPV.Text
            };
            result = _utBUS.Update(ungTuyen);
            if (result > 0)
            {
                var output = ungTuyen.SendEmailTuChoiHoSoPhongVan(_ut);
                if (output.IsSuccess)
                {
                    UCMessageBox.Show("Loại bỏ thành công");
                    this.Close();
                }
                else
                {
                    UCMessageBox.Show("Có lỗi phát sinh khi gửi email.");
                }
            }
            else
            {
                UCMessageBox.Show("Loại bỏ không thành công");
            }
        }

        private void button_TuyenDung_Click(object sender, EventArgs e)
        {
            var trangThai = _ut.TrangThai;
            if (_ut.TrangThai == TrangThaiUngTuyen.Rejected)
            {
                UCMessageBox.Show("Hồ sơ đã bị loại bỏ");
                return;
            }
            else if (_ut.TrangThai == TrangThaiUngTuyen.Approved)
            {
                trangThai = TrangThaiUngTuyen.Recruitmented;
            }
            else
            {
                UCMessageBox.Show("Hồ sơ chưa được duyệt");
                return;
            }
            if (string.IsNullOrEmpty(richTextBox_KetQuaPV.Text))
            {
                tabControl_ThongTin.SelectedTab = tabPage_ThongTinPhongVan;
                richTextBox_KetQuaPV.Focus();
                UCMessageBox.Show("Vui lòng nhập thông tin kết quả phỏng vấn!");
                return;
            }
            _ut.KetQuaPhongVan = richTextBox_KetQuaPV.Text;

            //result = _utBUS.UpdateTrangThai(ID, trangThai);
            var ungTuyen = new UngTuyen
            {
                Id = _ut.Id,
                TrangThai = trangThai,
                KetQuaPhongVan = richTextBox_KetQuaPV.Text
            };
            result = _utBUS.Update(ungTuyen);
            if (result > 0)
            {
                var output = ungTuyen.SendEmailKetQuaPhongVan(_ut);
                if(output.IsSuccess)
                {
                    UCMessageBox.Show("Tuyển dụng thành công");
                    this.Close();
                } 
                else
                {
                    UCMessageBox.Show("Có lỗi phát sinh khi gửi email.");
                }
            }
            else
            {
                UCMessageBox.Show("Tuyển dụng không thành công");
            }
        }
    }
}
