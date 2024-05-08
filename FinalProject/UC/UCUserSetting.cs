using FinalProject.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.UC
{
    public partial class UCUserSetting : UserControl
    {
        public UCUserSetting()
        {
            InitializeComponent();

            this.pictureBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        }

        private void label_name1_Click(object sender, EventArgs e)
        {

        }

        private void UCUserSetting_Load(object sender, EventArgs e)
        {
            if(LoggedUser.User != null && LoggedUser.UngVien != null)
            {
                textBox_HoTen.Text = LoggedUser.UngVien.HoTen;
                textBox_Email.Text = LoggedUser.User.Email;
                textBox_Email.Text = LoggedUser.UngVien.DiaChi;
                var url = LoggedUser.User.AvatarUrl;
                if (!string.IsNullOrWhiteSpace(url))
                {
                    pictureBox_Avatar.LoadAsync(url);
                }
            }
        
        }
    }
}
