using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest
{
    class MainPageModel
    {

        public string PNGImageUrl { get; set; }
        public string WEBPImageUrl { get; set; }


        public MainPageModel()
        {
            PNGImageUrl = "https://developers.google.com/chart/interactive/images/chart_printable.png";
            WEBPImageUrl = "https://www.gstatic.com/webp/gallery/1.sm.webp";
        }
    }
}
