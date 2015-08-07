using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel
{
    public class PictureModel
    {
        public System.Guid PictureId { get; set; }
        public byte[] PictureBinary { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public string OriginURL { get; set; }
    }
}
