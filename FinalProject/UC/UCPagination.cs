using Newtonsoft.Json.Linq;
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
    public partial class UCPagination : UserControl
    {
        public UCPagination()
        {
            InitializeComponent();

            var items = new ComboBoxItem[]
            {
                new ComboBoxItem { Text = "5 items/page", Value = 5 },
                new ComboBoxItem { Text = "10 items/page", Value = 10 },
                new ComboBoxItem { Text = "15 items/page", Value = 15 },
                new ComboBoxItem { Text = "20 items/page", Value = 20 },
            };
            this.ucComboBox_PageSize.Items = items;
            this.ucComboBox_PageSize.SelectedIndex = 0;
        }

        private int _currentPage;
        private int _totalPage;
        private int _totalRecord;
        private int _pageSize = 10;

        [Category("CUSTOMIZE DATA")]
        public int CurrentPage
        {
            get { return _currentPage; }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                else if (value > _totalPage)
                {
                    value = _totalPage;
                }

                _currentPage = value;
                this.label_CurrentPage.Text = $"{_currentPage} / {_totalPage}";
                this.OnCurrentPageChanged(EventArgs.Empty);
                this.Invalidate();
            }
        }

        public int PageSize
        {
            get { return _pageSize; }
        }

        [Category("CUSTOMIZE DATA")]
        public int TotalRecord
        {
            get { return _totalRecord; }
            set
            {
                _totalRecord = value;
                _currentPage = 1;
                _totalPage = (int)Math.Ceiling((double)_totalRecord / _pageSize);
                this.label_CurrentPage.Text = $"{_currentPage} / {_totalPage}";
                this.Invalidate();
            }
        }

        public int StartRecord
        {
            get
            {
                return (this.CurrentPage - 1) * this.PageSize;
            }
        }

        public int EndRecord
        {
            get
            {
                return this.CurrentPage * this.PageSize;
            }
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Fires when the CurrentPage value is changed")]
        public event EventHandler CurrentPageChanged;

        private void button_Previous_Click(object sender, EventArgs e)
        {
            this.CurrentPage--;
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            this.CurrentPage++;
        }

        protected virtual void OnCurrentPageChanged(EventArgs e)
        {
            if (CurrentPageChanged != null)
            {
                CurrentPageChanged(this, e);
            }    
        }

        private void ucComboBox_PageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = this.ucComboBox_PageSize.SelectedItem as ComboBoxItem;
            if (item != null)
            {
                this._pageSize = (int)item.Value;
                this._currentPage = 1;
                this.label_CurrentPage.Text = $"{_currentPage} / {_totalPage}";
                this.Invalidate();
            }
        }
    }
}
