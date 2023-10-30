using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    public class Images
    {
        public int ImagesId { get; set; }
        public string ImageName { get; set; }
        public byte[] ImageData { get; set; }
    }
}
