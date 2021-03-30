using DetectFace.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetectFace.GUI
{
    public partial class FrmMain : Form
    {
        private byte[] tempInput;
        private int count = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Hàm chức năng

        private void ChangeToLoadingState()
        {
            imgLoading.Visible = true;

            btnChonAnh.Enabled = false;
            btnHuanLuyen.Enabled = false;
            btnNhanDang.Enabled = false;
            btnThemVaoTapHuanLuyen.Enabled = false;
            txtTen.Enabled = false;

            txtKetQua.Text = "";
            imgOutput.Image = null;
        }

        private void ChangeToNormalState()
        {
            imgLoading.Visible = false;

            btnChonAnh.Enabled = true;
            btnHuanLuyen.Enabled = true;
            btnNhanDang.Enabled = true;
            btnThemVaoTapHuanLuyen.Enabled = true;
            txtTen.Enabled = true;
        }

        #endregion

        #region Sự kiện
        private async void btnHuanLuyen_Click(object sender, EventArgs e)
        {
            ChangeToLoadingState();

            // Huấn luyện và kiểm tra huấn luyện
            bool success = await api.Train();

            ChangeToNormalState();

            if (success)
                MessageBox.Show("Huấn luyện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Huấn luyện thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void btnThemVaoTapHuanLuyen_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Chưa nhập tên của người cần nhận dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChangeToLoadingState();

            // gọi api
            string filename = count.ToString() + ".jpg";
            count++;
            string people = txtTen.Text;

            bool res = await api.AddImageTrain(people, tempInput, filename);

            ChangeToNormalState();

            if (res == true)
                MessageBox.Show("Thêm dữ liệu huấn luyện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm dữ liệu huấn luyện thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private async void btnNhanDang_Click(object sender, EventArgs e)
        {
            if (imgInput.Image == null)
            {
                MessageBox.Show("Chưa có ảnh nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChangeToLoadingState();

            string ans = await api.Detect(tempInput);
            txtKetQua.Text = ans;

            // sau khi gửi yêu cầu lên server
            Image result = await api.getResultImage();
            imgOutput.Image = result;

            ChangeToNormalState();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            string path = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                path = open.FileName;
                Image image = Image.FromFile(path);
                tempInput = File.ReadAllBytes(path);

                imgInput.Image = image;
            }
            catch
            {
                MessageBox.Show("Định dạng ảnh không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ChangeToNormalState();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            count = 0;
        }
    }
}
