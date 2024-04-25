using FinalProject.Common.Const;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject.UC
{
    public class UCComboBox : ComboBox
    {
        #region Constants
        public static ComboBoxItem[] UserSatusItems = new ComboBoxItem[]
        {
            new ComboBoxItem { Text = "Hoạt động", Value = StatusConst.Active },
            new ComboBoxItem { Text = "Không hoạt động", Value = StatusConst.Inactive },
            new ComboBoxItem { Text = "Chờ", Value = StatusConst.Waiting },
            new ComboBoxItem { Text = "Đã xóa tài khoản", Value = StatusConst.Deleted },
        };

        public static ComboBoxItem[] EmailStatusItems = new ComboBoxItem[]
        {
            new ComboBoxItem { Text = "Đã xác minh", Value = true },
            new ComboBoxItem { Text = "Chưa xác minh", Value = false },
        };

        public static ComboBoxItem[] GenderItems = new ComboBoxItem[]
        {
            new ComboBoxItem { Text = "Nam", Value = "M" },
            new ComboBoxItem { Text = "Nữ", Value = "F" },
            new ComboBoxItem { Text = "Khác", Value = "O" },
        };

        public static ComboBoxItem[] TrangThaiUngTuyenItems = new ComboBoxItem[]
        {
            new ComboBoxItem { Text = "Tất cả", Value = string.Empty },
            new ComboBoxItem { Text = "Đã ứng tuyển", Value = TrangThaiUngTuyenConsts.Submitted },
            new ComboBoxItem { Text = "NTD đã xem hồ sơ", Value = TrangThaiUngTuyenConsts.Viewed },
            new ComboBoxItem { Text = "Đã duyệt hồ sơ", Value = TrangThaiUngTuyenConsts.Approved },
        };
        #endregion Constants

        public new ComboBoxItem[] Items
        {
            get
            {
                if (base.Items.Count == 0)
                {
                    return new ComboBoxItem[0];
                }

                var items = new ComboBoxItem[base.Items.Count];
                for (int i = 0; i < base.Items.Count; i++)
                {
                    items[i] = base.Items[i] as ComboBoxItem;
                }
                return items.ToArray();
            }
            set
            {
                base.Items.Clear();
                foreach (var item in value)
                {
                    base.Items.Add(item);
                }
            }
        }

        public new ComboBoxItem SelectedItem
        {
            get
            {
                return SelectedIndex >= 0 ? Items[SelectedIndex] : null;
            }
            set
            {
                if (value == null)
                {
                    SelectedIndex = -1;
                }
                else
                {
                    SelectedIndex = FindStringExact(value.Text);
                }
            }
        }

        public void SetItems(ComboBoxItem[] items)
        {
            Items = items;
        }

        public void SetItems(List<Tinh> items)
        {
            Items = items.Select(x => new ComboBoxItem(x.Ten, x)).ToArray();
        }

        public void SetItems(List<string> items)
        {
            Items = items.Select(x => new ComboBoxItem(x, x)).ToArray();
        }

        public int FindItemIndex(object value)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (value == Items[i].Value)
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindItemIndex(string value)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (value == Items[i].Value.ToString())
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindItemIndex(bool value)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (value == Convert.ToBoolean(Items[i].Value))
                {
                    return i;
                }
            }
            return -1;
        }

        public UCComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
        }

        protected override void SetBoundsCore(
            int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, height, specified);
            if (Dock == DockStyle.Fill ||
                Dock == DockStyle.Left ||
                Dock == DockStyle.Right)
            {
                var d = SystemInformation.FixedFrameBorderSize.Height;
                ItemHeight = height - 2 * d;
            }
            else
            {
                ItemHeight = FontHeight + 2;
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();

            var text = e.Index >= 0 ? GetItemText(this.Items[e.Index]) : string.Empty;

            TextRenderer.DrawText(
                e.Graphics, 
                text, 
                e.Font, 
                e.Bounds, 
                e.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

            base.OnDrawItem(e);
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboBoxItem()
        {
        
        }

        public ComboBoxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
