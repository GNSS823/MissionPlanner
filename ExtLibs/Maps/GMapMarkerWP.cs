using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MissionPlanner.Maps
{
    [Serializable]
    public class GMapMarkerWP : GMarkerGoogle
    {
        string wpno = "";
        public bool selected = false;
        SizeF txtsize = SizeF.Empty;
        static Dictionary<string, Bitmap> fontBitmaps = new Dictionary<string, Bitmap>();
        static Font font;
        private static Bitmap icon = new Bitmap("C:\\Users\\sean1\\OneDrive\\桌面\\GitHub\\others\\MissionPlanner\\Resources\\images\\wp_waypoint.png");

        public GMapMarkerWP(PointLatLng p, string wpno)
            : base(p, icon)
        {
            this.wpno = wpno;

            // Set the offset to center the marker
            Offset = new Point(-icon.Width / 2, -icon.Height / 2);
            if (font == null)
                font = SystemFonts.DefaultFont;

            if (!fontBitmaps.ContainsKey(wpno))
            {
                Bitmap temp = new Bitmap(100,40, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(temp))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    txtsize = g.MeasureString(wpno, font);

                    g.DrawString(wpno, font, Brushes.Black, new PointF(0, 0));
                }
                fontBitmaps[wpno] = temp;
            }
        }

        public override void OnRender(IGraphics g)
        {
            if (selected)
            {
                g.FillEllipse(Brushes.Red, new Rectangle(this.LocalPosition, this.Size));
                g.DrawArc(Pens.Red, new Rectangle(this.LocalPosition, this.Size), 0, 360);
            }
            
            base.OnRender(g);

            //var midw = LocalPosition.X + 10;
            //var midh = LocalPosition.Y + 3;

            var midw = LocalPosition.X + 10;
            var midh = LocalPosition.Y - icon.Height / 2;

            if (txtsize.Width > 15)
                midw -= 4;

            if (Overlay.Control.Zoom> 16 || IsMouseOver)
                g.DrawImageUnscaled(fontBitmaps[wpno], midw,midh);
        }
    }
}