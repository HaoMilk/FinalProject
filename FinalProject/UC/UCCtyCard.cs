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
    public partial class UCCtyCard : UserControl
    {
        private int id;
        private string name;
        private string description;

        public int Id
        {
            get => id;
            set => id = value;
        }

        [Category("CUSTOMIZE DATA")]
        public string Name
        {
            get => name;
            set
            {
                if (value == null)
                {
                    value = "Công ty";
                }
                name = value;
                label_Name.Text = name;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE DATA")]
        public string Description
        {
            get => description;
            set
            {
                if (value == null)
                {
                    value = "Giới thiệu công ty";
                }
                description = value;
                this.Invalidate();
            }
        }

        public UCCtyCard()
        {
            InitializeComponent();
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Xem chi tiết công ty '{name}'");
        }
    }
}
