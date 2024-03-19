using FinalProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Candidate.GUI
{
    public partial class FMauCv : Form
    {
        public FMauCv()
        {
            InitializeComponent();
            this.richTextBox_Data.SelectedRtf = Resources.resume;
        }

        private void dev01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox_Data.Clear();
            this.richTextBox_Data.SelectedRtf = Resources.resume;
        }

        private void dev02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox_Data.Clear();
            this.richTextBox_Data.SelectedRtf = Resources.CV_Template_for_Software_Engineer;
        }

        private void tester01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox_Data.Clear();
            this.richTextBox_Data.SelectedRtf = Resources.CV_template;
        }

        private void tester02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox_Data.Clear();
            this.richTextBox_Data.SelectedRtf = Resources.resume_009;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
