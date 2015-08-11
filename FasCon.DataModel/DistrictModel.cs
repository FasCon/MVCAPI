using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel
{
    public class DistrictModel
    {
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public Nullable<int> StateProvinceId { get; set; }
        public bool Published { get; set; }
    }
}
