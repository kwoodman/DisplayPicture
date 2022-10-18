using System.Buffers.Text;
using System.Xml.Linq;

namespace DisplayPicture.Shared
{
    public class PictureModel
    {
        public string name { get; set; } = "";
        public string src { get; set; } = "";
        public bool shownalready { get; set; } = false;
        public int sortorder = 0;
        
    }
}
