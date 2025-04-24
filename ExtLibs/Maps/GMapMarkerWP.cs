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
        private static Bitmap icon = Resources.wp_waypoint;

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
                Bitmap temp = new Bitmap(icon.Width / 2, icon.Height / 2, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(temp))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                    // Measure text size
                    txtsize = g.MeasureString(wpno, font);

                    // Set background color
                    g.Clear(Color.White);

                    // Calculate text position to center it
                    float textX = (temp.Width - txtsize.Width) / 2;
                    float textY = (temp.Height - txtsize.Height) / 2;

                    // Draw the text
                    g.DrawString(wpno, font, Brushes.Black, new PointF(textX, textY));
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

            if (Overlay.Control.Zoom> 16 || IsMouseOver)
            {
                var midw = LocalPosition.X + fontBitmaps[wpno].Width / 2;
                var midh = LocalPosition.Y - icon.Height / 2;
                g.DrawImageUnscaled(fontBitmaps[wpno], midw,midh);
            }
        }
    }
}