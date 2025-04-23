using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.Maps
{
    [Serializable]
    public class GMapMarkerHomeWP : GMarkerGoogle
    {
        private static Bitmap icon = new Bitmap("C:\\Users\\sean1\\OneDrive\\桌面\\GitHub\\others\\MissionPlanner\\Resources\\images\\wp_startpoint.png");

        public GMapMarkerHomeWP(PointLatLng pos) : base(pos, icon)
        {
            Offset = new Point(-icon.Width / 2, -icon.Height / 2);
        }


    }
}
