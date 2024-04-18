using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.XWPF.UserModel;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing.Imaging;

namespace FinalProject.Common.Helper
{
    public static class GuiHelper
    {
        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        public static void FillRoundedRectangle(Rectangle bounds, int cornerRadius, Graphics graphics, Brush backgroundBrush, Brush borderBrush = null, float borderWidth = 2.0f)
        {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (backgroundBrush == null)
                throw new ArgumentNullException("brush");

            using (GraphicsPath path = RoundedRect(bounds, cornerRadius))
            {
                graphics.FillPath(backgroundBrush, path);

                if (borderBrush != null)
                {
                    using (Pen pen = new Pen(borderBrush, borderWidth))
                    {
                        graphics.DrawPath(pen, path);
                    }
                }
            }
        }
    }
}
