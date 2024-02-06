using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models.Request
{
    public class GetMedicinesByManufacturerRequest
    {
        public int ManufacturerId { get; set; }

        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set;}
    }

}
