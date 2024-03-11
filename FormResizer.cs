using System;
using System.Drawing;
using System.Windows.Forms;

public static class FormResizer
{
    public static void SetInitialSize(Control control)
    {
        foreach (Control con in control.Controls)
        {
            con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
            if (con.Controls.Count > 0)
            {
                SetInitialSize(con);
            }
        }
    }

    public static void ResizeForm(Control control, Size originalSize)
    {
        float widthRatio = (float)control.Width / originalSize.Width;
        float heightRatio = (float)control.Height / originalSize.Height;

        foreach (Control con in control.Controls)
        {
            string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
            int a = Convert.ToInt32(mytag[0]);
            int b = Convert.ToInt32(mytag[1]);
            int c = Convert.ToInt32(mytag[2]);
            int d = Convert.ToInt32(mytag[3]);
            float e = Convert.ToSingle(mytag[4]);

            con.Width = (int)(a * widthRatio);
            con.Height = (int)(b * heightRatio);
            con.Left = (int)(c * widthRatio);
            con.Top = (int)(d * heightRatio);
            con.Font = new Font(con.Font.FontFamily, e * heightRatio, con.Font.Style, con.Font.Unit);
            if (con.Controls.Count > 0)
            {
                ResizeForm(con, originalSize);
            }
        }
    }
}
