using Pharmacy.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models.Response
{
    public class GetMedicinesByManufacturerResponse
    {
     
            public Manufacturer? Manufacturer { get; set; }

            public List<Medicine>? Medicines { get; set; }
     }
}

