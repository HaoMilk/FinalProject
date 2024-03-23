﻿using System;
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
        }

        private int _currentPage;
        private int _totalPage;
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

        [Category("CUSTOMIZE DATA")]
        public int TotalPage
        {
            get { return _totalPage; }
            set
            {
                _totalPage = value;
                this.CurrentPage = 1;
                this.label_CurrentPage.Text = $"{_currentPage} / {_totalPage}";
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE DATA")]
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value;
                this.Invalidate();
            }
        }

        public int TotalRecord
        {
            get
            {
                return this.TotalPage * this.PageSize;
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
    }
}
