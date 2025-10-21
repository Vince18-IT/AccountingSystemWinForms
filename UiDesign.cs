using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystemWinForms
{
    internal class UiDesign
    {
        //(paras itom2 background)
        public async static void ShowDialogDimBackground(Form parent, Form dialog, int duration)
        {
            // Always create a new instance of dimOverlay
            Form dimOverlay = new Form();

            dimOverlay.FormBorderStyle = FormBorderStyle.None;
            dimOverlay.StartPosition = FormStartPosition.Manual;
            dimOverlay.BackColor = Color.Black;
            dimOverlay.Opacity = 0.5;
            dimOverlay.ShowInTaskbar = false;
            dimOverlay.Size = parent.ClientSize;
            dimOverlay.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dimOverlay.Width, dimOverlay.Height, 15, 15));

            dimOverlay.Location = parent.PointToScreen(Point.Empty);
            dimOverlay.Owner = parent;

            dimOverlay.Show(parent);

            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.Opacity = 0;

            dialog.Load += async (s, e) => { await Task.Delay(duration); dialog.Opacity = 1; };
            dialog.FormClosing += (s, e) => { dimOverlay.Hide(); };
            dialog.ShowDialog(dimOverlay);

        }

        public static GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            // Inset to avoid clipping the sides when drawing thick borders
            Rectangle arcRect = new Rectangle(rect.X, rect.Y, diameter, diameter);

            // Top-left
            path.AddArc(arcRect, 180, 90);

            // Top-right
            arcRect.X = rect.Right - diameter - 1; // subtract 1 to stay within bounds
            path.AddArc(arcRect, 270, 90);

            // Bottom-right
            arcRect.Y = rect.Bottom - diameter - 1;
            path.AddArc(arcRect, 0, 90);

            // Bottom-left
            arcRect.X = rect.X;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );



        //(para nis shadow sa form)
        public static void ApplyShadow(Form form)
        {
            // Ensure form is borderless
            form.FormBorderStyle = FormBorderStyle.None;

            // Enable non-client rendering policy (ensures DWM effects work)
            int enabled = DWMNCRP_ENABLED;
            DwmSetWindowAttribute(form.Handle, DWMWA_NCRENDERING_POLICY, ref enabled, sizeof(int));

            // Create margins for shadow effect
            MARGINS margins = new MARGINS()
            {
                cxLeftWidth = 1,
                cxRightWidth = 1,
                cyTopHeight = 1,
                cyBottomHeight = 1
            };

            // Apply DWM shadow effect
            DwmExtendFrameIntoClientArea(form.Handle, ref margins);
        }
        // Constants for DWM
        private const int DWMWA_NCRENDERING_POLICY = 2;
        private const int DWMNCRP_ENABLED = 2;

        // DWM API to extend the shadow frame
        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        // Structure for margins
        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }
     
    }
}
