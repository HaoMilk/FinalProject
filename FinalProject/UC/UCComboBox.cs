using System.Windows.Forms;

namespace FinalProject.UC
{
    public class UCComboBox : ComboBox
    {
        public new ComboBoxItem[] Items
        {
            get
            {
                var items = new ComboBoxItem[base.Items.Count];
                for (int i = 0; i < base.Items.Count; i++)
                {
                    items[i] = base.Items[i] as ComboBoxItem;
                }
                return items;
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
